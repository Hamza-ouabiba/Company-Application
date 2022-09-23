namespace RNetApp
{
    partial class AjouTache
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
            this.enregistrer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.date_depart = new System.Windows.Forms.DateTimePicker();
            this.date_fin = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // enregistrer
            // 
            this.enregistrer.BackColor = System.Drawing.Color.Cyan;
            this.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enregistrer.ForeColor = System.Drawing.Color.Black;
            this.enregistrer.Location = new System.Drawing.Point(125, 599);
            this.enregistrer.Name = "enregistrer";
            this.enregistrer.Size = new System.Drawing.Size(264, 45);
            this.enregistrer.TabIndex = 130;
            this.enregistrer.Text = "Enregistrer";
            this.enregistrer.UseVisualStyleBackColor = false;
            this.enregistrer.Click += new System.EventHandler(this.enregistrer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(65, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 129;
            this.label5.Text = "Nom Catégorie";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(65, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 122;
            this.label8.Text = "Description";
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.SystemColors.Control;
            this.description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.description.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(71, 195);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(251, 23);
            this.description.TabIndex = 120;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(214)))));
            this.Panel2.Location = new System.Drawing.Point(71, 228);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(400, 1);
            this.Panel2.TabIndex = 121;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(117)))), ((int)(((byte)(240)))));
            this.label4.Location = new System.Drawing.Point(154, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 31);
            this.label4.TabIndex = 119;
            this.label4.Text = "Ajouter une tache";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(65, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 133;
            this.label1.Text = "Data départ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(71, 294);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(398, 28);
            this.comboBox1.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(71, 452);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 137;
            this.label2.Text = "DataFin";
            // 
            // date_depart
            // 
            this.date_depart.Location = new System.Drawing.Point(81, 390);
            this.date_depart.Name = "date_depart";
            this.date_depart.Size = new System.Drawing.Size(395, 27);
            this.date_depart.TabIndex = 138;
            // 
            // date_fin
            // 
            this.date_fin.Location = new System.Drawing.Point(79, 484);
            this.date_fin.Name = "date_fin";
            this.date_fin.Size = new System.Drawing.Size(397, 27);
            this.date_fin.TabIndex = 139;
            // 
            // AjouTache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 723);
            this.Controls.Add(this.date_fin);
            this.Controls.Add(this.date_depart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.enregistrer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.description);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.label4);
            this.Name = "AjouTache";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AjouTache";
            this.Load += new System.EventHandler(this.AjouTache_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button enregistrer;
        private Label label5;
        private Label label8;
        private TextBox description;
        internal Panel Panel2;
        private Label label4;
        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private DateTimePicker date_depart;
        private DateTimePicker date_fin;
    }
}