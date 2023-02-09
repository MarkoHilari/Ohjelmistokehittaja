namespace Suositut_nimet
{
    partial class suositutNimetFM
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
            this.tarkastaLB = new System.Windows.Forms.Label();
            this.vastausLB = new System.Windows.Forms.Label();
            this.tarkastaBT = new System.Windows.Forms.Button();
            this.vastausTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tarkastaLB
            // 
            this.tarkastaLB.AutoSize = true;
            this.tarkastaLB.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarkastaLB.Location = new System.Drawing.Point(160, 78);
            this.tarkastaLB.Name = "tarkastaLB";
            this.tarkastaLB.Size = new System.Drawing.Size(718, 24);
            this.tarkastaLB.TabIndex = 0;
            this.tarkastaLB.Text = "Anna nimesi niin kurkkaan onko nimesi suosittujen joukossa:";
            // 
            // vastausLB
            // 
            this.vastausLB.AutoSize = true;
            this.vastausLB.Font = new System.Drawing.Font("Lucida Handwriting", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vastausLB.Location = new System.Drawing.Point(160, 280);
            this.vastausLB.Name = "vastausLB";
            this.vastausLB.Size = new System.Drawing.Size(81, 41);
            this.vastausLB.TabIndex = 1;
            this.vastausLB.Text = "xxx";
            this.vastausLB.Visible = false;
            // 
            // tarkastaBT
            // 
            this.tarkastaBT.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarkastaBT.Location = new System.Drawing.Point(160, 170);
            this.tarkastaBT.Name = "tarkastaBT";
            this.tarkastaBT.Size = new System.Drawing.Size(927, 34);
            this.tarkastaBT.TabIndex = 2;
            this.tarkastaBT.Text = "Tarkasta";
            this.tarkastaBT.UseVisualStyleBackColor = true;
            this.tarkastaBT.Click += new System.EventHandler(this.button1_Click);
            // 
            // vastausTB
            // 
            this.vastausTB.Location = new System.Drawing.Point(946, 78);
            this.vastausTB.Name = "vastausTB";
            this.vastausTB.Size = new System.Drawing.Size(150, 31);
            this.vastausTB.TabIndex = 3;
            this.vastausTB.TextChanged += new System.EventHandler(this.vastausTB_TextChanged);
            this.vastausTB.Enter += new System.EventHandler(this.vastausTB_Enter);
            this.vastausTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.vastausTB_KeyPress);
            // 
            // suositutNimetFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 845);
            this.Controls.Add(this.vastausTB);
            this.Controls.Add(this.tarkastaBT);
            this.Controls.Add(this.vastausLB);
            this.Controls.Add(this.tarkastaLB);
            this.Name = "suositutNimetFM";
            this.Text = "Onko nimesi suosittu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label tarkastaLB;
        private Label vastausLB;
        private Button tarkastaBT;
        private TextBox vastausTB;
    }
}