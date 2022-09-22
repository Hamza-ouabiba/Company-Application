namespace RNetApp
{
    partial class AjoutClient
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
            this.nomClt = new System.Windows.Forms.TextBox();
            this.Montant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.telClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nomClt
            // 
            this.nomClt.Location = new System.Drawing.Point(115, 136);
            this.nomClt.Multiline = true;
            this.nomClt.Name = "nomClt";
            this.nomClt.Size = new System.Drawing.Size(212, 41);
            this.nomClt.TabIndex = 0;
            // 
            // Montant
            // 
            this.Montant.Location = new System.Drawing.Point(115, 230);
            this.Montant.Multiline = true;
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(212, 41);
            this.Montant.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom Client";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Montant Realise par Mois";
            // 
            // telClient
            // 
            this.telClient.Location = new System.Drawing.Point(115, 332);
            this.telClient.Multiline = true;
            this.telClient.Name = "telClient";
            this.telClient.Size = new System.Drawing.Size(212, 41);
            this.telClient.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numéro de telephone";
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.Location = new System.Drawing.Point(85, 444);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(270, 48);
            this.enregistrer.TabIndex = 6;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // AjoutClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(437, 553);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.telClient);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.nomClt);
            this.Name = "AjoutClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjoutClient";
            this.Load += new System.EventHandler(this.AjoutClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nomClt;
        private TextBox Montant;
        private Label label1;
        private Label label2;
        private TextBox telClient;
        private Label label3;
        private Button enregistrer;
    }
}