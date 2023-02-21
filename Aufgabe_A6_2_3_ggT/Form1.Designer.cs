namespace Aufgabe_A6_2_3_ggT
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.Num1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdCalc = new System.Windows.Forms.Button();
            this.LblResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).BeginInit();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num1.Location = new System.Drawing.Point(143, 54);
            this.Num1.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(223, 35);
            this.Num1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. Zahl:";
            // 
            // Num2
            // 
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Num2.Location = new System.Drawing.Point(143, 126);
            this.Num2.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(223, 35);
            this.Num2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. Zahl:";
            // 
            // CmdCalc
            // 
            this.CmdCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmdCalc.Location = new System.Drawing.Point(30, 208);
            this.CmdCalc.Name = "CmdCalc";
            this.CmdCalc.Size = new System.Drawing.Size(191, 58);
            this.CmdCalc.TabIndex = 2;
            this.CmdCalc.Text = "berechne ggT";
            this.CmdCalc.UseVisualStyleBackColor = true;
            this.CmdCalc.Click += new System.EventHandler(this.CmdCalc_Click);
            // 
            // LblResult
            // 
            this.LblResult.AutoSize = true;
            this.LblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblResult.Location = new System.Drawing.Point(265, 237);
            this.LblResult.Name = "LblResult";
            this.LblResult.Size = new System.Drawing.Size(31, 29);
            this.LblResult.TabIndex = 3;
            this.LblResult.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 311);
            this.Controls.Add(this.LblResult);
            this.Controls.Add(this.CmdCalc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Num1);
            this.Name = "Form1";
            this.Text = "ggT berechnen";
            ((System.ComponentModel.ISupportInitialize)(this.Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Num1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Num2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdCalc;
        private System.Windows.Forms.Label LblResult;
    }
}

