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
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartXOCeption
            // 
            this.btnStartXOCeption.Location = new System.Drawing.Point(12, 12);
            this.btnStartXOCeption.Name = "btnStartXOCeption";
            this.btnStartXOCeption.Size = new System.Drawing.Size(219, 99);
            this.btnStartXOCeption.TabIndex = 0;
            this.btnStartXOCeption.Text = "XOception";
            this.btnStartXOCeption.UseVisualStyleBackColor = true;
            this.btnStartXOCeption.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFlags
            // 
            this.btnFlags.Location = new System.Drawing.Point(12, 117);
            this.btnFlags.Name = "btnFlags";
            this.btnFlags.Size = new System.Drawing.Size(219, 99);
            this.btnFlags.TabIndex = 1;
            this.btnFlags.Text = "Знамиња на држави";
            this.btnFlags.UseVisualStyleBackColor = true;
            this.btnFlags.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(12, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(219, 100);
            this.button1.TabIndex = 2;
            this.button1.Text = "Меморија";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "GitHub";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 367);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(219, 76);
            this.textBox1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 455);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFlags);
            this.Controls.Add(this.btnStartXOCeption);
            this.Name = "MainForm";
            this.Text = "Колекција Игри";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartXOCeption;
        private System.Windows.Forms.Button btnFlags;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

