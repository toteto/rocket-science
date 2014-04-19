using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoProektGames
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            XOception.XOCeptionForm XOForm = new XOception.XOCeptionForm();
            XOForm.ShowDialog();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Flags.Flags FlagGame = new Flags.Flags();
            FlagGame.ShowDialog();
        }
    }
}
