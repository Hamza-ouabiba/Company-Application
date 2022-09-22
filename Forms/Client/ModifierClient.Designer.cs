namespace RNetApp.Forms
{
    partial class ModifierClient
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
            this.modBtn = new System.Windows.Forms.Button();
            this.Montant = new System.Windows.Forms.TextBox();
            this.nomClt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idClientT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.telClient = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // modBtn
            // 
            this.modBtn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.modBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.modBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modBtn.Location = new System.Drawing.Point(104, 474);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(225, 53);
            this.modBtn.TabIndex = 11;
            this.modBtn.Text = "Modifier";
            this.modBtn.UseVisualStyleBackColor = false;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // Montant
            // 
            this.Montant.BackColor = System.Drawing.SystemColors.Control;
            this.Montant.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Montant.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Montant.ForeColor = System.Drawing.Color.Black;
            this.Montant.Location = new System.Drawing.Point(44, 251);
            this.Montant.Multiline = true;
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(351, 39);
            this.Montant.TabIndex = 1;
            // 
            // nomClt
            // 
            this.nomClt.BackColor = System.Drawing.SystemColors.Control;
            this.nomClt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nomClt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomClt.ForeColor = System.Drawing.Color.Black;
            this.nomClt.Location = new System.Drawing.Point(44, 138);
            this.nomClt.Multiline = true;
            this.nomClt.Name = "nomClt";
            this.nomClt.Size = new System.Drawing.Size(351, 34);
            this.nomClt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(38, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nom Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(38, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Montant Du mois";
            // 
            // idClientT
            // 
            this.idClientT.Location = new System.Drawing.Point(12, 39);
            this.idClientT.Name = "idClientT";
            this.idClientT.Size = new System.Drawing.Size(125, 27);
            this.idClientT.TabIndex = 72;
            this.idClientT.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(38, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Tel Client";
            // 
            // telClient
            // 
            this.telClient.BackColor = System.Drawing.SystemColors.Control;
            this.telClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.telClient.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.telClient.ForeColor = System.Drawing.Color.Black;
            this.telClient.Location = new System.Drawing.Point(44, 357);
            this.telClient.Multiline = true;
            this.telClient.Name = "telClient";
            this.telClient.Size = new System.Drawing.Size(351, 39);
            this.telClient.TabIndex = 73;
            // 
            // ModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(447, 577);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.telClient);
            this.Controls.Add(this.idClientT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.nomClt);
            this.Controls.Add(this.Montant);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifierClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierClient";
            this.Load += new System.EventHandler(this.ModifierClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button modBtn;
        private TextBox Montant;
        private TextBox nomClt;
        private Label label1;
        private Label label6;
        private TextBox idClientT;
        private Label label2;
        private TextBox telClient;
    }
}