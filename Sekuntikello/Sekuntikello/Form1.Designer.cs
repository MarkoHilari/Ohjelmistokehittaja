namespace Sekuntikello
{
    partial class sekuntiKelloFM
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
            this.components = new System.ComponentModel.Container();
            this.kelloLB = new System.Windows.Forms.Label();
            this.startBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.stopBT = new System.Windows.Forms.Button();
            this.aikaTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // kelloLB
            // 
            this.kelloLB.AutoSize = true;
            this.kelloLB.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kelloLB.Location = new System.Drawing.Point(443, 82);
            this.kelloLB.Name = "kelloLB";
            this.kelloLB.Size = new System.Drawing.Size(439, 96);
            this.kelloLB.TabIndex = 0;
            this.kelloLB.Text = "00:00:00:000";
            // 
            // startBT
            // 
            this.startBT.BackColor = System.Drawing.Color.DarkViolet;
            this.startBT.Font = new System.Drawing.Font("SimSun", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.startBT.Location = new System.Drawing.Point(245, 256);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(232, 53);
            this.startBT.TabIndex = 1;
            this.startBT.Text = "Käynnistä";
            this.startBT.UseVisualStyleBackColor = false;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.BackColor = System.Drawing.Color.DarkViolet;
            this.resetBT.Font = new System.Drawing.Font("SimSun", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.resetBT.Location = new System.Drawing.Point(811, 256);
            this.resetBT.Name = "resetBT";
            this.resetBT.Size = new System.Drawing.Size(232, 53);
            this.resetBT.TabIndex = 2;
            this.resetBT.Text = "Nollaa";
            this.resetBT.UseVisualStyleBackColor = false;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click);
            // 
            // stopBT
            // 
            this.stopBT.BackColor = System.Drawing.Color.DarkViolet;
            this.stopBT.Font = new System.Drawing.Font("SimSun", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.stopBT.Location = new System.Drawing.Point(530, 256);
            this.stopBT.Name = "stopBT";
            this.stopBT.Size = new System.Drawing.Size(232, 53);
            this.stopBT.TabIndex = 3;
            this.stopBT.Text = "Pysäytä";
            this.stopBT.UseVisualStyleBackColor = false;
            this.stopBT.Click += new System.EventHandler(this.stopBT_Click);
            // 
            // aikaTM
            // 
            this.aikaTM.Enabled = true;
            this.aikaTM.Interval = 1000;
            this.aikaTM.Tick += new System.EventHandler(this.aikaTM_Tick);
            // 
            // sekuntiKelloFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1380, 865);
            this.Controls.Add(this.stopBT);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.kelloLB);
            this.Name = "sekuntiKelloFM";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.sekuntiKelloFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label kelloLB;
        private Button startBT;
        private Button resetBT;
        private Button stopBT;
        private System.Windows.Forms.Timer aikaTM;
    }
}