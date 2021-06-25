using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name=this.name
        }
    }
}
