namespace Aufgabe_A6_1_6
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
            this.Cmd1 = new System.Windows.Forms.Button();
            this.Cmd2 = new System.Windows.Forms.Button();
            this.Cmd3 = new System.Windows.Forms.Button();
            this.Cmd4 = new System.Windows.Forms.Button();
            this.Cmd5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtOut
            // 
            this.TxtOut.Font = new System.Drawing.Font("Courier New", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOut.Location = new System.Drawing.Point(22, 26);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(833, 354);
            this.TxtOut.TabIndex = 0;
            // 
            // Cmd1
            // 
            this.Cmd1.Location = new System.Drawing.Point(22, 387);
            this.Cmd1.Name = "Cmd1";
            this.Cmd1.Size = new System.Drawing.Size(153, 40);
            this.Cmd1.TabIndex = 1;
            this.Cmd1.Text = "Aufgabe 1";
            this.Cmd1.UseVisualStyleBackColor = true;
            this.Cmd1.Click += new System.EventHandler(this.Cmd1_Click);
            // 
            // Cmd2
            // 
            this.Cmd2.Location = new System.Drawing.Point(194, 386);
            this.Cmd2.Name = "Cmd2";
            this.Cmd2.Size = new System.Drawing.Size(153, 40);
            this.Cmd2.TabIndex = 1;
            this.Cmd2.Text = "Aufgabe 2";
            this.Cmd2.UseVisualStyleBackColor = true;
            this.Cmd2.Click += new System.EventHandler(this.Cmd2_Click);
            // 
            // Cmd3
            // 
            this.Cmd3.Location = new System.Drawing.Point(363, 386);
            this.Cmd3.Name = "Cmd3";
            this.Cmd3.Size = new System.Drawing.Size(153, 40);
            this.Cmd3.TabIndex = 1;
            this.Cmd3.Text = "Aufgabe 3";
            this.Cmd3.UseVisualStyleBackColor = true;
            // 
            // Cmd4
            // 
            this.Cmd4.Location = new System.Drawing.Point(534, 387);
            this.Cmd4.Name = "Cmd4";
            this.Cmd4.Size = new System.Drawing.Size(153, 40);
            this.Cmd4.TabIndex = 1;
            this.Cmd4.Text = "Aufgabe 4";
            this.Cmd4.UseVisualStyleBackColor = true;
            // 
            // Cmd5
            // 
            this.Cmd5.Location = new System.Drawing.Point(702, 387);
            this.Cmd5.Name = "Cmd5";
            this.Cmd5.Size = new System.Drawing.Size(153, 40);
            this.Cmd5.TabIndex = 1;
            this.Cmd5.Text = "Aufgabe 5";
            this.Cmd5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.Cmd5);
            this.Controls.Add(this.Cmd4);
            this.Controls.Add(this.Cmd3);
            this.Controls.Add(this.Cmd2);
            this.Controls.Add(this.Cmd1);
            this.Controls.Add(this.TxtOut);
            this.Name = "Form1";
            this.Text = "Aufgabe_A6_1_6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtOut;
        private System.Windows.Forms.Button Cmd1;
        private System.Windows.Forms.Button Cmd2;
        private System.Windows.Forms.Button Cmd3;
        private System.Windows.Forms.Button Cmd4;
        private System.Windows.Forms.Button Cmd5;
    }
}

