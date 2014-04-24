using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoProektGames.Memory
{
    public partial class MemoryMainForm : Form
    {
        private string level = null;

        public MemoryMainForm()
        {
            InitializeComponent();
        }
        
        private void btnEasy_Click(object sender, EventArgs e)
        {
            level = "easy";
            btnEasy.FlatStyle = FlatStyle.Flat;
            btnNormal.FlatStyle = FlatStyle.Standard;
            btnHard.FlatStyle = FlatStyle.Standard;
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            level = "normal";
            btnNormal.FlatStyle = FlatStyle.Flat;
            btnEasy.FlatStyle = FlatStyle.Standard;
            btnHard.FlatStyle = FlatStyle.Standard;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            level = "hard";
            btnEasy.FlatStyle = FlatStyle.Standard;
            btnHard.FlatStyle = FlatStyle.Flat;
            btnNormal.FlatStyle = FlatStyle.Standard;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (level != null)
            {
                this.Hide();
                MemoryGameForm game = new MemoryGameForm(level);
                game.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select level.");
            }
        }




    }
}
