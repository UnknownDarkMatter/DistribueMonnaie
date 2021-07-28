
namespace DistribueMonnaie
{
    partial class Form1
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txbMontantARepartir = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRepartir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvDataGridView2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(256, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distributeur de monnaie";
            // 
            // txbMontantARepartir
            // 
            this.txbMontantARepartir.Location = new System.Drawing.Point(191, 77);
            this.txbMontantARepartir.Name = "txbMontantARepartir";
            this.txbMontantARepartir.Size = new System.Drawing.Size(222, 22);
            this.txbMontantARepartir.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Montant à répartir";
            // 
            // btnRepartir
            // 
            this.btnRepartir.Location = new System.Drawing.Point(452, 64);
            this.btnRepartir.Name = "btnRepartir";
            this.btnRepartir.Size = new System.Drawing.Size(171, 35);
            this.btnRepartir.TabIndex = 3;
            this.btnRepartir.Text = "Répartir";
            this.btnRepartir.UseVisualStyleBackColor = true;
            this.btnRepartir.Click += new System.EventHandler(this.btnRepartir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Résultat";
            // 
            // dgvDataGridView1
            // 
            this.dgvDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGridView1.Location = new System.Drawing.Point(46, 150);
            this.dgvDataGridView1.Name = "dgvDataGridView1";
            this.dgvDataGridView1.RowHeadersWidth = 51;
            this.dgvDataGridView1.RowTemplate.Height = 24;
            this.dgvDataGridView1.Size = new System.Drawing.Size(562, 275);
            this.dgvDataGridView1.TabIndex = 5;
            // 
            // dgvDataGridView2
            // 
            this.dgvDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataGridView2.Location = new System.Drawing.Point(629, 150);
            this.dgvDataGridView2.Name = "dgvDataGridView2";
            this.dgvDataGridView2.RowHeadersWidth = 51;
            this.dgvDataGridView2.RowTemplate.Height = 24;
            this.dgvDataGridView2.Size = new System.Drawing.Size(513, 275);
            this.dgvDataGridView2.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 450);
            this.Controls.Add(this.dgvDataGridView2);
            this.Controls.Add(this.dgvDataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRepartir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMontantARepartir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMontantARepartir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRepartir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDataGridView1;
        private System.Windows.Forms.DataGridView dgvDataGridView2;
    }
}

