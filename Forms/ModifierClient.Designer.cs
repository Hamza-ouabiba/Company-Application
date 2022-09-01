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
            this.panel1 = new System.Windows.Forms.Panel();
            this.exitBtn = new FontAwesome.Sharp.IconButton();
            this.modBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Montant = new System.Windows.Forms.TextBox();
            this.nomClt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idClientT = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.exitBtn);
            this.panel1.Location = new System.Drawing.Point(-8, -24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(860, 70);
            this.panel1.TabIndex = 0;
            // 
            // exitBtn
            // 
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.exitBtn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.exitBtn.IconColor = System.Drawing.Color.Red;
            this.exitBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exitBtn.IconSize = 35;
            this.exitBtn.Location = new System.Drawing.Point(799, 31);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(42, 33);
            this.exitBtn.TabIndex = 41;
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // modBtn
            // 
            this.modBtn.BackColor = System.Drawing.Color.Red;
            this.modBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.modBtn.Location = new System.Drawing.Point(271, 400);
            this.modBtn.Name = "modBtn";
            this.modBtn.Size = new System.Drawing.Size(225, 53);
            this.modBtn.TabIndex = 11;
            this.modBtn.Text = "Modifier";
            this.modBtn.UseVisualStyleBackColor = false;
            this.modBtn.Click += new System.EventHandler(this.modBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(575, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "MAD";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(180, 298);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 1);
            this.panel4.TabIndex = 60;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(180, 210);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(400, 1);
            this.Panel2.TabIndex = 59;
            // 
            // Montant
            // 
            this.Montant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.Montant.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Montant.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Montant.ForeColor = System.Drawing.Color.White;
            this.Montant.Location = new System.Drawing.Point(180, 260);
            this.Montant.Name = "Montant";
            this.Montant.Size = new System.Drawing.Size(176, 23);
            this.Montant.TabIndex = 1;
            // 
            // nomClt
            // 
            this.nomClt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.nomClt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomClt.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nomClt.ForeColor = System.Drawing.Color.White;
            this.nomClt.Location = new System.Drawing.Point(180, 177);
            this.nomClt.Name = "nomClt";
            this.nomClt.Size = new System.Drawing.Size(251, 23);
            this.nomClt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(174, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nom Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(175, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 70;
            this.label6.Text = "Montant Du mois";
            // 
            // idClientT
            // 
            this.idClientT.Location = new System.Drawing.Point(30, 70);
            this.idClientT.Name = "idClientT";
            this.idClientT.Size = new System.Drawing.Size(125, 27);
            this.idClientT.TabIndex = 72;
            this.idClientT.Visible = false;
            // 
            // ModifierClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(785, 512);
            this.Controls.Add(this.idClientT);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nomClt);
            this.Controls.Add(this.Montant);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.Panel2);
            this.MaximizeBox = false;
            this.Name = "ModifierClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModifierClient";
            this.Load += new System.EventHandler(this.ModifierClient_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button modBtn;
        private Label label4;
        internal Panel panel4;
        internal Panel Panel2;
        private TextBox Montant;
        private TextBox nomClt;
        private FontAwesome.Sharp.IconButton exitBtn;
        private Label label1;
        private Label label6;
        private TextBox idClientT;
    }
}