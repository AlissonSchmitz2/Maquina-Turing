using System.Windows.Forms;

namespace Maquina_Turing.View
{
    partial class CaptureRulesTableAction
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxStates = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxDirection = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxValue = new System.Windows.Forms.ComboBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estado:";
            // 
            // cbxStates
            // 
            this.cbxStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxStates.FormattingEnabled = true;
            this.cbxStates.Location = new System.Drawing.Point(25, 111);
            this.cbxStates.Name = "cbxStates";
            this.cbxStates.Size = new System.Drawing.Size(115, 24);
            this.cbxStates.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Direção:";
            // 
            // cbxDirection
            // 
            this.cbxDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDirection.FormattingEnabled = true;
            this.cbxDirection.Items.AddRange(new object[] {
            "Direita",
            "Esquerda",
            "Para"});
            this.cbxDirection.Location = new System.Drawing.Point(307, 111);
            this.cbxDirection.Name = "cbxDirection";
            this.cbxDirection.Size = new System.Drawing.Size(119, 24);
            this.cbxDirection.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(160, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor:";
            // 
            // cbxValue
            // 
            this.cbxValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxValue.FormattingEnabled = true;
            this.cbxValue.Location = new System.Drawing.Point(163, 111);
            this.cbxValue.Name = "cbxValue";
            this.cbxValue.Size = new System.Drawing.Size(119, 24);
            this.cbxValue.TabIndex = 6;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(25, 202);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(115, 29);
            this.btnConfirmar.TabIndex = 7;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 29);
            this.button1.TabIndex = 8;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(468, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Caso não houver nenhuma ação para esta regra, apenas feche a janela.";
            // 
            // CaptureRulesTableAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.cbxValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxDirection);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxStates);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CaptureRulesTableAction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Regras Tabela de Ação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxStates;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxDirection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxValue;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}