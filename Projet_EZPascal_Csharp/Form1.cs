using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Projet_EZPascal_Csharp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            refresh();
        }

        private int nb_ex;
        private int[] array_subExs = new int[20];
        private String name;
        private int exSelector = 1;
        //private 




        private void label1_Click(object sender, EventArgs e)           //title
        {

        }
        private void label2_Click(object sender, EventArgs e)           //exercise indicator
        {

        }
        private void B_next_Click(object sender, EventArgs e)           //next exercise
        {
            this.exSelector++;
            refresh();
        }
       
        private void B_previous_Click(object sender, EventArgs e)       //previous exercise
        {
            this.exSelector--;
            refresh();
        }

        private void button2_Click(object sender, EventArgs e)          // ??
        {

        }

        private void Num_NBex_ValueChanged(object sender, EventArgs e)  //number of exercises
        {
            refresh();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)//number of sub-exercises
        {
            array_subExs[exSelector] = (int) N_sousExs.Value;
        }

        private void button1_Click(object sender, EventArgs e)          //cancel button
        {
            foreach (int i in this.array_subExs)
            {
                array_subExs[i] = 0;
            }
            exSelector = 1;
            Num_NBex.Value = 1;
            refresh();
        }

        /**
         * refresh the botton states, and the selector after each modification from the user
         */
        private void refresh()              
        {
            nb_ex = (int)Num_NBex.Value;
            this.B_previous.Enabled = (this.exSelector > 1);       //the prev button is disabled if the selected ex is the first
  
            if (exSelector >= nb_ex)                       //the next button is disabled if the selected ex is the last
            {
                this.B_next.Enabled = false;
                nb_ex = (int)Num_NBex.Value;
                exSelector = nb_ex;
            }
            else
            {
                this.B_next.Enabled = true;
            }

            this.label2.Text = "Exercice "+exSelector+" :";
        }


        private void B_generate_Click(object sender, EventArgs e)       //generate the file
        {
            Writing wr = new Writing(this.name,"PATH");

            wr.entete(nb_ex);
            //ecriture de l'entete du programme

            //boucle de création des exercices
            for (int j = 1; j <= nb_ex; j++) {
                wr.numex_debut(j);          //écriture des numEx

                if (array_subExs[j] != 0) {
                    wr.entete_SN();           //écriture de l'entête des sous num

                    for (int k=1;k<= array_subExs[j];k++)
                    {
                         wr.SN(k);            //écriture des sous num
                    }

                    wr.SN_fin();              //écriture des fins des sousNum
                }
                wr.numex_fin(j);
            }

            wr.FIN(nb_ex);                   //écriture de la fin du programme
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = this.TB_name.Text;
            string pattern_names = @"^CON$|^PRN$|^AUX$|^NUL$|^COM[0-9]$|^LPT[0-9]$"; //forbids to name file after forbidden windows names
            Match m = Regex.Match(name, pattern_names, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                this.l_nameError.Text = "Nom incorrect, veuillez en choisir un autre";
                this.B_generate.Enabled = false;

            }
            else
            {
                this.l_nameError.Text = ""; 
            }

            string pattern_chars = @"[^a-zA-Z0-9_\-]"; //forbids to name file with anything else than alphanumeric characters or "_" or "-"
            m = Regex.Match(name, pattern_chars, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                this.TB_name.Text = this.TB_name.Text.Remove(this.TB_name.Text.Length - 1); //delete the unauthorized char
                TB_name.SelectionStart = TB_name.Text.Length; //put the cursor at the end of the selection (bc if not, after typing an unauthorized char, it will go back to the beginning of the textbox, which is disturbing
            }
  
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
