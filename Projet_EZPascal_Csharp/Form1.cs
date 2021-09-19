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
using System.Drawing.Drawing2D;

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
            //nb_ex = (int) Num_NBex.Value; //mis en com car fait dans le refresh
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
            N_sousExs.Value = 0;
            TB_name.Text = "";
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

            this.N_sousExs.Value = array_subExs[exSelector];
            this.label2.Text = "Exercice "+exSelector+" :";
        }


        private void B_generate_Click(object sender, EventArgs e)       //generate the file
        {
            try
            {
                Writing wr = new Writing(name, name+".lpr");
            
                wr.entete(nb_ex);
                //ecriture de l'entete du programme

                //boucle de création des exercices
                for (int j = 1; j <= nb_ex; j++) {
                    wr.numex_debut(j);          //écriture des numEx
                    int printed_k = 0;
                    if (array_subExs[j] >= 2) { //!= 0
                        wr.entete_SN();           //écriture de l'entête des sous num

                        for (int k=1;k<= array_subExs[j];k++)
                        {
                            wr.SN(j,k);            //écriture des sous num
                            printed_k = k;
                        }

                        wr.SN_fin();              //écriture des fins des sousNum
                    }
                    
                    wr.numex_fin(j, printed_k);
                }

                wr.FIN(nb_ex);                   //écriture de la fin du programme
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string pattern_names = @"^CON$|^PRN$|^AUX$|^NUL$|^COM[0-9]$|^LPT[0-9]$"; //forbids to name file after forbidden windows names
            Match m = Regex.Match(TB_name.Text, pattern_names, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                this.l_nameError.Text = "Nom incorrect, veuillez en choisir un autre";
                this.B_generate.Enabled = false;

            }
            else
            {
                this.l_nameError.Text = "";
                this.B_generate.Enabled = true;
            }

            string pattern_chars = @"[^a-zA-Z0-9_\-]"; //forbids to name file with anything else than alphanumeric characters or "_" or "-"
            m = Regex.Match(TB_name.Text, pattern_chars, RegexOptions.IgnoreCase);
            if (m.Success)
            {
                this.TB_name.Text = this.TB_name.Text.Remove(this.TB_name.Text.Length - 1); //delete the unauthorized char
                TB_name.SelectionStart = TB_name.Text.Length; //put the cursor at the end of the selection (bc if not, after typing an unauthorized char, it will go back to the beginning of the textbox, which is disturbing
            }

            name = this.TB_name.Text;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    class RoundedButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();
            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            using (GraphicsPath GraphPath = GetRoundPath(Rect, 25))             // HERE WE CAN CHANGE THE RADUIS OF THE CORNERS OF THE RoundedButtons
            {
                this.Region = new Region(GraphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawPath(pen, GraphPath);
                }
            }
        }
    }
    
    public class RoundPanel : GroupBox
    {
        public RoundPanel()
        {
            this.DoubleBuffered = true;
            this.TitleBackColor = Color.SteelBlue;
            this.TitleForeColor = Color.Red;
            this.TitleFont = new Font(this.Font.FontFamily, Font.Size + 8, FontStyle.Bold);
            this.BackColor = Color.Transparent;
            this.Radious = 25;
            this.TitleHatchStyle = HatchStyle.Percent60;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GroupBoxRenderer.DrawParentBackground(e.Graphics, this.ClientRectangle, this);
            var rect = ClientRectangle;
            using (var path = GetRoundRectagle(this.ClientRectangle, Radious))
            {
                
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                rect = new Rectangle(0, 0,
                    (rect.Width)/10, TitleFont.Height + Padding.Bottom + Padding.Top);
                if (this.BackColor != Color.Transparent)
                    using (var brush = new SolidBrush(BackColor))
                        e.Graphics.FillPath(brush, path);
                var clip = e.Graphics.ClipBounds;
                e.Graphics.SetClip(rect);
                /*
                using (var brush = new HatchBrush(TitleHatchStyle,
                    TitleBackColor, ControlPaint.Light(TitleBackColor)))
                    e.Graphics.FillPath(brush, path);
                using (var pen = new Pen(TitleBackColor, 1))
                    e.Graphics.DrawPath(pen, path);
                
                TextRenderer.DrawText(e.Graphics, Text, TitleFont, rect, TitleForeColor);
                e.Graphics.SetClip(clip);
                using (var pen = new Pen(TitleBackColor, 1))
                    e.Graphics.DrawPath(pen, path);
                */
            }
        }
        public Color TitleBackColor { get; set; }
        public HatchStyle TitleHatchStyle { get; set; }
        public Font TitleFont { get; set; }
        public Color TitleForeColor { get; set; }
        public int Radious { get; set; }
        private GraphicsPath GetRoundRectagle(Rectangle b, int r)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(b.X, b.Y, r, r, 180, 90);
            path.AddArc(b.X + b.Width - r - 1, b.Y, r, r, 270, 90);
            path.AddArc(b.X + b.Width - r - 1, b.Y + b.Height - r - 1, r, r, 0, 90);
            path.AddArc(b.X, b.Y + b.Height - r - 1, r, r, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }

    /*
    class CustomGrpBox : GroupBox
    {
        public CustomGrpBox()
        {
            this.DoubleBuffered = true;
            this.BackColor = Color.Transparent;
            this.Radious = 25;
            this.TitleHatchStyle = HatchStyle.Percent60;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GroupBoxRenderer.DrawParentBackground(e.Graphics, this.ClientRectangle, this);
            var rect = ClientRectangle;
            using (var path = GetRoundRectagle(this.ClientRectangle, Radious))
            {

                if (this.BackColor != Color.Transparent)
                    using (var brush = new SolidBrush(BackColor))
                        e.Graphics.FillPath(brush, path);
                //
                using (var brush = new HatchBrush(TitleHatchStyle,
                TitleBackColor, ControlPaint.Light(TitleBackColor)))
                    e.Graphics.FillPath(brush, path);
                //

            }
        }
        public Color TitleBackColor { get; set; }
        public HatchStyle TitleHatchStyle { get; set; }
        public int Radious { get; set; }
        private GraphicsPath GetRoundRectagle(Rectangle b, int r)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(b.X, b.Y, r, r, 180, 90);
            path.AddArc(b.X + b.Width - r - 1, b.Y, r, r, 270, 90);
            path.AddArc(b.X + b.Width - r - 1, b.Y + b.Height - r - 1, r, r, 0, 90);
            path.AddArc(b.X, b.Y + b.Height - r - 1, r, r, 90, 90);
            path.CloseAllFigures();
            return path;
        }
    }
    */


}
