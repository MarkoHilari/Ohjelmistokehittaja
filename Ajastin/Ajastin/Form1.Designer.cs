namespace Ajastin
{
    partial class ajastinFM
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
            this.minuuttiLB = new System.Windows.Forms.Label();
            this.sekunnitLB = new System.Windows.Forms.Label();
            this.minuuttiCB = new System.Windows.Forms.ComboBox();
            this.sekunttiCB = new System.Windows.Forms.ComboBox();
            this.startBT = new System.Windows.Forms.Button();
            this.resetBT = new System.Windows.Forms.Button();
            this.ajastinLB = new System.Windows.Forms.Label();
            this.ajastinTM = new System.Windows.Forms.Timer(this.components);
            this.pauseBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // minuuttiLB
            // 
            this.minuuttiLB.AutoSize = true;
            this.minuuttiLB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.minuuttiLB.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.minuuttiLB.Location = new System.Drawing.Point(312, 188);
            this.minuuttiLB.Name = "minuuttiLB";
            this.minuuttiLB.Size = new System.Drawing.Size(152, 47);
            this.minuuttiLB.TabIndex = 0;
            this.minuuttiLB.Text = "Minuutit";
            // 
            // sekunnitLB
            // 
            this.sekunnitLB.AutoSize = true;
            this.sekunnitLB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.sekunnitLB.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.sekunnitLB.Location = new System.Drawing.Point(708, 188);
            this.sekunnitLB.Name = "sekunnitLB";
            this.sekunnitLB.Size = new System.Drawing.Size(154, 47);
            this.sekunnitLB.TabIndex = 1;
            this.sekunnitLB.Text = "Sekunnit";
            // 
            // minuuttiCB
            // 
            this.minuuttiCB.FormattingEnabled = true;
            this.minuuttiCB.Location = new System.Drawing.Point(483, 202);
            this.minuuttiCB.Name = "minuuttiCB";
            this.minuuttiCB.Size = new System.Drawing.Size(63, 33);
            this.minuuttiCB.TabIndex = 2;
            // 
            // sekunttiCB
            // 
            this.sekunttiCB.FormattingEnabled = true;
            this.sekunttiCB.Location = new System.Drawing.Point(888, 202);
            this.sekunttiCB.Name = "sekunttiCB";
            this.sekunttiCB.Size = new System.Drawing.Size(63, 33);
            this.sekunttiCB.TabIndex = 3;
            // 
            // startBT
            // 
            this.startBT.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.startBT.Location = new System.Drawing.Point(302, 310);
            this.startBT.Name = "startBT";
            this.startBT.Size = new System.Drawing.Size(191, 56);
            this.startBT.TabIndex = 4;
            this.startBT.Text = "Käynnistä";
            this.startBT.UseVisualStyleBackColor = true;
            this.startBT.Click += new System.EventHandler(this.startBT_Click);
            // 
            // resetBT
            // 
            this.resetBT.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resetBT.Location = new System.Drawing.Point(708, 310);
            this.resetBT.Name = "resetBT";
            this.resetBT.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resetBT.Size = new System.Drawing.Size(188, 56);
            this.resetBT.TabIndex = 5;
            this.resetBT.Text = "Nollaa";
            this.resetBT.UseVisualStyleBackColor = true;
            this.resetBT.Click += new System.EventHandler(this.resetBT_Click_1);
            // 
            // ajastinLB
            // 
            this.ajastinLB.AutoSize = true;
            this.ajastinLB.Font = new System.Drawing.Font("Segoe Script", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ajastinLB.Location = new System.Drawing.Point(319, 448);
            this.ajastinLB.Name = "ajastinLB";
            this.ajastinLB.Size = new System.Drawing.Size(374, 153);
            this.ajastinLB.TabIndex = 6;
            this.ajastinLB.Text = "00:00";
            // 
            // ajastinTM
            // 
            this.ajastinTM.Interval = 1000;
            this.ajastinTM.Tick += new System.EventHandler(this.ajastinTM_Tick);
            // 
            // pauseBT
            // 
            this.pauseBT.Font = new System.Drawing.Font("Poor Richard", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pauseBT.Location = new System.Drawing.Point(531, 310);
            this.pauseBT.Name = "pauseBT";
            this.pauseBT.Size = new System.Drawing.Size(140, 56);
            this.pauseBT.TabIndex = 8;
            this.pauseBT.Text = "Pause";
            this.pauseBT.UseVisualStyleBackColor = true;
            this.pauseBT.Click += new System.EventHandler(this.pauseBT_Click);
            // 
            // ajastinFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Ajastin.Properties.Resources.ajastin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1395, 861);
            this.Controls.Add(this.pauseBT);
            this.Controls.Add(this.ajastinLB);
            this.Controls.Add(this.resetBT);
            this.Controls.Add(this.startBT);
            this.Controls.Add(this.sekunttiCB);
            this.Controls.Add(this.minuuttiCB);
            this.Controls.Add(this.sekunnitLB);
            this.Controls.Add(this.minuuttiLB);
            this.Name = "ajastinFM";
            this.Text = "Ajastin";
            this.Load += new System.EventHandler(this.ajastinFM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label minuuttiLB;
        private Label sekunnitLB;
        private ComboBox minuuttiCB;
        private ComboBox sekunttiCB;
        private Button startBT;
        private Button resetBT;
        private Label ajastinLB;
        private System.Windows.Forms.Timer ajastinTM;
        private Button pauseBT;
    }
}