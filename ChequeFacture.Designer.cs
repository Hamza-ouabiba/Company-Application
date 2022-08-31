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
            this.panel1 = new System.Windows.Forms.Panel();
            this.numCheq = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.factuNu = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nomT = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.montantChe = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(208, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Numéro de chèque";
            // 
            // enrBtn
            // 
            this.enrBtn.BackColor = System.Drawing.Color.Red;
            this.enrBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enrBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.enrBtn.Location = new System.Drawing.Point(291, 425);
            this.enrBtn.Name = "enrBtn";
            this.enrBtn.Size = new System.Drawing.Size(225, 53);
            this.enrBtn.TabIndex = 77;
            this.enrBtn.Text = "Enregistrer";
            this.enrBtn.UseVisualStyleBackColor = false;
            this.enrBtn.Click += new System.EventHandler(this.enrBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.panel1.Location = new System.Drawing.Point(-30, -45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 84);
            this.panel1.TabIndex = 73;
            // 
            // numCheq
            // 
            this.numCheq.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.numCheq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCheq.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numCheq.ForeColor = System.Drawing.Color.White;
            this.numCheq.Location = new System.Drawing.Point(214, 229);
            this.numCheq.Name = "numCheq";
            this.numCheq.Size = new System.Drawing.Size(251, 23);
            this.numCheq.TabIndex = 74;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(214, 262);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(400, 1);
            this.Panel2.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(278, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 23);
            this.label2.TabIndex = 90;
            this.label2.Text = "Facture N° : ";
            // 
            // factuNu
            // 
            this.factuNu.AutoSize = true;
            this.factuNu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.factuNu.ForeColor = System.Drawing.Color.Silver;
            this.factuNu.Location = new System.Drawing.Point(460, 107);
            this.factuNu.Name = "factuNu";
            this.factuNu.Size = new System.Drawing.Size(59, 25);
            this.factuNu.TabIndex = 91;
            this.factuNu.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(278, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 22);
            this.label4.TabIndex = 92;
            this.label4.Text = "Client :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // nomT
            // 
            this.nomT.AutoSize = true;
            this.nomT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomT.ForeColor = System.Drawing.Color.Silver;
            this.nomT.Location = new System.Drawing.Point(460, 71);
            this.nomT.Name = "nomT";
            this.nomT.Size = new System.Drawing.Size(59, 25);
            this.nomT.TabIndex = 93;
            this.nomT.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(208, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "Montant du cheque";
            // 
            // montantChe
            // 
            this.montantChe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.montantChe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.montantChe.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montantChe.ForeColor = System.Drawing.Color.White;
            this.montantChe.Location = new System.Drawing.Point(214, 310);
            this.montantChe.Name = "montantChe";
            this.montantChe.Size = new System.Drawing.Size(251, 23);
            this.montantChe.TabIndex = 94;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(214, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 95;
            // 
            // ChequeFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(827, 536);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.montantChe);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nomT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.factuNu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enrBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.numCheq);
            this.Controls.Add(this.Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChequeFacture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChequeFacture";
            this.Load += new System.EventHandler(this.ChequeFacture_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button enrBtn;
        private Panel panel1;
        private TextBox numCheq;
        internal Panel Panel2;
        private Label label2;
        private Label factuNu;
        private Label label4;
        private Label nomT;
        private Label label3;
        private TextBox montantChe;
        internal Panel panel3;
    }
}