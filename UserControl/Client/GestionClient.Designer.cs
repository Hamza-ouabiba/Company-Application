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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nbreClt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idClientT = new System.Windows.Forms.TextBox();
            this.error = new System.Windows.Forms.Label();
            this.videError = new System.Windows.Forms.Label();
            this.clientCombo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AjoutClient = new FontAwesome.Sharp.IconButton();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nbreClt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(27, 95);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(289, 39);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            // 
            // nbreClt
            // 
            this.nbreClt.AutoSize = true;
            this.nbreClt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbreClt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.nbreClt.Location = new System.Drawing.Point(203, 11);
            this.nbreClt.Name = "nbreClt";
            this.nbreClt.Size = new System.Drawing.Size(52, 21);
            this.nbreClt.TabIndex = 6;
            this.nbreClt.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "nombre de client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 63;
            this.label1.Text = "Gestion de Clients";
            // 
            // idClientT
            // 
            this.idClientT.Location = new System.Drawing.Point(334, 12);
            this.idClientT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idClientT.Name = "idClientT";
            this.idClientT.Size = new System.Drawing.Size(110, 23);
            this.idClientT.TabIndex = 71;
            this.idClientT.Visible = false;
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(680, 72);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 15);
            this.error.TabIndex = 72;
            this.error.Visible = false;
            // 
            // videError
            // 
            this.videError.AutoSize = true;
            this.videError.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.videError.ForeColor = System.Drawing.Color.Red;
            this.videError.Location = new System.Drawing.Point(536, 128);
            this.videError.Name = "videError";
            this.videError.Size = new System.Drawing.Size(50, 20);
            this.videError.TabIndex = 82;
            this.videError.Text = "label6";
            this.videError.Visible = false;
            // 
            // clientCombo
            // 
            this.clientCombo.FormattingEnabled = true;
            this.clientCombo.Location = new System.Drawing.Point(955, 68);
            this.clientCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clientCombo.Name = "clientCombo";
            this.clientCombo.Size = new System.Drawing.Size(260, 23);
            this.clientCombo.TabIndex = 83;
            this.clientCombo.SelectedValueChanged += new System.EventHandler(this.clientCombo_SelectedValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 155);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(1489, 403);
            this.dataGridView1.TabIndex = 86;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter_1);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete_1);
            // 
            // AjoutClient
            // 
            this.AjoutClient.BackColor = System.Drawing.Color.Lime;
            this.AjoutClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AjoutClient.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.AjoutClient.IconColor = System.Drawing.Color.Black;
            this.AjoutClient.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AjoutClient.IconSize = 30;
            this.AjoutClient.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AjoutClient.Location = new System.Drawing.Point(1239, 64);
            this.AjoutClient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AjoutClient.Name = "AjoutClient";
            this.AjoutClient.Size = new System.Drawing.Size(128, 29);
            this.AjoutClient.TabIndex = 87;
            this.AjoutClient.Text = "Ajouter client";
            this.AjoutClient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AjoutClient.UseVisualStyleBackColor = false;
            this.AjoutClient.Click += new System.EventHandler(this.AjoutClient_Click);
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AjoutClient);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clientCombo);
            this.Controls.Add(this.videError);
            this.Controls.Add(this.error);
            this.Controls.Add(this.idClientT);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "GestionClient";
            this.Size = new System.Drawing.Size(1489, 568);
            this.Load += new System.EventHandler(this.GestionClient_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox3;
        private Label nbreClt;
        private Label label2;
        private Label label1;
        private TextBox idClientT;
        private Label error;
        private Label videError;
        private ComboBox clientCombo;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton AjoutClient;
    }
}
