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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbrefac = new System.Windows.Forms.Label();
            this.factureBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rechercher = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.verifierBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(147, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1151, 423);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // GestionFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.verifierBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.factureBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "GestionFacture";
            this.Size = new System.Drawing.Size(1566, 1129);
            this.Load += new System.EventHandler(this.GestionFacture_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private Label label2;
        private Label nbrefac;
        private Button factureBtn;
        private Label label1;
        private FontAwesome.Sharp.IconButton rechercher;
        private Label label3;
        private ComboBox comboBox1;
        private Button verifierBtn;
        private DataGridView dataGridView1;
    }
}
