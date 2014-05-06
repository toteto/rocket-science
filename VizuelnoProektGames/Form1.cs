using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VizuelnoProektGames.Memory;

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

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            MemoryMainForm memoryMainForm = new MemoryMainForm();
            memoryMainForm.ShowDialog();
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            textBox1.Text = "Изработиле: \r\nАнтонио Ивановски\r\nПетар Папалевски\r\nТрајче Шоповски";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/toteto/rocket-science/");
        }
    }
}
