namespace Il_Projeticato
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NumberEntry1 = new System.Windows.Forms.TextBox();
            this.NumberOutput1 = new System.Windows.Forms.Label();
            this.NumberEntry2 = new System.Windows.Forms.TextBox();
            this.NumberEntry3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(537, 239);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(170, 155);
            this.button1.TabIndex = 0;
            this.button1.Text = "Le Buttogne";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(534, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "La Làble";
            // 
            // NumberEntry1
            // 
            this.NumberEntry1.Location = new System.Drawing.Point(39, 89);
            this.NumberEntry1.Name = "NumberEntry1";
            this.NumberEntry1.Size = new System.Drawing.Size(140, 22);
            this.NumberEntry1.TabIndex = 2;
            this.NumberEntry1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // NumberOutput1
            // 
            this.NumberOutput1.AutoSize = true;
            this.NumberOutput1.Location = new System.Drawing.Point(364, 346);
            this.NumberOutput1.Name = "NumberOutput1";
            this.NumberOutput1.Size = new System.Drawing.Size(44, 16);
            this.NumberOutput1.TabIndex = 3;
            this.NumberOutput1.Text = "label2";
            // 
            // NumberEntry2
            // 
            this.NumberEntry2.Location = new System.Drawing.Point(39, 204);
            this.NumberEntry2.Name = "NumberEntry2";
            this.NumberEntry2.Size = new System.Drawing.Size(140, 22);
            this.NumberEntry2.TabIndex = 4;
            // 
            // NumberEntry3
            // 
            this.NumberEntry3.Location = new System.Drawing.Point(39, 305);
            this.NumberEntry3.Name = "NumberEntry3";
            this.NumberEntry3.Size = new System.Drawing.Size(140, 22);
            this.NumberEntry3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kaufpreis der Immobilie";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Jährliches Haushaltseinkommen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Eigene Mittel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Benötigte Hypothek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumberEntry3);
            this.Controls.Add(this.NumberEntry2);
            this.Controls.Add(this.NumberOutput1);
            this.Controls.Add(this.NumberEntry1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumberEntry1;
        private System.Windows.Forms.Label NumberOutput1;
        private System.Windows.Forms.TextBox NumberEntry2;
        private System.Windows.Forms.TextBox NumberEntry3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

