namespace Muistio
{
    partial class muistioFM
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
            this.muistiBT = new System.Windows.Forms.Button();
            this.tekstiTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // muistiBT
            // 
            this.muistiBT.BackColor = System.Drawing.Color.LightGray;
            this.muistiBT.Location = new System.Drawing.Point(24, 416);
            this.muistiBT.Name = "muistiBT";
            this.muistiBT.Size = new System.Drawing.Size(1129, 72);
            this.muistiBT.TabIndex = 1;
            this.muistiBT.Text = "Tallenna muistioon";
            this.muistiBT.UseVisualStyleBackColor = false;
            this.muistiBT.Click += new System.EventHandler(this.muistiBT_Click);
            this.muistiBT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.muistiBT_KeyPress);
            // 
            // tekstiTB
            // 
            this.tekstiTB.Location = new System.Drawing.Point(24, 12);
            this.tekstiTB.Multiline = true;
            this.tekstiTB.Name = "tekstiTB";
            this.tekstiTB.Size = new System.Drawing.Size(1129, 398);
            this.tekstiTB.TabIndex = 2;
            this.tekstiTB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tekstiTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tekstiTB_KeyPress);
            // 
            // muistioFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1159, 490);
            this.Controls.Add(this.tekstiTB);
            this.Controls.Add(this.muistiBT);
            this.Name = "muistioFM";
            this.Text = "Muistio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button muistiBT;
        private TextBox tekstiTB;
    }
}