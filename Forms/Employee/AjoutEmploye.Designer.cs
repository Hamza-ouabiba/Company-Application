namespace RNetApp
{
    partial class AjoutEmploye
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Enreg = new System.Windows.Forms.Button();
            this.abscence = new System.Windows.Forms.TextBox();
            this.avance = new System.Windows.Forms.TextBox();
            this.salaire = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "Date de debut de travail";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(363, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 95;
            this.label5.Text = "Abscence";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Avance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 92;
            this.label2.Text = "Salaire ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 91;
            this.label1.Text = "Prenom Employe";
            // 
            // Enreg
            // 
            this.Enreg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Enreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Enreg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enreg.Location = new System.Drawing.Point(191, 383);
            this.Enreg.Name = "Enreg";
            this.Enreg.Size = new System.Drawing.Size(227, 59);
            this.Enreg.TabIndex = 89;
            this.Enreg.Text = "Enregistrer";
            this.Enreg.UseVisualStyleBackColor = false;
            this.Enreg.Click += new System.EventHandler(this.Enreg_Click);
            // 
            // abscence
            // 
            this.abscence.Location = new System.Drawing.Point(363, 111);
            this.abscence.Name = "abscence";
            this.abscence.Size = new System.Drawing.Size(203, 27);
            this.abscence.TabIndex = 88;
            // 
            // avance
            // 
            this.avance.Location = new System.Drawing.Point(363, 181);
            this.avance.Name = "avance";
            this.avance.Size = new System.Drawing.Size(203, 27);
            this.avance.TabIndex = 86;
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(45, 264);
            this.salaire.Name = "salaire";
            this.salaire.PlaceholderText = "Salaire";
            this.salaire.Size = new System.Drawing.Size(203, 27);
            this.salaire.TabIndex = 85;
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(45, 114);
            this.prenom.Name = "prenom";
            this.prenom.PlaceholderText = "prenom";
            this.prenom.Size = new System.Drawing.Size(203, 27);
            this.prenom.TabIndex = 84;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "Nom Employe";
            // 
            // nom
            // 
            this.nom.Location = new System.Drawing.Point(45, 192);
            this.nom.Name = "nom";
            this.nom.PlaceholderText = "Nom";
            this.nom.Size = new System.Drawing.Size(203, 27);
            this.nom.TabIndex = 100;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(337, 264);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(259, 27);
            this.dateTimePicker1.TabIndex = 102;
            // 
            // AjoutEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 515);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enreg);
            this.Controls.Add(this.abscence);
            this.Controls.Add(this.avance);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.prenom);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "AjoutEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutEmploye";
            this.Load += new System.EventHandler(this.AjoutEmploye_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Enreg;
        private TextBox abscence;
        private TextBox avance;
        private TextBox salaire;
        private TextBox prenom;
        private Label label7;
        private TextBox nom;
        private DateTimePicker dateTimePicker1;
    }
}