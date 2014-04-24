namespace VizuelnoProektGames.Memory
{
    partial class MemoryMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnHard = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Matura MT Script Capitals", 22F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblWelcome.Location = new System.Drawing.Point(30, 9);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(416, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Memory Game";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblLevel.Location = new System.Drawing.Point(208, 58);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(65, 25);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Level:";
            // 
            // btnEasy
            // 
            this.btnEasy.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnEasy.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnEasy.Location = new System.Drawing.Point(12, 95);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(146, 44);
            this.btnEasy.TabIndex = 2;
            this.btnEasy.Text = "Easy";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNormal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNormal.Location = new System.Drawing.Point(170, 95);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(146, 44);
            this.btnNormal.TabIndex = 3;
            this.btnNormal.Text = "Normal";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnHard
            // 
            this.btnHard.Font = new System.Drawing.Font("Algerian", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnHard.ForeColor = System.Drawing.Color.DarkRed;
            this.btnHard.Location = new System.Drawing.Point(325, 95);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(146, 44);
            this.btnHard.TabIndex = 4;
            this.btnHard.Text = "Hard";
            this.btnHard.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(12, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(459, 43);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // MemoryMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 218);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnHard);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnEasy);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MemoryMainForm";
            this.Text = "Welcome - Memory Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.Button btnStart;
    }
}