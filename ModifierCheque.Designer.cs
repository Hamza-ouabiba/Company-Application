namespace RNetApp
{
    partial class ModifierCheque
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
            this.Modifier = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.montantChe = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nomT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.factuNu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numCheq = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.Lime;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.ForeColor = System.Drawing.Color.Black;
            this.Modifier.Location = new System.Drawing.Point(53, 439);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(264, 45);
            this.Modifier.TabIndex = 129;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(41, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 128;
            this.label5.Text = "Montant du cheque";
            // 
            // montantChe
            // 
            this.montantChe.BackColor = System.Drawing.SystemColors.Control;
            this.montantChe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.montantChe.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montantChe.ForeColor = System.Drawing.Color.Black;
            this.montantChe.Location = new System.Drawing.Point(43, 322);
            this.montantChe.Name = "montantChe";
            this.montantChe.Size = new System.Drawing.Size(251, 23);
            this.montantChe.TabIndex = 126;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(43, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 127;
            // 
            // nomT
            // 
            this.nomT.AutoSize = true;
            this.nomT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomT.ForeColor = System.Drawing.Color.Black;
            this.nomT.Location = new System.Drawing.Point(232, 94);
            this.nomT.Name = "nomT";
            this.nomT.Size = new System.Drawing.Size(0, 25);
            this.nomT.TabIndex = 125;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(50, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 124;
            this.label6.Text = "Client :";
            // 
            // factuNu
            // 
            this.factuNu.AutoSize = true;
            this.factuNu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.factuNu.ForeColor = System.Drawing.Color.Black;
            this.factuNu.Location = new System.Drawing.Point(232, 130);
            this.factuNu.Name = "factuNu";
            this.factuNu.Size = new System.Drawing.Size(0, 25);
            this.factuNu.TabIndex = 123;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(50, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 122;
            this.label7.Text = "Facture N° : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(43, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 121;
            this.label8.Text = "Numéro de chèque";
            // 
            // numCheq
            // 
            this.numCheq.BackColor = System.Drawing.SystemColors.Control;
            this.numCheq.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numCheq.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numCheq.ForeColor = System.Drawing.Color.Black;
            this.numCheq.Location = new System.Drawing.Point(43, 241);
            this.numCheq.Name = "numCheq";
            this.numCheq.Size = new System.Drawing.Size(251, 23);
            this.numCheq.TabIndex = 119;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(43, 270);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(300, 1);
            this.Panel2.TabIndex = 120;
            // 
            // ModifierCheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 529);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.montantChe);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nomT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.factuNu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numCheq);
            this.Controls.Add(this.Panel2);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "ModifierCheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierCheque";
            this.Load += new System.EventHandler(this.ModifierCheque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Modifier;
        private Label label5;
        private TextBox montantChe;
        internal Panel panel3;
        private Label nomT;
        private Label label6;
        private Label factuNu;
        private Label label7;
        private Label label8;
        private TextBox numCheq;
        internal Panel Panel2;
    }
}