namespace UE_6_While_Schleifen
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
            this.LblWiederholungen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CmdStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(13, 104);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtOut.Size = new System.Drawing.Size(775, 276);
            this.TxtOut.TabIndex = 0;
            // 
            // LblWiederholungen
            // 
            this.LblWiederholungen.AutoSize = true;
            this.LblWiederholungen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblWiederholungen.Location = new System.Drawing.Point(13, 387);
            this.LblWiederholungen.Name = "LblWiederholungen";
            this.LblWiederholungen.Size = new System.Drawing.Size(298, 29);
            this.LblWiederholungen.TabIndex = 1;
            this.LblWiederholungen.Text = "Anzahl Wiederholungen: ...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kontrollstrukturen - Die while-Schleife";
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(12, 55);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(115, 43);
            this.CmdStart.TabIndex = 3;
            this.CmdStart.Text = "Start";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblWiederholungen);
            this.Controls.Add(this.TxtOut);
            this.Name = "Form1";
            this.Text = "While Schleifen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.Label LblWiederholungen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CmdStart;
    }
}

