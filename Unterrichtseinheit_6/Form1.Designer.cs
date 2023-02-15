namespace Unterrichtseinheit_6
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
            this.CmdStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtOut
            // 
            this.TxtOut.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOut.Location = new System.Drawing.Point(38, 186);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(732, 236);
            this.TxtOut.TabIndex = 0;
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(38, 117);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(122, 42);
            this.CmdStart.TabIndex = 1;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kontrollstrukturen - Die for-Schleife";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.TxtOut);
            this.Name = "Form1";
            this.Text = "UE6_Schleifen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Label label1;
    }
}

