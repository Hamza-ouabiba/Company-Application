namespace RNetApp
{
    partial class GestionEmploye
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbrEmp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filtreBtn = new FontAwesome.Sharp.IconButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ficheBtn = new System.Windows.Forms.Button();
            this.filtreNnPai = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboEmp = new System.Windows.Forms.ComboBox();
            this.refresh = new System.Windows.Forms.Button();
            this.AjoutEmp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nbrEmp);
            this.groupBox2.Location = new System.Drawing.Point(95, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(384, 52);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre des employées ";
            // 
            // nbrEmp
            // 
            this.nbrEmp.AutoSize = true;
            this.nbrEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbrEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.nbrEmp.Location = new System.Drawing.Point(280, 14);
            this.nbrEmp.Name = "nbrEmp";
            this.nbrEmp.Size = new System.Drawing.Size(65, 28);
            this.nbrEmp.TabIndex = 3;
            this.nbrEmp.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "Gestion des Employées";
            // 
            // filtreBtn
            // 
            this.filtreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.filtreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filtreBtn.ForeColor = System.Drawing.Color.Black;
            this.filtreBtn.IconChar = FontAwesome.Sharp.IconChar.FilterCircleDollar;
            this.filtreBtn.IconColor = System.Drawing.Color.Black;
            this.filtreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filtreBtn.IconSize = 27;
            this.filtreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filtreBtn.Location = new System.Drawing.Point(1144, 116);
            this.filtreBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtreBtn.Name = "filtreBtn";
            this.filtreBtn.Padding = new System.Windows.Forms.Padding(5);
            this.filtreBtn.Size = new System.Drawing.Size(218, 44);
            this.filtreBtn.TabIndex = 74;
            this.filtreBtn.Text = "Filtrer par paiement";
            this.filtreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtreBtn.UseVisualStyleBackColor = false;
            this.filtreBtn.Click += new System.EventHandler(this.filtreBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1103, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 28);
            this.comboBox1.TabIndex = 76;
            this.comboBox1.ValueMemberChanged += new System.EventHandler(this.comboBox1_ValueMemberChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(889, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Fiche de chaque Employé";
            // 
            // ficheBtn
            // 
            this.ficheBtn.BackColor = System.Drawing.Color.Yellow;
            this.ficheBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ficheBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ficheBtn.Location = new System.Drawing.Point(1442, 25);
            this.ficheBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ficheBtn.Name = "ficheBtn";
            this.ficheBtn.Size = new System.Drawing.Size(136, 46);
            this.ficheBtn.TabIndex = 78;
            this.ficheBtn.Text = "Voir Fiche";
            this.ficheBtn.UseVisualStyleBackColor = false;
            this.ficheBtn.Click += new System.EventHandler(this.ficheBtn_Click);
            // 
            // filtreNnPai
            // 
            this.filtreNnPai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.filtreNnPai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreNnPai.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filtreNnPai.ForeColor = System.Drawing.Color.Black;
            this.filtreNnPai.IconChar = FontAwesome.Sharp.IconChar.FilterCircleDollar;
            this.filtreNnPai.IconColor = System.Drawing.Color.Black;
            this.filtreNnPai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filtreNnPai.IconSize = 27;
            this.filtreNnPai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filtreNnPai.Location = new System.Drawing.Point(1392, 116);
            this.filtreNnPai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtreNnPai.Name = "filtreNnPai";
            this.filtreNnPai.Padding = new System.Windows.Forms.Padding(5);
            this.filtreNnPai.Size = new System.Drawing.Size(186, 62);
            this.filtreNnPai.TabIndex = 79;
            this.filtreNnPai.Text = "Filtrer par non paiement";
            this.filtreNnPai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtreNnPai.UseVisualStyleBackColor = false;
            this.filtreNnPai.Click += new System.EventHandler(this.filtreNnPai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1605, 485);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter_1);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete_1);
            // 
            // comboEmp
            // 
            this.comboEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmp.FormattingEnabled = true;
            this.comboEmp.Location = new System.Drawing.Point(803, 126);
            this.comboEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboEmp.Name = "comboEmp";
            this.comboEmp.Size = new System.Drawing.Size(293, 28);
            this.comboEmp.TabIndex = 87;
            this.comboEmp.SelectedValueChanged += new System.EventHandler(this.comboEmp_SelectedValueChanged);
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(35, 31);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(163, 40);
            this.refresh.TabIndex = 88;
            this.refresh.Text = "Actualiser";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // AjoutEmp
            // 
            this.AjoutEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AjoutEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjoutEmp.Location = new System.Drawing.Point(522, 122);
            this.AjoutEmp.Name = "AjoutEmp";
            this.AjoutEmp.Size = new System.Drawing.Size(227, 34);
            this.AjoutEmp.TabIndex = 89;
            this.AjoutEmp.Text = "Ajouter un employée";
            this.AjoutEmp.UseVisualStyleBackColor = false;
            this.AjoutEmp.Click += new System.EventHandler(this.AjoutEmp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(0, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1585, 1);
            this.panel1.TabIndex = 97;
            // 
            // GestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AjoutEmp);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.comboEmp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.filtreNnPai);
            this.Controls.Add(this.ficheBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.filtreBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GestionEmploye";
            this.Size = new System.Drawing.Size(1592, 796);
            this.Load += new System.EventHandler(this.GestionEmploye_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox2;
        private Label label2;
        private Label nbrEmp;
        private Label label1;
        private FontAwesome.Sharp.IconButton filtreBtn;
        private ComboBox comboBox1;
        private Label label5;
        private Button ficheBtn;
        private FontAwesome.Sharp.IconButton filtreNnPai;
        private DataGridView dataGridView1;
        private ComboBox comboEmp;
        private Button refresh;
        private Button AjoutEmp;
        private Panel panel1;
    }
}
