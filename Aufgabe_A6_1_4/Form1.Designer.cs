namespace Aufgabe_A6_1_4
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
            this.NumStart = new System.Windows.Forms.NumericUpDown();
            this.NumEnd = new System.Windows.Forms.NumericUpDown();
            this.NumStep = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmdStart = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RadEven = new System.Windows.Forms.RadioButton();
            this.RadOdd = new System.Windows.Forms.RadioButton();
            this.RadEverything = new System.Windows.Forms.RadioButton();
            this.TxtOut = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStep)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumStart
            // 
            this.NumStart.Location = new System.Drawing.Point(32, 77);
            this.NumStart.Name = "NumStart";
            this.NumStart.Size = new System.Drawing.Size(120, 26);
            this.NumStart.TabIndex = 0;
            // 
            // NumEnd
            // 
            this.NumEnd.Location = new System.Drawing.Point(199, 77);
            this.NumEnd.Name = "NumEnd";
            this.NumEnd.Size = new System.Drawing.Size(120, 26);
            this.NumEnd.TabIndex = 0;
            // 
            // NumStep
            // 
            this.NumStep.Location = new System.Drawing.Point(370, 77);
            this.NumStep.Name = "NumStep";
            this.NumStep.Size = new System.Drawing.Size(120, 26);
            this.NumStep.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Startwert:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(195, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endwert:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Schritt:";
            // 
            // CmdStart
            // 
            this.CmdStart.Location = new System.Drawing.Point(36, 151);
            this.CmdStart.Name = "CmdStart";
            this.CmdStart.Size = new System.Drawing.Size(148, 40);
            this.CmdStart.TabIndex = 2;
            this.CmdStart.Text = "Ausgabe starten";
            this.CmdStart.UseVisualStyleBackColor = true;
            this.CmdStart.Click += new System.EventHandler(this.CmdStart_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(214, 151);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(148, 40);
            this.CmdClear.TabIndex = 2;
            this.CmdClear.Text = "Ausgabe löschen";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bitte wählen Sie:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RadEverything);
            this.panel1.Controls.Add(this.RadOdd);
            this.panel1.Controls.Add(this.RadEven);
            this.panel1.Location = new System.Drawing.Point(40, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 44);
            this.panel1.TabIndex = 4;
            // 
            // RadEven
            // 
            this.RadEven.AutoSize = true;
            this.RadEven.Checked = true;
            this.RadEven.Location = new System.Drawing.Point(4, 4);
            this.RadEven.Name = "RadEven";
            this.RadEven.Size = new System.Drawing.Size(135, 24);
            this.RadEven.TabIndex = 0;
            this.RadEven.TabStop = true;
            this.RadEven.Text = "Ganze Zahlen";
            this.RadEven.UseVisualStyleBackColor = true;
            // 
            // RadOdd
            // 
            this.RadOdd.AutoSize = true;
            this.RadOdd.Location = new System.Drawing.Point(144, 3);
            this.RadOdd.Name = "RadOdd";
            this.RadOdd.Size = new System.Drawing.Size(158, 24);
            this.RadOdd.TabIndex = 0;
            this.RadOdd.TabStop = true;
            this.RadOdd.Text = "Ungerade Zahlen";
            this.RadOdd.UseVisualStyleBackColor = true;
            // 
            // RadEverything
            // 
            this.RadEverything.AutoSize = true;
            this.RadEverything.Location = new System.Drawing.Point(308, 3);
            this.RadEverything.Name = "RadEverything";
            this.RadEverything.Size = new System.Drawing.Size(113, 24);
            this.RadEverything.TabIndex = 0;
            this.RadEverything.TabStop = true;
            this.RadEverything.Text = "Alle Zahlen";
            this.RadEverything.UseVisualStyleBackColor = true;
            // 
            // TxtOut
            // 
            this.TxtOut.Location = new System.Drawing.Point(36, 327);
            this.TxtOut.Multiline = true;
            this.TxtOut.Name = "TxtOut";
            this.TxtOut.Size = new System.Drawing.Size(474, 227);
            this.TxtOut.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 584);
            this.Controls.Add(this.TxtOut);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumStep);
            this.Controls.Add(this.NumEnd);
            this.Controls.Add(this.NumStart);
            this.Name = "Form1";
            this.Text = "Aufgabe_A6_1_4";
            ((System.ComponentModel.ISupportInitialize)(this.NumStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumStep)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumStart;
        private System.Windows.Forms.NumericUpDown NumEnd;
        private System.Windows.Forms.NumericUpDown NumStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CmdStart;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton RadEverything;
        private System.Windows.Forms.RadioButton RadOdd;
        private System.Windows.Forms.RadioButton RadEven;
        private System.Windows.Forms.TextBox TxtOut;
    }
}

