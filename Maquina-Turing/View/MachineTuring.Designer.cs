namespace Maquina_Turing
{
    partial class MachineTuring
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStates = new System.Windows.Forms.TextBox();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.dataGridStates = new System.Windows.Forms.DataGridView();
            this.dataGridValues = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quantidade de Estados:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantidade de Valores:";
            // 
            // txtStates
            // 
            this.txtStates.Location = new System.Drawing.Point(182, 20);
            this.txtStates.Name = "txtStates";
            this.txtStates.Size = new System.Drawing.Size(110, 22);
            this.txtStates.TabIndex = 2;
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(472, 21);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(95, 22);
            this.txtValues.TabIndex = 3;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(586, 16);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 31);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirmar";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridStates
            // 
            this.dataGridStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridStates.Location = new System.Drawing.Point(26, 62);
            this.dataGridStates.Name = "dataGridStates";
            this.dataGridStates.RowHeadersWidth = 51;
            this.dataGridStates.RowTemplate.Height = 24;
            this.dataGridStates.Size = new System.Drawing.Size(180, 297);
            this.dataGridStates.TabIndex = 5;
            // 
            // dataGridValues
            // 
            this.dataGridValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridValues.Location = new System.Drawing.Point(229, 63);
            this.dataGridValues.Name = "dataGridValues";
            this.dataGridValues.RowHeadersWidth = 51;
            this.dataGridValues.RowTemplate.Height = 24;
            this.dataGridValues.Size = new System.Drawing.Size(652, 295);
            this.dataGridValues.TabIndex = 6;
            // 
            // MachineTuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 541);
            this.Controls.Add(this.dataGridValues);
            this.Controls.Add(this.dataGridStates);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtValues);
            this.Controls.Add(this.txtStates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MachineTuring";
            this.Text = "Máquina de Turing";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridStates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStates;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.DataGridView dataGridStates;
        private System.Windows.Forms.DataGridView dataGridValues;
    }
}

