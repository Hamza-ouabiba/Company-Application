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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AjoutFac = new FontAwesome.Sharp.IconButton();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.actuaNu = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.regler = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nnregler = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nbrefac);
            this.groupBox2.Location = new System.Drawing.Point(27, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(289, 39);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre de facture";
            // 
            // nbrefac
            // 
            this.nbrefac.AutoSize = true;
            this.nbrefac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbrefac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.nbrefac.Location = new System.Drawing.Point(203, 11);
            this.nbrefac.Name = "nbrefac";
            this.nbrefac.Size = new System.Drawing.Size(52, 21);
            this.nbrefac.TabIndex = 3;
            this.nbrefac.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gestion de Facture";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(626, 37);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 23);
            this.comboBox1.TabIndex = 82;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 232);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1370, 403);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(313, 38);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(257, 23);
            this.comboBox2.TabIndex = 86;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            this.comboBox2.TextChanged += new System.EventHandler(this.comboBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 15);
            this.label3.TabIndex = 87;
            this.label3.Text = "Les numéros de facture";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(626, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 15);
            this.label4.TabIndex = 88;
            this.label4.Text = "Client Récent";
            // 
            // AjoutFac
            // 
            this.AjoutFac.BackColor = System.Drawing.Color.Lime;
            this.AjoutFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjoutFac.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AjoutFac.IconColor = System.Drawing.Color.Black;
            this.AjoutFac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AjoutFac.IconSize = 30;
            this.AjoutFac.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AjoutFac.Location = new System.Drawing.Point(1211, 32);
            this.AjoutFac.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AjoutFac.Name = "AjoutFac";
            this.AjoutFac.Size = new System.Drawing.Size(128, 29);
            this.AjoutFac.TabIndex = 89;
            this.AjoutFac.Text = "Ajouter Facture";
            this.AjoutFac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjoutFac.UseVisualStyleBackColor = false;
            this.AjoutFac.Click += new System.EventHandler(this.AjoutFac_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(920, 37);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(257, 23);
            this.comboBox3.TabIndex = 90;
            // 
            // actuaNu
            // 
            this.actuaNu.BackColor = System.Drawing.Color.Red;
            this.actuaNu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actuaNu.ForeColor = System.Drawing.Color.White;
            this.actuaNu.IconChar = FontAwesome.Sharp.IconChar.None;
            this.actuaNu.IconColor = System.Drawing.Color.Black;
            this.actuaNu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.actuaNu.Location = new System.Drawing.Point(1095, 92);
            this.actuaNu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.actuaNu.Name = "actuaNu";
            this.actuaNu.Size = new System.Drawing.Size(244, 31);
            this.actuaNu.TabIndex = 91;
            this.actuaNu.Text = "Actualiser les numéros de facture ";
            this.actuaNu.UseVisualStyleBackColor = false;
            this.actuaNu.Click += new System.EventHandler(this.actuaNu_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.ForeColor = System.Drawing.Color.DarkGray;
            this.panel1.Location = new System.Drawing.Point(3, 212);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1382, 1);
            this.panel1.TabIndex = 96;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(14, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 92;
            this.label5.Text = " RÉGLER";
            // 
            // regler
            // 
            this.regler.AutoSize = true;
            this.regler.ForeColor = System.Drawing.Color.ForestGreen;
            this.regler.Location = new System.Drawing.Point(26, 44);
            this.regler.Name = "regler";
            this.regler.Size = new System.Drawing.Size(38, 15);
            this.regler.TabIndex = 93;
            this.regler.Text = "label6";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.IndianRed;
            this.label8.Location = new System.Drawing.Point(158, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 94;
            this.label8.Text = "NON RÉGLER";
            // 
            // nnregler
            // 
            this.nnregler.AutoSize = true;
            this.nnregler.ForeColor = System.Drawing.Color.IndianRed;
            this.nnregler.Location = new System.Drawing.Point(175, 44);
            this.nnregler.Name = "nnregler";
            this.nnregler.Size = new System.Drawing.Size(38, 15);
            this.nnregler.TabIndex = 95;
            this.nnregler.Text = "label7";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nnregler);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.regler);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(457, 106);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(253, 77);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // GestionFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.actuaNu);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.AjoutFac);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionFacture";
            this.Size = new System.Drawing.Size(1370, 847);
            this.Load += new System.EventHandler(this.GestionFacture_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox2;
        private Label label2;
        private Label nbrefac;
        private Label label1;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private ComboBox comboBox2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton AjoutFac;
        private ComboBox comboBox3;
        private FontAwesome.Sharp.IconButton actuaNu;
        private Panel panel1;
        private Label label5;
        private Label regler;
        private Label label8;
        private Label nnregler;
        private GroupBox groupBox1;
    }
}
