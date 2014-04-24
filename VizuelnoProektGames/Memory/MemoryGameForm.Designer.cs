namespace VizuelnoProektGames.Memory
{
    partial class MemoryGameForm
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tblPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.pbTimeLeft = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tblPanel);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblTimeLeft);
            this.splitContainer1.Panel2.Controls.Add(this.pbTimeLeft);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.splitContainer1.Size = new System.Drawing.Size(634, 611);
            this.splitContainer1.SplitterDistance = 566;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            // 
            // tblPanel
            // 
            this.tblPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tblPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tblPanel.ColumnCount = 1;
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPanel.Location = new System.Drawing.Point(0, 0);
            this.tblPanel.Name = "tblPanel";
            this.tblPanel.RowCount = 1;
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblPanel.Size = new System.Drawing.Size(634, 566);
            this.tblPanel.TabIndex = 0;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.AutoSize = true;
            this.lblTimeLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.lblTimeLeft.Location = new System.Drawing.Point(0, -4);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(100, 25);
            this.lblTimeLeft.TabIndex = 1;
            this.lblTimeLeft.Text = "Time left:";
            // 
            // pbTimeLeft
            // 
            this.pbTimeLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pbTimeLeft.Location = new System.Drawing.Point(0, 21);
            this.pbTimeLeft.Maximum = 1;
            this.pbTimeLeft.Name = "pbTimeLeft";
            this.pbTimeLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pbTimeLeft.Size = new System.Drawing.Size(634, 23);
            this.pbTimeLeft.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 750;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MemoryGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 611);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MemoryGameForm";
            this.Text = "Memory Game";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tblPanel;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.ProgressBar pbTimeLeft;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}