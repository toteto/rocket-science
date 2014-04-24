namespace VizuelnoProektGames
{
    partial class MainForm
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
            this.btnStartXOCeption = new System.Windows.Forms.Button();
            this.btnFlags = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartXOCeption
            // 
            this.btnStartXOCeption.Location = new System.Drawing.Point(86, 127);
            this.btnStartXOCeption.Name = "btnStartXOCeption";
            this.btnStartXOCeption.Size = new System.Drawing.Size(110, 23);
            this.btnStartXOCeption.TabIndex = 0;
            this.btnStartXOCeption.Text = "Играј XOception";
            this.btnStartXOCeption.UseVisualStyleBackColor = true;
            this.btnStartXOCeption.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFlags
            // 
            this.btnFlags.Location = new System.Drawing.Point(86, 189);
            this.btnFlags.Name = "btnFlags";
            this.btnFlags.Size = new System.Drawing.Size(75, 23);
            this.btnFlags.TabIndex = 1;
            this.btnFlags.Text = "Flags";
            this.btnFlags.UseVisualStyleBackColor = true;
            this.btnFlags.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Memory";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 395);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFlags);
            this.Controls.Add(this.btnStartXOCeption);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartXOCeption;
        private System.Windows.Forms.Button btnFlags;
        private System.Windows.Forms.Button button1;
    }
}

