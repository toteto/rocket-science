using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoProektGames.Flags
{
    public partial class Flags : Form
    {
        public Game newGame;
        
        public Flags()
        {
            InitializeComponent();
        }

        private void Flags_Load(object sender, EventArgs e)
        {
            newGame = new Game();
            startGame();
        }

        private void startGame()
        {
            newGame.startNewGame();
            getNextQuestion();
            progressBar1.Value = 0;
            timer2.Start();
        }

        private void getNextQuestion()
        {
            newGame.generateNextQuestion();

            List<String> list = newGame.answerList;

            textBox1.Text = newGame.countryList.ElementAt(newGame.currentQuestion).Replace(".png", "");

            pictureBox1.Image = Image.FromFile("../../Pictures/" + list.ElementAt(0));
            pictureBox2.Image = Image.FromFile("../../Pictures/" + list.ElementAt(1));
            pictureBox3.Image = Image.FromFile("../../Pictures/" + list.ElementAt(2));
            pictureBox4.Image = Image.FromFile("../../Pictures/" + list.ElementAt(3));

            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
        }
    }
}
