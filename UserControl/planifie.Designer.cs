namespace RNetApp
{
    partial class planifie
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
            this.dgvplanifie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanifie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvplanifie
            // 
            this.dgvplanifie.AllowUserToAddRows = false;
            this.dgvplanifie.AllowUserToDeleteRows = false;
            this.dgvplanifie.AllowUserToResizeColumns = false;
            this.dgvplanifie.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvplanifie.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvplanifie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplanifie.Location = new System.Drawing.Point(103, 76);
            this.dgvplanifie.Name = "dgvplanifie";
            this.dgvplanifie.RowHeadersWidth = 51;
            this.dgvplanifie.RowTemplate.Height = 29;
            this.dgvplanifie.Size = new System.Drawing.Size(1113, 477);
            this.dgvplanifie.TabIndex = 0;
            this.dgvplanifie.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvplanifie_CellMouseEnter);
            // 
            // planifie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvplanifie);
            this.Name = "planifie";
            this.Size = new System.Drawing.Size(1327, 650);
            this.Load += new System.EventHandler(this.planifie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplanifie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvplanifie;
    }
}
