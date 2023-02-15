namespace Aufgabe_A6_2_2
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
            this.NumNumber = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.CmdCalculate = new System.Windows.Forms.Button();
            this.TxtOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // NumNumber
            // 
            this.NumNumber.Location = new System.Drawing.Point(261, 56);
            this.NumNumber.Maximum = new decimal(new int[] {
            3000000,
            0,
            0,
            0});
            this.NumNumber.Name = "NumNumber";
            this.NumNumber.Size = new System.Drawing.Size(203, 26);
            this.NumNumber.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ganze Zahl eingeben:";
            // 
            // CmdCalculate
            // 
            this.CmdCalculate.Location = new System.Drawing.Point(65, 118);
            this.CmdCalculate.Name = "CmdCalculate";
            this.CmdCalculate.Size = new System.Drawing.Size(197, 40);
            this.CmdCalculate.TabIndex = 2;
            this.CmdCalculate.Text = "Binärwert berechnen";
            this.CmdCalculate.UseVisualStyleBackColor = true;
            this.CmdCalculate.Click += new System.EventHandler(this.CmdCalculate_Click);
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(65, 193);
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(399, 26);
            this.TxtOut.TabIndex = 3;
            this.TxtOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 283);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.CmdCalculate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Aufgabe_A6_2_2";
            ((System.ComponentModel.ISupportInitialize)(this.NumNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CmdCalculate;
        private System.Windows.Forms.TextBox TxtOut;
    }
}

