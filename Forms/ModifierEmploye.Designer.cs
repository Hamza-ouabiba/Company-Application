namespace RNetApp
{
    partial class ModifierEmploye
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
            this.prenom = new System.Windows.Forms.TextBox();
            this.salaire = new System.Windows.Forms.TextBox();
            this.avance = new System.Windows.Forms.TextBox();
            this.SalaireRest = new System.Windows.Forms.TextBox();
            this.abscence = new System.Windows.Forms.TextBox();
            this.modifier = new System.Windows.Forms.Button();
            this.congerBtn = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DD = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.repos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateDebut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // prenom
            // 
            this.prenom.Location = new System.Drawing.Point(105, 122);
            this.prenom.Name = "prenom";
            this.prenom.PlaceholderText = "Nom";
            this.prenom.Size = new System.Drawing.Size(203, 27);
            this.prenom.TabIndex = 0;
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(105, 193);
            this.salaire.Name = "salaire";
            this.salaire.PlaceholderText = "Salaire";
            this.salaire.Size = new System.Drawing.Size(203, 27);
            this.salaire.TabIndex = 1;
            // 
            // avance
            // 
            this.avance.Location = new System.Drawing.Point(105, 277);
            this.avance.Name = "avance";
            this.avance.Size = new System.Drawing.Size(203, 27);
            this.avance.TabIndex = 4;
            // 
            // SalaireRest
            // 
            this.SalaireRest.Location = new System.Drawing.Point(105, 354);
            this.SalaireRest.Name = "SalaireRest";
            this.SalaireRest.Size = new System.Drawing.Size(203, 27);
            this.SalaireRest.TabIndex = 6;
            this.SalaireRest.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // abscence
            // 
            this.abscence.Location = new System.Drawing.Point(457, 122);
            this.abscence.Name = "abscence";
            this.abscence.Size = new System.Drawing.Size(203, 27);
            this.abscence.TabIndex = 8;
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modifier.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modifier.Location = new System.Drawing.Point(280, 452);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(227, 59);
            this.modifier.TabIndex = 12;
            this.modifier.Text = "Modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // congerBtn
            // 
            this.congerBtn.BackColor = System.Drawing.Color.Lime;
            this.congerBtn.Enabled = false;
            this.congerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.congerBtn.IconChar = FontAwesome.Sharp.IconChar.Calendar;
            this.congerBtn.IconColor = System.Drawing.Color.Black;
            this.congerBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.congerBtn.IconSize = 27;
            this.congerBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.congerBtn.Location = new System.Drawing.Point(479, 251);
            this.congerBtn.Name = "congerBtn";
            this.congerBtn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.congerBtn.Size = new System.Drawing.Size(160, 44);
            this.congerBtn.TabIndex = 73;
            this.congerBtn.Text = "Calcul de Repos";
            this.congerBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.congerBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(736, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(891, 383);
            this.dataGridView1.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nom employé";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 76;
            this.label2.Text = "Salaire ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "Avance";
            // 
            // DD
            // 
            this.DD.AutoSize = true;
            this.DD.Location = new System.Drawing.Point(105, 324);
            this.DD.Name = "DD";
            this.DD.Size = new System.Drawing.Size(167, 20);
            this.DD.TabIndex = 78;
            this.DD.Text = "Montant restant a payer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(457, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "Abscence";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(457, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Repos";
            // 
            // repos
            // 
            this.repos.Location = new System.Drawing.Point(457, 203);
            this.repos.Name = "repos";
            this.repos.Size = new System.Drawing.Size(203, 27);
            this.repos.TabIndex = 80;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(457, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "Date de debut de travail";
            // 
            // dateDebut
            // 
            this.dateDebut.Location = new System.Drawing.Point(457, 352);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(203, 27);
            this.dateDebut.TabIndex = 82;
            // 
            // ModifierEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1639, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateDebut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.repos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.congerBtn);
            this.Controls.Add(this.modifier);
            this.Controls.Add(this.abscence);
            this.Controls.Add(this.SalaireRest);
            this.Controls.Add(this.avance);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.prenom);
            this.Name = "ModifierEmploye";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierEmploye";
            this.Load += new System.EventHandler(this.ModifierEmploye_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox SalaireRest;
        private TextBox textBox5;
        private Button modifier;
        private FontAwesome.Sharp.IconButton congerBtn;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox salaire;
        private TextBox avance;
        private TextBox abscence;
        private Label DD;
        private TextBox repos;
        private TextBox prenom;
        private Label label6;
        private TextBox dateDebut;
    }
}