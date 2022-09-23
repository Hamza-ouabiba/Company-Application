namespace RNetApp
{
    partial class ChequeFacture
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
            this.label1 = new System.Windows.Forms.Label();
            this.enrBtn = new System.Windows.Forms.Button();
            this.numCheq = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.montantChe = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomClient = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.error = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.montRest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(222, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Numéro de chèque";
            // 
            // enrBtn
            // 
            this.enrBtn.BackColor = System.Drawing.Color.Red;
            this.enrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enrBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enrBtn.Location = new System.Drawing.Point(630, 369);
            this.enrBtn.Name = "enrBtn";
            this.enrBtn.Size = new System.Drawing.Size(225, 53);
            this.enrBtn.TabIndex = 77;
            this.enrBtn.Text = "Enregistrer";
            this.enrBtn.UseVisualStyleBackColor = false;
            this.enrBtn.Click += new System.EventHandler(this.enrBtn_Click);
            // 
            // numCheq
            // 
            this.numCheq.BackColor = System.Drawing.SystemColors.Control;
            this.numCheq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCheq.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numCheq.ForeColor = System.Drawing.Color.White;
            this.numCheq.Location = new System.Drawing.Point(228, 195);
            this.numCheq.Name = "numCheq";
            this.numCheq.Size = new System.Drawing.Size(251, 23);
            this.numCheq.TabIndex = 74;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(228, 228);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(400, 1);
            this.Panel2.TabIndex = 78;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(222, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Montant du cheque";
            // 
            // montantChe
            // 
            this.montantChe.BackColor = System.Drawing.SystemColors.Control;
            this.montantChe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.montantChe.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montantChe.ForeColor = System.Drawing.Color.White;
            this.montantChe.Location = new System.Drawing.Point(228, 276);
            this.montantChe.Name = "montantChe";
            this.montantChe.Size = new System.Drawing.Size(251, 23);
            this.montantChe.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(228, 309);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(154, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 90;
            this.label2.Text = "Facture N° : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(216, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 100;
            this.label4.Text = "Client";
            // 
            // nomClient
            // 
            this.nomClient.BackColor = System.Drawing.SystemColors.Control;
            this.nomClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomClient.ForeColor = System.Drawing.Color.White;
            this.nomClient.Location = new System.Drawing.Point(222, 122);
            this.nomClient.Name = "nomClient";
            this.nomClient.Size = new System.Drawing.Size(251, 23);
            this.nomClient.TabIndex = 98;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(222, 155);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 99;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(291, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 28);
            this.comboBox1.TabIndex = 101;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.CausesValidationChanged += new System.EventHandler(this.comboBox1_CausesValidationChanged);
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            this.comboBox1.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox1_Validating);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(291, 21);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(50, 20);
            this.error.TabIndex = 102;
            this.error.Text = "label5";
            this.error.Visible = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.montRest);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(99, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 52);
            this.groupBox1.TabIndex = 104;
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
            // ChequeFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 463);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nomClient);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montantChe);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enrBtn);
            this.Controls.Add(this.numCheq);
            this.Controls.Add(this.Panel2);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChequeFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChequeFacture";
            this.Load += new System.EventHandler(this.ChequeFacture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button enrBtn;
        private TextBox numCheq;
        internal Panel Panel2;
        private Label label3;
        private TextBox montantChe;
        internal Panel panel3;
        private Label label2;
        private Label label4;
        private TextBox nomClient;
        internal Panel panel4;
        private ComboBox comboBox1;
        private Label error;
        private Label label5;
        private GroupBox groupBox1;
        private Label montRest;
    }
}