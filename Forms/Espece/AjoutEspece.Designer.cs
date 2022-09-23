namespace RNetApp
{
    partial class AjoutEspece
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.montRest = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nomClient = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.enrBtn = new System.Windows.Forms.Button();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.montantEsp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.montRest);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(59, 258);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 52);
            this.groupBox1.TabIndex = 118;
            this.groupBox1.TabStop = false;
            // 
            // montRest
            // 
            this.montRest.AutoSize = true;
            this.montRest.ForeColor = System.Drawing.Color.Red;
            this.montRest.Location = new System.Drawing.Point(173, 20);
            this.montRest.Name = "montRest";
            this.montRest.Size = new System.Drawing.Size(0, 20);
            this.montRest.TabIndex = 105;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 103;
            this.label5.Text = "Montant Restant :";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(254, 10);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(50, 20);
            this.error.TabIndex = 117;
            this.error.Text = "label5";
            this.error.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(254, 38);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 28);
            this.comboBox1.TabIndex = 116;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(179, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Client";
            // 
            // nomClient
            // 
            this.nomClient.BackColor = System.Drawing.SystemColors.Control;
            this.nomClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomClient.ForeColor = System.Drawing.Color.Black;
            this.nomClient.Location = new System.Drawing.Point(185, 111);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(251, 23);
            this.nomClient.TabIndex = 113;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(185, 144);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 114;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(117, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 109;
            this.label2.Text = "Facture N° : ";
            // 
            // enrBtn
            // 
            this.enrBtn.BackColor = System.Drawing.Color.Red;
            this.enrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enrBtn.Location = new System.Drawing.Point(583, 259);
            this.enrBtn.Name = "enrBtn";
            this.enrBtn.Size = new System.Drawing.Size(225, 53);
            this.enrBtn.TabIndex = 106;
            this.enrBtn.Text = "Enregistrer";
            this.enrBtn.UseVisualStyleBackColor = false;
            this.enrBtn.Click += new System.EventHandler(this.enrBtn_Click);
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(191, 217);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(400, 1);
            this.Panel2.TabIndex = 107;
            // 
            // montantEsp
            // 
            this.montantEsp.BackColor = System.Drawing.SystemColors.Control;
            this.montantEsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.montantEsp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montantEsp.ForeColor = System.Drawing.Color.Black;
            this.montantEsp.Location = new System.Drawing.Point(191, 184);
            this.montantEsp.Name = "montantEsp";
            this.montantEsp.Size = new System.Drawing.Size(251, 23);
            this.montantEsp.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(185, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 108;
            this.label1.Text = "Montant de l\'éspèce";
            // 
            // AjoutEspece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(851, 374);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enrBtn);
            this.Controls.Add(this.montantEsp);
            this.Controls.Add(this.Panel2);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "AjoutEspece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutEspece";
            this.Load += new System.EventHandler(this.AjoutEspece_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label montRest;
        private Label label5;
        private Label error;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox nomClient;
        internal Panel panel4;
        private Label label2;
        private Button enrBtn;
        internal Panel Panel2;
        private TextBox montantEsp;
        private Label label1;
    }
}