namespace RNetApp
{
    partial class ModifierEspece
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
            this.montantEsp = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nomT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.factuNu = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.Lime;
            this.Modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Modifier.ForeColor = System.Drawing.Color.Black;
            this.Modifier.Location = new System.Drawing.Point(51, 393);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(264, 45);
            this.Modifier.TabIndex = 140;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(43, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 139;
            this.label5.Text = "Montant de l\'epsèce";
            // 
            // montantEsp
            // 
            this.montantEsp.BackColor = System.Drawing.SystemColors.Control;
            this.montantEsp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.montantEsp.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.montantEsp.ForeColor = System.Drawing.Color.Black;
            this.montantEsp.Location = new System.Drawing.Point(45, 272);
            this.montantEsp.Name = "montantEsp";
            this.montantEsp.Size = new System.Drawing.Size(251, 23);
            this.montantEsp.TabIndex = 137;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(45, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 1);
            this.panel3.TabIndex = 138;
            // 
            // nomT
            // 
            this.nomT.AutoSize = true;
            this.nomT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomT.ForeColor = System.Drawing.Color.Black;
            this.nomT.Location = new System.Drawing.Point(233, 119);
            this.nomT.Name = "nomT";
            this.nomT.Size = new System.Drawing.Size(0, 25);
            this.nomT.TabIndex = 136;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(51, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 22);
            this.label6.TabIndex = 135;
            this.label6.Text = "Client :";
            // 
            // factuNu
            // 
            this.factuNu.AutoSize = true;
            this.factuNu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.factuNu.ForeColor = System.Drawing.Color.Black;
            this.factuNu.Location = new System.Drawing.Point(233, 155);
            this.factuNu.Name = "factuNu";
            this.factuNu.Size = new System.Drawing.Size(0, 25);
            this.factuNu.TabIndex = 134;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(51, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 133;
            this.label7.Text = "Facture N° : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 141;
            this.label1.Text = "Modification Espèce";
            // 
            // ModifierEspece
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.montantEsp);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.nomT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.factuNu);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ModifierEspece";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierEspece";
            this.Load += new System.EventHandler(this.ModifierEspece_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Modifier;
        private Label label5;
        private TextBox montantEsp;
        internal Panel panel3;
        private Label nomT;
        private Label label6;
        private Label factuNu;
        private Label label7;
        private Label label1;
    }
}