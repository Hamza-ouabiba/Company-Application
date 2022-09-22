namespace RNetApp
{
    partial class ChoxiCategorie
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
            this.choix_catego = new System.Windows.Forms.ComboBox();
            this.Enre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choix_catego
            // 
            this.choix_catego.FormattingEnabled = true;
            this.choix_catego.Location = new System.Drawing.Point(84, 22);
            this.choix_catego.Name = "choix_catego";
            this.choix_catego.Size = new System.Drawing.Size(241, 28);
            this.choix_catego.TabIndex = 0;
            // 
            // Enre
            // 
            this.Enre.Location = new System.Drawing.Point(152, 73);
            this.Enre.Name = "Enre";
            this.Enre.Size = new System.Drawing.Size(113, 29);
            this.Enre.TabIndex = 1;
            this.Enre.Text = "Enregistrer";
            this.Enre.UseVisualStyleBackColor = true;
            this.Enre.Click += new System.EventHandler(this.Enre_Click);
            // 
            // ChoxiCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 114);
            this.Controls.Add(this.Enre);
            this.Controls.Add(this.choix_catego);
            this.Name = "ChoxiCategorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChoxiCategorie";
            this.Load += new System.EventHandler(this.ChoxiCategorie_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox choix_catego;
        private Button Enre;
    }
}