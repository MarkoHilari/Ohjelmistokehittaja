namespace NopanHeitto
{
    partial class heitaNoppaFM
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.heitaBT = new System.Windows.Forms.Button();
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DimGray;
            this.textBox1.Font = new System.Drawing.Font("Script MT Bold", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(470, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(364, 75);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Heitä noppaa!";
            // 
            // heitaBT
            // 
            this.heitaBT.BackColor = System.Drawing.Color.DimGray;
            this.heitaBT.Font = new System.Drawing.Font("MV Boli", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.heitaBT.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.heitaBT.Location = new System.Drawing.Point(748, 636);
            this.heitaBT.Name = "heitaBT";
            this.heitaBT.Size = new System.Drawing.Size(170, 60);
            this.heitaBT.TabIndex = 4;
            this.heitaBT.Text = "Heitä";
            this.heitaBT.UseVisualStyleBackColor = false;
            this.heitaBT.Click += new System.EventHandler(this.heitaBT_Click);
            // 
            // noppa01PB
            // 
            this.noppa01PB.BackgroundImage = global::NopanHeitto.Properties.Resources.dice01;
            this.noppa01PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppa01PB.Location = new System.Drawing.Point(470, 271);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(193, 180);
            this.noppa01PB.TabIndex = 5;
            this.noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            this.noppa02PB.BackgroundImage = global::NopanHeitto.Properties.Resources.dice01;
            this.noppa02PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.noppa02PB.Location = new System.Drawing.Point(819, 271);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(201, 180);
            this.noppa02PB.TabIndex = 6;
            this.noppa02PB.TabStop = false;
            // 
            // heitaNoppaFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NopanHeitto.Properties.Resources.cube_689618_1920;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1409, 890);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Controls.Add(this.heitaBT);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Name = "heitaNoppaFM";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Button heitaBT;
        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
    }
}