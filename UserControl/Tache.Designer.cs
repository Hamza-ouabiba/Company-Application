namespace RNetApp
{
    partial class Tache
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.termine = new FontAwesome.Sharp.IconButton();
            this.planifie = new FontAwesome.Sharp.IconButton();
            this.important = new FontAwesome.Sharp.IconButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ajouTache = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tache_ = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // termine
            // 
            this.termine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termine.IconChar = FontAwesome.Sharp.IconChar.None;
            this.termine.IconColor = System.Drawing.Color.Black;
            this.termine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.termine.Location = new System.Drawing.Point(-24, 281);
            this.termine.Name = "termine";
            this.termine.Size = new System.Drawing.Size(433, 68);
            this.termine.TabIndex = 2;
            this.termine.Text = "Terminées";
            this.termine.UseVisualStyleBackColor = true;
            this.termine.Click += new System.EventHandler(this.termine_Click);
            // 
            // planifie
            // 
            this.planifie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.planifie.IconChar = FontAwesome.Sharp.IconChar.None;
            this.planifie.IconColor = System.Drawing.Color.Black;
            this.planifie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.planifie.Location = new System.Drawing.Point(-29, 214);
            this.planifie.Name = "planifie";
            this.planifie.Size = new System.Drawing.Size(440, 68);
            this.planifie.TabIndex = 1;
            this.planifie.Text = "Planifié";
            this.planifie.UseVisualStyleBackColor = true;
            this.planifie.Click += new System.EventHandler(this.planifie_Click);
            // 
            // important
            // 
            this.important.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.important.IconChar = FontAwesome.Sharp.IconChar.None;
            this.important.IconColor = System.Drawing.Color.Black;
            this.important.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.important.Location = new System.Drawing.Point(-22, 151);
            this.important.Name = "important";
            this.important.Size = new System.Drawing.Size(429, 68);
            this.important.TabIndex = 0;
            this.important.Text = "Important";
            this.important.UseVisualStyleBackColor = true;
            this.important.Click += new System.EventHandler(this.important_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(458, 174);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 551);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            // 
            // ajouTache
            // 
            this.ajouTache.Location = new System.Drawing.Point(1337, 17);
            this.ajouTache.Name = "ajouTache";
            this.ajouTache.Size = new System.Drawing.Size(148, 29);
            this.ajouTache.TabIndex = 3;
            this.ajouTache.Text = "Ajouter une tache";
            this.ajouTache.UseVisualStyleBackColor = true;
            this.ajouTache.Click += new System.EventHandler(this.ajouTache_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tache_);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.planifie);
            this.groupBox1.Controls.Add(this.termine);
            this.groupBox1.Controls.Add(this.important);
            this.groupBox1.Location = new System.Drawing.Point(23, 174);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 459);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // tache_
            // 
            this.tache_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tache_.IconChar = FontAwesome.Sharp.IconChar.None;
            this.tache_.IconColor = System.Drawing.Color.Black;
            this.tache_.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.tache_.Location = new System.Drawing.Point(-19, 343);
            this.tache_.Name = "tache_";
            this.tache_.Size = new System.Drawing.Size(433, 68);
            this.tache_.TabIndex = 5;
            this.tache_.Text = "Tache";
            this.tache_.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(36, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Chercher une tache";
            this.textBox1.Size = new System.Drawing.Size(308, 39);
            this.textBox1.TabIndex = 4;
            // 
            // Tache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ajouTache);
            this.Controls.Add(this.tabControl1);
            this.Name = "Tache";
            this.Size = new System.Drawing.Size(1506, 906);
            this.Load += new System.EventHandler(this.Tache_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton termine;
        private FontAwesome.Sharp.IconButton planifie;
        private FontAwesome.Sharp.IconButton important;
        private TabControl tabControl1;
        private Button ajouTache;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton tache_;
    }
}
