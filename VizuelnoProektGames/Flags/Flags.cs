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

        private void checkQuestion(int n)
        {

            int p = newGame.isCorrect(n);

            if (p == n)
                setImage(p, true);
            else
            {
                setImage(n, false);
                setImage(p, true);
            }


            timer1.Start();
        }

        private void setImage(int p, bool x)
        {
            Bitmap image = null;

            if (x)
                image = Properties.Resources._true;
            else
                image = Properties.Resources._false;

            switch (p)
            {
                case 0:
                    pictureBox5.Image = image;
                    break;

                case 1:
                    pictureBox6.Image = image;
                    break;

                case 2:
                    pictureBox7.Image = image;
                    break;

                case 3:
                    pictureBox8.Image = image;
                    break;
            }
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            checkQuestion(0);   
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            checkQuestion(1);   
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkQuestion(2);   
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkQuestion(3);   
        }

       
    }
}
