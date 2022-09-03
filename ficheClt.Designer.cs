namespace RNetApp
{
    partial class ficheClt
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
            this.salaire = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nomCL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // salaire
            // 
            this.salaire.AutoSize = true;
            this.salaire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.salaire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.salaire.Location = new System.Drawing.Point(199, 219);
            this.salaire.Name = "salaire";
            this.salaire.Size = new System.Drawing.Size(52, 20);
            this.salaire.TabIndex = 49;
            this.salaire.Text = "salaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(44, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 40;
            this.label3.Text = "Salaire par mois";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nomCL);
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(24, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 94);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            // 
            // nomCL
            // 
            this.nomCL.AutoSize = true;
            this.nomCL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomCL.Location = new System.Drawing.Point(106, 37);
            this.nomCL.Name = "nomCL";
            this.nomCL.Size = new System.Drawing.Size(65, 28);
            this.nomCL.TabIndex = 0;
            this.nomCL.Text = "label1";
            // 
            // ficheClt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(344, 353);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.label3);
            this.Name = "ficheClt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ficheClt";
            this.Load += new System.EventHandler(this.ficheClt_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label salaire;
        private Label label3;
        private GroupBox groupBox1;
        private Label nomCL;
    }
}