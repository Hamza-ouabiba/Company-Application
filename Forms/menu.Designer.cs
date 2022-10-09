namespace RNetApp.Forms
{
    partial class menu
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.GestionEspece = new FontAwesome.Sharp.IconButton();
            this.tacheBtn = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.utilisateurEn = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prixModBtn = new FontAwesome.Sharp.IconButton();
            this.GestionChequeBtn = new FontAwesome.Sharp.IconButton();
            this.GestionEmp = new FontAwesome.Sharp.IconButton();
            this.FactureBtn = new FontAwesome.Sharp.IconButton();
            this.ClientBtn = new FontAwesome.Sharp.IconButton();
            this.date = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.DeconBtn = new FontAwesome.Sharp.IconButton();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.panelLeft.Controls.Add(this.GestionEspece);
            this.panelLeft.Controls.Add(this.tacheBtn);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.utilisateurEn);
            this.panelLeft.Controls.Add(this.iconPictureBox1);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.prixModBtn);
            this.panelLeft.Controls.Add(this.GestionChequeBtn);
            this.panelLeft.Controls.Add(this.GestionEmp);
            this.panelLeft.Controls.Add(this.FactureBtn);
            this.panelLeft.Controls.Add(this.ClientBtn);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelLeft.ForeColor = System.Drawing.Color.Gray;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(193, 690);
            this.panelLeft.TabIndex = 1;
            // 
            // GestionEspece
            // 
            this.GestionEspece.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GestionEspece.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GestionEspece.ForeColor = System.Drawing.Color.Silver;
            this.GestionEspece.IconChar = FontAwesome.Sharp.IconChar.DollarSign;
            this.GestionEspece.IconColor = System.Drawing.Color.Silver;
            this.GestionEspece.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GestionEspece.IconSize = 30;
            this.GestionEspece.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GestionEspece.Location = new System.Drawing.Point(-7, 429);
            this.GestionEspece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GestionEspece.Name = "GestionEspece";
            this.GestionEspece.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.GestionEspece.Size = new System.Drawing.Size(206, 71);
            this.GestionEspece.TabIndex = 8;
            this.GestionEspece.Text = "Gestion des éspèces";
            this.GestionEspece.UseVisualStyleBackColor = true;
            this.GestionEspece.Click += new System.EventHandler(this.GestionEspece_Click);
            // 
            // tacheBtn
            // 
            this.tacheBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tacheBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tacheBtn.ForeColor = System.Drawing.Color.Silver;
            this.tacheBtn.IconChar = FontAwesome.Sharp.IconChar.TasksAlt;
            this.tacheBtn.IconColor = System.Drawing.Color.Silver;
            this.tacheBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tacheBtn.IconSize = 30;
            this.tacheBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tacheBtn.Location = new System.Drawing.Point(-6, 500);
            this.tacheBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tacheBtn.Name = "tacheBtn";
            this.tacheBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.tacheBtn.Size = new System.Drawing.Size(200, 71);
            this.tacheBtn.TabIndex = 12;
            this.tacheBtn.Text = "Gestion des Taches";
            this.tacheBtn.UseVisualStyleBackColor = true;
            this.tacheBtn.Click += new System.EventHandler(this.tacheBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 11;
            this.label1.UseWaitCursor = true;
            // 
            // utilisateurEn
            // 
            this.utilisateurEn.AutoSize = true;
            this.utilisateurEn.Location = new System.Drawing.Point(64, 687);
            this.utilisateurEn.Name = "utilisateurEn";
            this.utilisateurEn.Size = new System.Drawing.Size(0, 19);
            this.utilisateurEn.TabIndex = 10;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(29)))), ((int)(((byte)(30)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Lime;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Lime;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 19;
            this.iconPictureBox1.Location = new System.Drawing.Point(33, 687);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 19);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(24, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "R-NET PLUS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prixModBtn
            // 
            this.prixModBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prixModBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prixModBtn.ForeColor = System.Drawing.Color.Silver;
            this.prixModBtn.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.prixModBtn.IconColor = System.Drawing.Color.Silver;
            this.prixModBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.prixModBtn.IconSize = 30;
            this.prixModBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prixModBtn.Location = new System.Drawing.Point(-6, 570);
            this.prixModBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prixModBtn.Name = "prixModBtn";
            this.prixModBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.prixModBtn.Size = new System.Drawing.Size(200, 71);
            this.prixModBtn.TabIndex = 7;
            this.prixModBtn.Text = "Modification Prix";
            this.prixModBtn.UseVisualStyleBackColor = true;
            this.prixModBtn.Click += new System.EventHandler(this.prixModBtn_Click);
            // 
            // GestionChequeBtn
            // 
            this.GestionChequeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GestionChequeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GestionChequeBtn.ForeColor = System.Drawing.Color.Silver;
            this.GestionChequeBtn.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.GestionChequeBtn.IconColor = System.Drawing.Color.Silver;
            this.GestionChequeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GestionChequeBtn.IconSize = 30;
            this.GestionChequeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GestionChequeBtn.Location = new System.Drawing.Point(-7, 358);
            this.GestionChequeBtn.Margin = new System.Windows.Forms.Padding(5, 2, 3, 2);
            this.GestionChequeBtn.Name = "GestionChequeBtn";
            this.GestionChequeBtn.Padding = new System.Windows.Forms.Padding(4);
            this.GestionChequeBtn.Size = new System.Drawing.Size(232, 71);
            this.GestionChequeBtn.TabIndex = 6;
            this.GestionChequeBtn.Text = "Gestion Des Chèques";
            this.GestionChequeBtn.UseVisualStyleBackColor = true;
            this.GestionChequeBtn.Click += new System.EventHandler(this.GestionChequeBtn_Click);
            // 
            // GestionEmp
            // 
            this.GestionEmp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GestionEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GestionEmp.ForeColor = System.Drawing.Color.Silver;
            this.GestionEmp.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.GestionEmp.IconColor = System.Drawing.Color.Silver;
            this.GestionEmp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.GestionEmp.IconSize = 30;
            this.GestionEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GestionEmp.Location = new System.Drawing.Point(-6, 288);
            this.GestionEmp.Margin = new System.Windows.Forms.Padding(5, 2, 3, 2);
            this.GestionEmp.Name = "GestionEmp";
            this.GestionEmp.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.GestionEmp.Size = new System.Drawing.Size(206, 71);
            this.GestionEmp.TabIndex = 5;
            this.GestionEmp.Text = "      Gestion des Employées";
            this.GestionEmp.UseVisualStyleBackColor = true;
            this.GestionEmp.Click += new System.EventHandler(this.GestionEmp_Click);
            // 
            // FactureBtn
            // 
            this.FactureBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FactureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FactureBtn.ForeColor = System.Drawing.Color.Silver;
            this.FactureBtn.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.FactureBtn.IconColor = System.Drawing.Color.Silver;
            this.FactureBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.FactureBtn.IconSize = 30;
            this.FactureBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FactureBtn.Location = new System.Drawing.Point(-7, 218);
            this.FactureBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FactureBtn.Name = "FactureBtn";
            this.FactureBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.FactureBtn.Size = new System.Drawing.Size(200, 71);
            this.FactureBtn.TabIndex = 4;
            this.FactureBtn.Text = "Gestion de Facture";
            this.FactureBtn.UseVisualStyleBackColor = true;
            this.FactureBtn.Click += new System.EventHandler(this.FactureBtn_Click);
            // 
            // ClientBtn
            // 
            this.ClientBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClientBtn.ForeColor = System.Drawing.Color.Silver;
            this.ClientBtn.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.ClientBtn.IconColor = System.Drawing.Color.Silver;
            this.ClientBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ClientBtn.IconSize = 30;
            this.ClientBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ClientBtn.Location = new System.Drawing.Point(-6, 147);
            this.ClientBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClientBtn.Name = "ClientBtn";
            this.ClientBtn.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.ClientBtn.Size = new System.Drawing.Size(200, 71);
            this.ClientBtn.TabIndex = 3;
            this.ClientBtn.Text = "Gestion Des Clients";
            this.ClientBtn.UseVisualStyleBackColor = true;
            this.ClientBtn.Click += new System.EventHandler(this.ClientBtn_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.date.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.date.ForeColor = System.Drawing.Color.Silver;
            this.date.Location = new System.Drawing.Point(16, 8);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(52, 21);
            this.date.TabIndex = 13;
            this.date.Text = "label3";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.panelTop.Controls.Add(this.date);
            this.panelTop.Controls.Add(this.DeconBtn);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(193, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(955, 40);
            this.panelTop.TabIndex = 2;
            // 
            // DeconBtn
            // 
            this.DeconBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeconBtn.BackColor = System.Drawing.Color.Red;
            this.DeconBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeconBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeconBtn.ForeColor = System.Drawing.Color.Silver;
            this.DeconBtn.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.DeconBtn.IconColor = System.Drawing.SystemColors.Control;
            this.DeconBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.DeconBtn.IconSize = 20;
            this.DeconBtn.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.DeconBtn.Location = new System.Drawing.Point(749, 2);
            this.DeconBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeconBtn.Name = "DeconBtn";
            this.DeconBtn.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.DeconBtn.Size = new System.Drawing.Size(130, 36);
            this.DeconBtn.TabIndex = 4;
            this.DeconBtn.Text = "Deconnexion";
            this.DeconBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeconBtn.UseVisualStyleBackColor = false;
            this.DeconBtn.Click += new System.EventHandler(this.DeconBtn_Click);
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.ForeColor = System.Drawing.Color.Black;
            this.panelContent.Location = new System.Drawing.Point(193, 40);
            this.panelContent.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panelContent.Size = new System.Drawing.Size(955, 650);
            this.panelContent.TabIndex = 3;
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 690);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "menu";
            this.Text = "menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelLeft;
        private Label utilisateurEn;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label2;
        private FontAwesome.Sharp.IconButton prixModBtn;
        private FontAwesome.Sharp.IconButton GestionChequeBtn;
        private FontAwesome.Sharp.IconButton GestionEmp;
        private FontAwesome.Sharp.IconButton FactureBtn;
        private FontAwesome.Sharp.IconButton ClientBtn;
        private Panel panelTop;
        private FontAwesome.Sharp.IconButton DeconBtn;
        private Label label1;
        private Panel panelContent;
        private FontAwesome.Sharp.IconButton tacheBtn;
        private Label date;
        private FontAwesome.Sharp.IconButton GestionEspece;
    }
}