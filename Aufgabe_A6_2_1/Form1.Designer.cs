namespace Aufgabe_A6_2_1
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
            this.TxtOut = new System.Windows.Forms.TextBox();
            this.CmdGenerate = new System.Windows.Forms.Button();
            this.CmdStart = new System.Windows.Forms.Button();
            this.TxtNumber = new System.Windows.Forms.TextBox();
            this.LblCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(13, 96);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(585, 307);
            this.TxtOut.TabIndex = 0;
            // 
            // CmdGenerate
            // 
            this.CmdGenerate.Location = new System.Drawing.Point(258, 42);
            this.CmdGenerate.Name = "CmdGenerate";
            this.CmdGenerate.Size = new System.Drawing.Size(209, 32);
            this.CmdGenerate.TabIndex = 1;
            this.CmdGenerate.Text = "Generiere Zufallszahl";
            this.CmdGenerate.UseVisualStyleBackColor = true;
            this.CmdGenerate.Click += new System.EventHandler(this.CmdGenerate_Click);
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(486, 42);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(111, 32);
            this.CmdStart.TabIndex = 2;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // TxtNumber
            // 
            this.TxtNumber.Enabled = false;
            this.TxtNumber.Location = new System.Drawing.Point(15, 42);
            this.TxtNumber.Name = "TxtNumber";
            this.TxtNumber.Size = new System.Drawing.Size(192, 26);
            this.TxtNumber.TabIndex = 3;
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(12, 421);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(260, 20);
            this.LblCount.TabIndex = 4;
            this.LblCount.Text = "Anzahl Schleifenwiederholungen: ...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 450);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.TxtNumber);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.CmdGenerate);
            this.Controls.Add(this.TxtOut);
            this.Name = "Form1";
            this.Text = "Aufgabe_A6_2_1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.Button CmdGenerate;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.TextBox TxtNumber;
        private System.Windows.Forms.Label LblCount;
    }
}

