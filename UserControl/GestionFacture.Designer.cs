namespace RNetApp
{
    partial class GestionFacture
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbrefac = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nbreCheque = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.numFac = new System.Windows.Forms.TextBox();
            this.nomCltT = new System.Windows.Forms.TextBox();
            this.factureBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.rechercher = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.verifierBtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nbrefac);
            this.groupBox2.Location = new System.Drawing.Point(95, 126);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 52);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre de facture";
            // 
            // nbrefac
            // 
            this.nbrefac.AutoSize = true;
            this.nbrefac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbrefac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.nbrefac.Location = new System.Drawing.Point(232, 15);
            this.nbrefac.Name = "nbrefac";
            this.nbrefac.Size = new System.Drawing.Size(65, 28);
            this.nbrefac.TabIndex = 3;
            this.nbrefac.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.nbreCheque);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Panel2);
            this.groupBox1.Controls.Add(this.numFac);
            this.groupBox1.Controls.Add(this.nomCltT);
            this.groupBox1.Location = new System.Drawing.Point(95, 194);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 325);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(103, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 71;
            // 
            // nbreCheque
            // 
            this.nbreCheque.BackColor = System.Drawing.SystemColors.Control;
            this.nbreCheque.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nbreCheque.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nbreCheque.Location = new System.Drawing.Point(103, 223);
            this.nbreCheque.Name = "nbreCheque";
            this.nbreCheque.PlaceholderText = "Nombre de cheque";
            this.nbreCheque.Size = new System.Drawing.Size(177, 24);
            this.nbreCheque.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(58, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(295, 31);
            this.label4.TabIndex = 64;
            this.label4.Text = "Information Sur la Facture";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(103, 181);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 61;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(103, 124);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(200, 1);
            this.Panel2.TabIndex = 60;
            // 
            // numFac
            // 
            this.numFac.BackColor = System.Drawing.SystemColors.Control;
            this.numFac.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numFac.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numFac.Location = new System.Drawing.Point(103, 98);
            this.numFac.Name = "numFac";
            this.numFac.PlaceholderText = "Numéro de Facture";
            this.numFac.Size = new System.Drawing.Size(177, 24);
            this.numFac.TabIndex = 14;
            // 
            // nomCltT
            // 
            this.nomCltT.BackColor = System.Drawing.SystemColors.Control;
            this.nomCltT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomCltT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomCltT.Location = new System.Drawing.Point(103, 155);
            this.nomCltT.Name = "nomCltT";
            this.nomCltT.PlaceholderText = "Nom Du Client";
            this.nomCltT.Size = new System.Drawing.Size(177, 24);
            this.nomCltT.TabIndex = 0;
            // 
            // factureBtn
            // 
            this.factureBtn.BackColor = System.Drawing.Color.Yellow;
            this.factureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factureBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.factureBtn.Location = new System.Drawing.Point(1140, 31);
            this.factureBtn.Name = "factureBtn";
            this.factureBtn.Size = new System.Drawing.Size(185, 42);
            this.factureBtn.TabIndex = 10;
            this.factureBtn.Text = "Ajouter une Facture";
            this.factureBtn.UseVisualStyleBackColor = false;
            this.factureBtn.Click += new System.EventHandler(this.factureBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(524, 194);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 416);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gestion de Facture";
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.Red;
            this.rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechercher.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.rechercher.IconColor = System.Drawing.Color.White;
            this.rechercher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rechercher.IconSize = 27;
            this.rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rechercher.Location = new System.Drawing.Point(1331, 31);
            this.rechercher.Name = "rechercher";
            this.rechercher.Padding = new System.Windows.Forms.Padding(5);
            this.rechercher.Size = new System.Drawing.Size(169, 43);
            this.rechercher.TabIndex = 74;
            this.rechercher.Text = "Rechercher";
            this.rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Ajout de Facture Client";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(830, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 28);
            this.comboBox1.TabIndex = 82;
            // 
            // verifierBtn
            // 
            this.verifierBtn.BackColor = System.Drawing.Color.Blue;
            this.verifierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifierBtn.ForeColor = System.Drawing.Color.White;
            this.verifierBtn.Location = new System.Drawing.Point(1310, 98);
            this.verifierBtn.Name = "verifierBtn";
            this.verifierBtn.Size = new System.Drawing.Size(237, 53);
            this.verifierBtn.TabIndex = 84;
            this.verifierBtn.Text = "verifier les factures";
            this.verifierBtn.UseVisualStyleBackColor = false;
            this.verifierBtn.Click += new System.EventHandler(this.verifierBtn_Click);
            // 
            // GestionFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.verifierBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.factureBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "GestionFacture";
            this.Size = new System.Drawing.Size(1566, 854);
            this.Load += new System.EventHandler(this.GestionFacture_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private Label label2;
        private Label nbrefac;
        private GroupBox groupBox1;
        internal Panel panel1;
        internal Panel Panel2;
        private TextBox numFac;
        private Button factureBtn;
        private TextBox nomCltT;
        private DataGridView dataGridView1;
        private Label label1;
        private FontAwesome.Sharp.IconButton rechercher;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        internal Panel panel3;
        private TextBox nbreCheque;
        private Button verifierBtn;
    }
}
