
namespace Projet_EZPascal_Csharp
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.L_titleEZP = new System.Windows.Forms.Label();
            this.Num_NBex = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.N_sousExs = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.B_next = new System.Windows.Forms.Button();
            this.B_previous = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.B_cancel = new System.Windows.Forms.Button();
            this.B_generate = new System.Windows.Forms.Button();
            this.GB_title = new System.Windows.Forms.GroupBox();
            this.TB_name = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Num_NBex)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_sousExs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.GB_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_titleEZP
            // 
            this.L_titleEZP.Dock = System.Windows.Forms.DockStyle.Top;
            this.L_titleEZP.Font = new System.Drawing.Font("Yu Gothic UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_titleEZP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.L_titleEZP.Location = new System.Drawing.Point(0, 0);
            this.L_titleEZP.Name = "L_titleEZP";
            this.L_titleEZP.Size = new System.Drawing.Size(308, 107);
            this.L_titleEZP.TabIndex = 0;
            this.L_titleEZP.Text = "EZ Pascal";
            this.L_titleEZP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.L_titleEZP.Click += new System.EventHandler(this.label1_Click);
            // 
            // Num_NBex
            // 
            this.Num_NBex.Location = new System.Drawing.Point(81, 25);
            this.Num_NBex.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.Num_NBex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_NBex.Name = "Num_NBex";
            this.Num_NBex.Size = new System.Drawing.Size(115, 26);
            this.Num_NBex.TabIndex = 1;
            this.Num_NBex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Num_NBex.ValueChanged += new System.EventHandler(this.Num_NBex_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.N_sousExs);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.B_next);
            this.groupBox1.Controls.Add(this.B_previous);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(15, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 104);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nombres de sous-numéros";
            // 
            // N_sousExs
            // 
            this.N_sousExs.Location = new System.Drawing.Point(157, 59);
            this.N_sousExs.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.N_sousExs.Name = "N_sousExs";
            this.N_sousExs.Size = new System.Drawing.Size(115, 26);
            this.N_sousExs.TabIndex = 0;
            this.N_sousExs.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Exercice X : ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // B_next
            // 
            this.B_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_next.Location = new System.Drawing.Point(157, 19);
            this.B_next.Name = "B_next";
            this.B_next.Size = new System.Drawing.Size(115, 23);
            this.B_next.TabIndex = 3;
            this.B_next.Text = "→";
            this.B_next.UseVisualStyleBackColor = true;
            this.B_next.Click += new System.EventHandler(this.B_next_Click);
            // 
            // B_previous
            // 
            this.B_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_previous.Location = new System.Drawing.Point(6, 20);
            this.B_previous.Name = "B_previous";
            this.B_previous.Size = new System.Drawing.Size(115, 22);
            this.B_previous.TabIndex = 2;
            this.B_previous.Text = "←";
            this.B_previous.UseVisualStyleBackColor = true;
            this.B_previous.Click += new System.EventHandler(this.B_previous_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Num_NBex);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(15, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 68);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nombre d\'exercices : ";
            // 
            // B_cancel
            // 
            this.B_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.B_cancel.Location = new System.Drawing.Point(48, 411);
            this.B_cancel.Name = "B_cancel";
            this.B_cancel.Size = new System.Drawing.Size(75, 23);
            this.B_cancel.TabIndex = 4;
            this.B_cancel.Text = "Annuler";
            this.B_cancel.UseVisualStyleBackColor = true;
            this.B_cancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // B_generate
            // 
            this.B_generate.Location = new System.Drawing.Point(172, 411);
            this.B_generate.Name = "B_generate";
            this.B_generate.Size = new System.Drawing.Size(75, 23);
            this.B_generate.TabIndex = 5;
            this.B_generate.Text = "Générer";
            this.B_generate.UseVisualStyleBackColor = true;
            this.B_generate.Click += new System.EventHandler(this.B_generate_Click);
            // 
            // GB_title
            // 
            this.GB_title.Controls.Add(this.TB_name);
            this.GB_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_title.Location = new System.Drawing.Point(12, 110);
            this.GB_title.Name = "GB_title";
            this.GB_title.Size = new System.Drawing.Size(280, 82);
            this.GB_title.TabIndex = 6;
            this.GB_title.TabStop = false;
            this.GB_title.Text = "Titre du programme :";
            // 
            // TB_name
            // 
            this.TB_name.Location = new System.Drawing.Point(7, 26);
            this.TB_name.Name = "TB_name";
            this.TB_name.Size = new System.Drawing.Size(267, 26);
            this.TB_name.TabIndex = 0;
            this.TB_name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.B_generate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.B_cancel;
            this.ClientSize = new System.Drawing.Size(308, 460);
            this.Controls.Add(this.GB_title);
            this.Controls.Add(this.B_generate);
            this.Controls.Add(this.B_cancel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.L_titleEZP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "EZ Pascal";
            ((System.ComponentModel.ISupportInitialize)(this.Num_NBex)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.N_sousExs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.GB_title.ResumeLayout(false);
            this.GB_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label L_titleEZP;
        private System.Windows.Forms.NumericUpDown Num_NBex;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown N_sousExs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_next;
        private System.Windows.Forms.Button B_previous;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button B_cancel;
        private System.Windows.Forms.Button B_generate;
        private System.Windows.Forms.GroupBox GB_title;
        private System.Windows.Forms.TextBox TB_name;
    }
}

