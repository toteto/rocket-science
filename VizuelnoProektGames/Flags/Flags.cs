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
            
        }
    }
}
