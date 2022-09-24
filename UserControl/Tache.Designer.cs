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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.catego = new FontAwesome.Sharp.IconButton();
            this.button1 = new System.Windows.Forms.Button();
            this.dayContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Mois = new System.Windows.Forms.Label();
            this.previous = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // termine
            // 
            this.termine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.termine.IconChar = FontAwesome.Sharp.IconChar.None;
            this.termine.IconColor = System.Drawing.Color.Black;
            this.termine.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.termine.Location = new System.Drawing.Point(28, 682);
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
            this.planifie.Location = new System.Drawing.Point(28, 615);
            this.planifie.Name = "planifie";
            this.planifie.Size = new System.Drawing.Size(433, 68);
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
            this.important.Location = new System.Drawing.Point(28, 551);
            this.important.Name = "important";
            this.important.Size = new System.Drawing.Size(433, 68);
            this.important.TabIndex = 0;
            this.important.Text = "Important";
            this.important.UseVisualStyleBackColor = true;
            this.important.Click += new System.EventHandler(this.important_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(515, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(986, 526);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
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
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(45, 474);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Chercher une tache";
            this.textBox1.Size = new System.Drawing.Size(308, 39);
            this.textBox1.TabIndex = 4;
            // 
            // catego
            // 
            this.catego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catego.IconChar = FontAwesome.Sharp.IconChar.None;
            this.catego.IconColor = System.Drawing.Color.Black;
            this.catego.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.catego.Location = new System.Drawing.Point(28, 749);
            this.catego.Name = "catego";
            this.catego.Size = new System.Drawing.Size(433, 68);
            this.catego.TabIndex = 5;
            this.catego.Text = "Par catégorie";
            this.catego.UseVisualStyleBackColor = true;
            this.catego.Click += new System.EventHandler(this.catego_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 475);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dayContainer
            // 
            this.dayContainer.Location = new System.Drawing.Point(45, 71);
            this.dayContainer.Name = "dayContainer";
            this.dayContainer.Size = new System.Drawing.Size(395, 350);
            this.dayContainer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "lundi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(95, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Mardi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(147, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Mercredi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(209, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jeudi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(250, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Vendredi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(308, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Samedi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(361, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dimanche";
            // 
            // Mois
            // 
            this.Mois.AutoSize = true;
            this.Mois.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Mois.Location = new System.Drawing.Point(200, 9);
            this.Mois.Name = "Mois";
            this.Mois.Size = new System.Drawing.Size(43, 17);
            this.Mois.TabIndex = 15;
            this.Mois.Text = "label8";
            // 
            // previous
            // 
            this.previous.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previous.Location = new System.Drawing.Point(104, 3);
            this.previous.Name = "previous";
            this.previous.Size = new System.Drawing.Size(34, 29);
            this.previous.TabIndex = 16;
            this.previous.Text = "<";
            this.previous.UseVisualStyleBackColor = true;
            this.previous.Click += new System.EventHandler(this.previous_Click);
            // 
            // next
            // 
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Location = new System.Drawing.Point(308, 3);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(34, 29);
            this.next.TabIndex = 17;
            this.next.Text = ">";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Tache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.next);
            this.Controls.Add(this.previous);
            this.Controls.Add(this.Mois);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayContainer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.catego);
            this.Controls.Add(this.planifie);
            this.Controls.Add(this.ajouTache);
            this.Controls.Add(this.termine);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.important);
            this.Name = "Tache";
            this.Size = new System.Drawing.Size(1504, 891);
            this.Load += new System.EventHandler(this.Tache_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton termine;
        private FontAwesome.Sharp.IconButton planifie;
        private FontAwesome.Sharp.IconButton important;
        private TextBox textBox1;
        private FontAwesome.Sharp.IconButton catego;
        public TabControl tabControl1;
        private Button button1;
        private FlowLayoutPanel dayContainer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label Mois;
        private Button previous;
        private Button next;
        private Button ajouTache;
    }
}
