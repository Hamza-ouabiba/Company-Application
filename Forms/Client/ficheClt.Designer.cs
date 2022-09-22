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
            this.nomCL = new System.Windows.Forms.TextBox();
            this.salaire = new System.Windows.Forms.TextBox();
            this.tel_cl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nomCL
            // 
            this.nomCL.Location = new System.Drawing.Point(54, 80);
            this.nomCL.Name = "nomCL";
            this.nomCL.Size = new System.Drawing.Size(239, 27);
            this.nomCL.TabIndex = 53;
            // 
            // salaire
            // 
            this.salaire.Location = new System.Drawing.Point(54, 173);
            this.salaire.Name = "salaire";
            this.salaire.Size = new System.Drawing.Size(239, 27);
            this.salaire.TabIndex = 54;
            // 
            // tel_cl
            // 
            this.tel_cl.Location = new System.Drawing.Point(54, 256);
            this.tel_cl.Name = "tel_cl";
            this.tel_cl.Size = new System.Drawing.Size(239, 27);
            this.tel_cl.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nom Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Montant par mois";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 58;
            this.label3.Text = "Telephone";
            // 
            // ficheClt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(344, 401);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tel_cl);
            this.Controls.Add(this.salaire);
            this.Controls.Add(this.nomCL);
            this.Name = "ficheClt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ficheClt";
            this.Load += new System.EventHandler(this.ficheClt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nomCL;
        private TextBox salaire;
        private TextBox tel_cl;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}