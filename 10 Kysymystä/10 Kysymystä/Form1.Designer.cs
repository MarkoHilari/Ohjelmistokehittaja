namespace _10_Kysymystä
{
    partial class kysymysFM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.kysymysLB = new System.Windows.Forms.Label();
            this.vastausGB = new System.Windows.Forms.GroupBox();
            this.vastausDRB = new System.Windows.Forms.RadioButton();
            this.vastausCRB = new System.Windows.Forms.RadioButton();
            this.vastausBRB = new System.Windows.Forms.RadioButton();
            this.vastausARB = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.vastausLB = new System.Windows.Forms.Label();
            this.vastausGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // kysymysLB
            // 
            this.kysymysLB.AutoSize = true;
            this.kysymysLB.Location = new System.Drawing.Point(106, 76);
            this.kysymysLB.Name = "kysymysLB";
            this.kysymysLB.Size = new System.Drawing.Size(205, 25);
            this.kysymysLB.TabIndex = 0;
            this.kysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // vastausGB
            // 
            this.vastausGB.Controls.Add(this.vastausDRB);
            this.vastausGB.Controls.Add(this.vastausCRB);
            this.vastausGB.Controls.Add(this.vastausBRB);
            this.vastausGB.Controls.Add(this.vastausARB);
            this.vastausGB.Controls.Add(this.radioButton1);
            this.vastausGB.Location = new System.Drawing.Point(428, 57);
            this.vastausGB.Name = "vastausGB";
            this.vastausGB.Size = new System.Drawing.Size(120, 237);
            this.vastausGB.TabIndex = 1;
            this.vastausGB.TabStop = false;
            this.vastausGB.Text = "Vastaus:";
            // 
            // vastausDRB
            // 
            this.vastausDRB.AutoSize = true;
            this.vastausDRB.Location = new System.Drawing.Point(25, 148);
            this.vastausDRB.Name = "vastausDRB";
            this.vastausDRB.Size = new System.Drawing.Size(50, 29);
            this.vastausDRB.TabIndex = 4;
            this.vastausDRB.TabStop = true;
            this.vastausDRB.Text = "D";
            this.vastausDRB.UseVisualStyleBackColor = true;
            // 
            // vastausCRB
            // 
            this.vastausCRB.AutoSize = true;
            this.vastausCRB.Location = new System.Drawing.Point(25, 108);
            this.vastausCRB.Name = "vastausCRB";
            this.vastausCRB.Size = new System.Drawing.Size(48, 29);
            this.vastausCRB.TabIndex = 3;
            this.vastausCRB.TabStop = true;
            this.vastausCRB.Text = "C";
            this.vastausCRB.UseVisualStyleBackColor = true;
            // 
            // vastausBRB
            // 
            this.vastausBRB.AutoSize = true;
            this.vastausBRB.Location = new System.Drawing.Point(25, 74);
            this.vastausBRB.Name = "vastausBRB";
            this.vastausBRB.Size = new System.Drawing.Size(47, 29);
            this.vastausBRB.TabIndex = 2;
            this.vastausBRB.TabStop = true;
            this.vastausBRB.Text = "B";
            this.vastausBRB.UseVisualStyleBackColor = true;
            // 
            // vastausARB
            // 
            this.vastausARB.AutoSize = true;
            this.vastausARB.Location = new System.Drawing.Point(25, 40);
            this.vastausARB.Name = "vastausARB";
            this.vastausARB.Size = new System.Drawing.Size(49, 29);
            this.vastausARB.TabIndex = 1;
            this.vastausARB.TabStop = true;
            this.vastausARB.Text = "A";
            this.vastausARB.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoCheck = false;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 44);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 29);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "E";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Location = new System.Drawing.Point(106, 269);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(72, 25);
            this.vastausLB.TabIndex = 2;
            this.vastausLB.Text = "Vastaus";
            this.vastausLB.Visible = false;
            // 
            // kysymysFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 856);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.vastausGB);
            this.Controls.Add(this.kysymysLB);
            this.Name = "kysymysFM";
            this.Text = "10 Kysymystä";
            this.Load += new System.EventHandler(this.kysymysFM_Load);
            this.vastausGB.ResumeLayout(false);
            this.vastausGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kysymysLB;
        private GroupBox vastausGB;
        private RadioButton vastausDRB;
        private RadioButton vastausCRB;
        private RadioButton vastausBRB;
        private RadioButton vastausARB;
        private RadioButton radioButton1;
        private Label vastausLB;
    }
}