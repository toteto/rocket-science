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
    }
}
