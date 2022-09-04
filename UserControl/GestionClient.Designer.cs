namespace RNetApp
{
    partial class GestionClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nbreClt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.recherche = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.enregBtn = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Montant = new System.Windows.Forms.TextBox();
            this.nomClt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rechercher = new FontAwesome.Sharp.IconButton();
            this.idClientT = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.ficheBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.videError = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nbreClt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(95, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 52);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            // 
            // nbreClt
            // 
            this.nbreClt.AutoSize = true;
            this.nbreClt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbreClt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.nbreClt.Location = new System.Drawing.Point(232, 15);
            this.nbreClt.Name = "nbreClt";
            this.nbreClt.Size = new System.Drawing.Size(65, 28);
            this.nbreClt.TabIndex = 6;
            this.nbreClt.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "nombre de client";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(777, 157);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 67;
            // 
            // recherche
            // 
            this.recherche.BackColor = System.Drawing.SystemColors.Control;
            this.recherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recherche.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recherche.Location = new System.Drawing.Point(777, 124);
            this.recherche.Name = "recherche";
            this.recherche.PlaceholderText = "Rechercher un client";
            this.recherche.Size = new System.Drawing.Size(331, 27);
            this.recherche.TabIndex = 66;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.enregBtn);
            this.groupBox1.Controls.Add(this.Panel2);
            this.groupBox1.Controls.Add(this.Montant);
            this.groupBox1.Controls.Add(this.nomClt);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(95, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 334);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "MAD";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(92, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 60;
            // 
            // enregBtn
            // 
            this.enregBtn.BackColor = System.Drawing.Color.Lime;
            this.enregBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.enregBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enregBtn.Location = new System.Drawing.Point(41, 254);
            this.enregBtn.Name = "enregBtn";
            this.enregBtn.Size = new System.Drawing.Size(337, 46);
            this.enregBtn.TabIndex = 6;
            this.enregBtn.Text = "Enregistrer";
            this.enregBtn.UseVisualStyleBackColor = false;
            this.enregBtn.Click += new System.EventHandler(this.enregBtn_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(92, 88);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(200, 1);
            this.Panel2.TabIndex = 59;
            // 
            // Montant
            // 
            this.Montant.BackColor = System.Drawing.SystemColors.Control;
            this.Montant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Montant.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Montant.Location = new System.Drawing.Point(92, 121);
            this.Montant.Name = "Montant";
            this.Montant.PlaceholderText = "Montant Du mois";
            this.Montant.Size = new System.Drawing.Size(176, 23);
            this.Montant.TabIndex = 1;
            // 
            // nomClt
            // 
            this.nomClt.BackColor = System.Drawing.SystemColors.Control;
            this.nomClt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomClt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomClt.Location = new System.Drawing.Point(92, 55);
            this.nomClt.Name = "nomClt";
            this.nomClt.PlaceholderText = "Nom client";
            this.nomClt.Size = new System.Drawing.Size(251, 23);
            this.nomClt.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(612, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Size = new System.Drawing.Size(833, 457);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 27);
            this.label1.TabIndex = 63;
            this.label1.Text = "Gestion de Clients";
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechercher.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.rechercher.IconColor = System.Drawing.Color.White;
            this.rechercher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rechercher.IconSize = 27;
            this.rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rechercher.Location = new System.Drawing.Point(1103, 115);
            this.rechercher.Name = "rechercher";
            this.rechercher.Padding = new System.Windows.Forms.Padding(5);
            this.rechercher.Size = new System.Drawing.Size(167, 43);
            this.rechercher.TabIndex = 70;
            this.rechercher.Text = "Rechercher";
            this.rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // idClientT
            // 
            this.idClientT.Location = new System.Drawing.Point(112, 33);
            this.idClientT.Name = "idClientT";
            this.idClientT.Size = new System.Drawing.Size(125, 27);
            this.idClientT.TabIndex = 71;
            this.idClientT.Visible = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(777, 96);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 20);
            this.error.TabIndex = 72;
            this.error.Visible = false;
            // 
            // ficheBtn
            // 
            this.ficheBtn.BackColor = System.Drawing.Color.Yellow;
            this.ficheBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ficheBtn.Enabled = false;
            this.ficheBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ficheBtn.Location = new System.Drawing.Point(1442, 25);
            this.ficheBtn.Name = "ficheBtn";
            this.ficheBtn.Size = new System.Drawing.Size(136, 46);
            this.ficheBtn.TabIndex = 81;
            this.ficheBtn.Text = "Voir Fiche";
            this.ficheBtn.UseVisualStyleBackColor = false;
            this.ficheBtn.Click += new System.EventHandler(this.ficheBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(889, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 20);
            this.label3.TabIndex = 80;
            this.label3.Text = "Fiche de chaque Client";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1103, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 28);
            this.comboBox1.TabIndex = 79;
            // 
            // videError
            // 
            this.videError.AutoSize = true;
            this.videError.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videError.ForeColor = System.Drawing.Color.Red;
            this.videError.Location = new System.Drawing.Point(612, 170);
            this.videError.Name = "videError";
            this.videError.Size = new System.Drawing.Size(59, 25);
            this.videError.TabIndex = 82;
            this.videError.Text = "label6";
            this.videError.Visible = false;
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.videError);
            this.Controls.Add(this.ficheBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.idClientT);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "GestionClient";
            this.Size = new System.Drawing.Size(1525, 757);
            this.Load += new System.EventHandler(this.GestionClient_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox3;
        private Label nbreClt;
        private Label label2;
        internal Panel panel1;
        private TextBox recherche;
        private GroupBox groupBox1;
        internal Panel panel4;
        private Button enregBtn;
        internal Panel Panel2;
        private TextBox Montant;
        private TextBox nomClt;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label4;
        private FontAwesome.Sharp.IconButton rechercher;
        private TextBox idClientT;
        private Label error;
        private Button ficheBtn;
        private Label label3;
        private ComboBox comboBox1;
        private Label videError;
    }
}
