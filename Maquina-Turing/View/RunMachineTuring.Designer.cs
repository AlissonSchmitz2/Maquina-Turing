namespace Maquina_Turing.View
{
    partial class RunMachineTuring
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
            this.components = new System.ComponentModel.Container();
            this.timerRun = new System.Windows.Forms.Timer(this.components);
            this.lblEntry = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblHead = new System.Windows.Forms.Label();
            this.lblIncrement = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerRun
            // 
            this.timerRun.Interval = 1000;
            this.timerRun.Tick += new System.EventHandler(this.TimerRun);
            // 
            // lblEntry
            // 
            this.lblEntry.AutoSize = true;
            this.lblEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntry.Location = new System.Drawing.Point(21, 63);
            this.lblEntry.Name = "lblEntry";
            this.lblEntry.Size = new System.Drawing.Size(60, 25);
            this.lblEntry.TabIndex = 0;
            this.lblEntry.Text = "aaaa";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.Location = new System.Drawing.Point(21, 9);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(24, 25);
            this.lblState.TabIndex = 1;
            this.lblState.Text = "0";
            // 
            // lblHead
            // 
            this.lblHead.AutoSize = true;
            this.lblHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHead.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblHead.Location = new System.Drawing.Point(22, 34);
            this.lblHead.Name = "lblHead";
            this.lblHead.Size = new System.Drawing.Size(18, 25);
            this.lblHead.TabIndex = 2;
            this.lblHead.Text = "|";
            // 
            // lblIncrement
            // 
            this.lblIncrement.AutoSize = true;
            this.lblIncrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncrement.Location = new System.Drawing.Point(23, 108);
            this.lblIncrement.Name = "lblIncrement";
            this.lblIncrement.Size = new System.Drawing.Size(80, 20);
            this.lblIncrement.TabIndex = 4;
            this.lblIncrement.Text = "Estados: ";
            // 
            // RunMachineTuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 176);
            this.Controls.Add(this.lblIncrement);
            this.Controls.Add(this.lblHead);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblEntry);
            this.Name = "RunMachineTuring";
            this.Text = "Execução";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

        }

        #endregion
        private System.Windows.Forms.Timer timerRun;
        private System.Windows.Forms.Label lblEntry;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblHead;
        private System.Windows.Forms.Label lblIncrement;
    }
}