namespace RNetApp
{
    partial class GestionEmploye
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rechercher = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.recherche = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nbrEmp = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.affich = new System.Windows.Forms.Label();
            this.avance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.nom = new System.Windows.Forms.TextBox();
            this.salaire = new System.Windows.Forms.TextBox();
            this.empBtn = new System.Windows.Forms.Button();
            this.age = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.filtreBtn = new FontAwesome.Sharp.IconButton();
            this.error = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ficheBtn = new System.Windows.Forms.Button();
            this.filtreNnPai = new FontAwesome.Sharp.IconButton();
            this.abscence = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // rechercher
            // 
            this.rechercher.BackColor = System.Drawing.Color.Red;
            this.rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rechercher.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rechercher.ForeColor = System.Drawing.Color.White;
            this.rechercher.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.rechercher.IconColor = System.Drawing.Color.White;
            this.rechercher.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.rechercher.IconSize = 27;
            this.rechercher.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rechercher.Location = new System.Drawing.Point(946, 116);
            this.rechercher.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rechercher.Name = "rechercher";
            this.rechercher.Padding = new System.Windows.Forms.Padding(5);
            this.rechercher.Size = new System.Drawing.Size(169, 44);
            this.rechercher.TabIndex = 72;
            this.rechercher.Text = "Rechercher";
            this.rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rechercher.UseVisualStyleBackColor = false;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel7.Location = new System.Drawing.Point(622, 156);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(299, 1);
            this.panel7.TabIndex = 71;
            // 
            // recherche
            // 
            this.recherche.BackColor = System.Drawing.SystemColors.Control;
            this.recherche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recherche.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recherche.Location = new System.Drawing.Point(619, 124);
            this.recherche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recherche.Name = "recherche";
            this.recherche.PlaceholderText = "Rechercher un employé";
            this.recherche.Size = new System.Drawing.Size(331, 27);
            this.recherche.TabIndex = 70;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nbrEmp);
            this.groupBox2.Location = new System.Drawing.Point(95, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(384, 52);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(17, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "nombre des employées ";
            // 
            // nbrEmp
            // 
            this.nbrEmp.AutoSize = true;
            this.nbrEmp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nbrEmp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.nbrEmp.Location = new System.Drawing.Point(280, 14);
            this.nbrEmp.Name = "nbrEmp";
            this.nbrEmp.Size = new System.Drawing.Size(65, 28);
            this.nbrEmp.TabIndex = 3;
            this.nbrEmp.Text = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.abscence);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.affich);
            this.groupBox1.Controls.Add(this.avance);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.Panel2);
            this.groupBox1.Controls.Add(this.nom);
            this.groupBox1.Controls.Add(this.salaire);
            this.groupBox1.Controls.Add(this.empBtn);
            this.groupBox1.Controls.Add(this.age);
            this.groupBox1.Controls.Add(this.prenom);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(95, 194);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(462, 658);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 484);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 21);
            this.label6.TabIndex = 80;
            this.label6.Text = "Date début de travail";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(95, 522);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(289, 30);
            this.dateTimePicker1.TabIndex = 79;
            // 
            // affich
            // 
            this.affich.AutoSize = true;
            this.affich.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.affich.ForeColor = System.Drawing.Color.Red;
            this.affich.Location = new System.Drawing.Point(103, 37);
            this.affich.Name = "affich";
            this.affich.Size = new System.Drawing.Size(200, 20);
            this.affich.TabIndex = 78;
            this.affich.Text = "Fiche de chaque Employé";
            this.affich.Visible = false;
            // 
            // avance
            // 
            this.avance.BackColor = System.Drawing.SystemColors.Control;
            this.avance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.avance.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.avance.Location = new System.Drawing.Point(107, 329);
            this.avance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.avance.Name = "avance";
            this.avance.PlaceholderText = "Avance";
            this.avance.Size = new System.Drawing.Size(177, 24);
            this.avance.TabIndex = 71;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 21);
            this.label4.TabIndex = 70;
            this.label4.Text = "DH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 21);
            this.label3.TabIndex = 69;
            this.label3.Text = "DH";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel5.Location = new System.Drawing.Point(107, 360);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 1);
            this.panel5.TabIndex = 65;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel4.Location = new System.Drawing.Point(107, 292);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 63;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel3.Location = new System.Drawing.Point(107, 227);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 62;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel1.Location = new System.Drawing.Point(107, 167);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 1);
            this.panel1.TabIndex = 61;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(107, 111);
            this.Panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(200, 1);
            this.Panel2.TabIndex = 60;
            // 
            // nom
            // 
            this.nom.BackColor = System.Drawing.SystemColors.Control;
            this.nom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nom.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nom.Location = new System.Drawing.Point(107, 80);
            this.nom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nom.Name = "nom";
            this.nom.PlaceholderText = "Nom Employé";
            this.nom.Size = new System.Drawing.Size(177, 24);
            this.nom.TabIndex = 14;
            // 
            // salaire
            // 
            this.salaire.BackColor = System.Drawing.SystemColors.Control;
            this.salaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salaire.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.salaire.Location = new System.Drawing.Point(107, 262);
            this.salaire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.salaire.Name = "salaire";
            this.salaire.PlaceholderText = "Salaire";
            this.salaire.Size = new System.Drawing.Size(177, 24);
            this.salaire.TabIndex = 2;
            // 
            // empBtn
            // 
            this.empBtn.BackColor = System.Drawing.Color.Red;
            this.empBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.empBtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.empBtn.ForeColor = System.Drawing.Color.Transparent;
            this.empBtn.Location = new System.Drawing.Point(126, 583);
            this.empBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.empBtn.Name = "empBtn";
            this.empBtn.Size = new System.Drawing.Size(219, 49);
            this.empBtn.TabIndex = 10;
            this.empBtn.Text = "Enregistrer";
            this.empBtn.UseVisualStyleBackColor = false;
            this.empBtn.Click += new System.EventHandler(this.empBtn_Click);
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.SystemColors.Control;
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.age.Location = new System.Drawing.Point(107, 194);
            this.age.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.age.Name = "age";
            this.age.PlaceholderText = "Age";
            this.age.Size = new System.Drawing.Size(177, 24);
            this.age.TabIndex = 1;
            // 
            // prenom
            // 
            this.prenom.BackColor = System.Drawing.SystemColors.Control;
            this.prenom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prenom.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.prenom.Location = new System.Drawing.Point(105, 136);
            this.prenom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.prenom.Name = "prenom";
            this.prenom.PlaceholderText = "Prénom";
            this.prenom.Size = new System.Drawing.Size(177, 24);
            this.prenom.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(587, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(975, 552);
            this.dataGridView1.TabIndex = 67;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellMouseEnter);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(95, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 27);
            this.label1.TabIndex = 66;
            this.label1.Text = "Gestion des Employées";
            // 
            // filtreBtn
            // 
            this.filtreBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.filtreBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filtreBtn.ForeColor = System.Drawing.Color.Black;
            this.filtreBtn.IconChar = FontAwesome.Sharp.IconChar.FilterCircleDollar;
            this.filtreBtn.IconColor = System.Drawing.Color.Black;
            this.filtreBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filtreBtn.IconSize = 27;
            this.filtreBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filtreBtn.Location = new System.Drawing.Point(1144, 116);
            this.filtreBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtreBtn.Name = "filtreBtn";
            this.filtreBtn.Padding = new System.Windows.Forms.Padding(5);
            this.filtreBtn.Size = new System.Drawing.Size(218, 44);
            this.filtreBtn.TabIndex = 74;
            this.filtreBtn.Text = "Filtrer par paiement";
            this.filtreBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtreBtn.UseVisualStyleBackColor = false;
            this.filtreBtn.Click += new System.EventHandler(this.filtreBtn_Click);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(777, 104);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 20);
            this.error.TabIndex = 75;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1103, 34);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(293, 28);
            this.comboBox1.TabIndex = 76;
            this.comboBox1.ValueMemberChanged += new System.EventHandler(this.comboBox1_ValueMemberChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(889, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 20);
            this.label5.TabIndex = 77;
            this.label5.Text = "Fiche de chaque Employé";
            // 
            // ficheBtn
            // 
            this.ficheBtn.BackColor = System.Drawing.Color.Yellow;
            this.ficheBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ficheBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ficheBtn.Location = new System.Drawing.Point(1442, 25);
            this.ficheBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ficheBtn.Name = "ficheBtn";
            this.ficheBtn.Size = new System.Drawing.Size(136, 46);
            this.ficheBtn.TabIndex = 78;
            this.ficheBtn.Text = "Voir Fiche";
            this.ficheBtn.UseVisualStyleBackColor = false;
            this.ficheBtn.Click += new System.EventHandler(this.ficheBtn_Click);
            // 
            // filtreNnPai
            // 
            this.filtreNnPai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.filtreNnPai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtreNnPai.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filtreNnPai.ForeColor = System.Drawing.Color.Black;
            this.filtreNnPai.IconChar = FontAwesome.Sharp.IconChar.FilterCircleDollar;
            this.filtreNnPai.IconColor = System.Drawing.Color.Black;
            this.filtreNnPai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.filtreNnPai.IconSize = 27;
            this.filtreNnPai.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.filtreNnPai.Location = new System.Drawing.Point(1392, 116);
            this.filtreNnPai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.filtreNnPai.Name = "filtreNnPai";
            this.filtreNnPai.Padding = new System.Windows.Forms.Padding(5);
            this.filtreNnPai.Size = new System.Drawing.Size(186, 62);
            this.filtreNnPai.TabIndex = 79;
            this.filtreNnPai.Text = "Filtrer par non paiement";
            this.filtreNnPai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.filtreNnPai.UseVisualStyleBackColor = false;
            this.filtreNnPai.Click += new System.EventHandler(this.filtreNnPai_Click);
            // 
            // abscence
            // 
            this.abscence.BackColor = System.Drawing.SystemColors.Control;
            this.abscence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.abscence.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.abscence.Location = new System.Drawing.Point(107, 407);
            this.abscence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.abscence.Name = "abscence";
            this.abscence.PlaceholderText = "Abscence";
            this.abscence.Size = new System.Drawing.Size(177, 24);
            this.abscence.TabIndex = 83;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.panel6.Location = new System.Drawing.Point(107, 438);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 1);
            this.panel6.TabIndex = 81;
            // 
            // GestionEmploye
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filtreNnPai);
            this.Controls.Add(this.ficheBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.error);
            this.Controls.Add(this.filtreBtn);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.recherche);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GestionEmploye";
            this.Size = new System.Drawing.Size(1592, 882);
            this.Load += new System.EventHandler(this.GestionEmploye_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton rechercher;
        internal Panel panel7;
        private TextBox recherche;
        private GroupBox groupBox2;
        private Label label2;
        private Label nbrEmp;
        private GroupBox groupBox1;
        private TextBox avance;
        private Label label4;
        private Label label3;
        internal Panel panel5;
        internal Panel panel4;
        internal Panel panel3;
        internal Panel panel1;
        internal Panel Panel2;
        private TextBox nom;
        private Button empBtn;
        private TextBox salaire;
        private TextBox age;
        private TextBox prenom;
        private DataGridView dataGridView1;
        private Label label1;
        private FontAwesome.Sharp.IconButton filtreBtn;
        private Label error;
        private ComboBox comboBox1;
        private Label label5;
        private Button ficheBtn;
        private Label affich;
        private FontAwesome.Sharp.IconButton filtreNnPai;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox abscence;
        internal Panel panel6;
    }
}
