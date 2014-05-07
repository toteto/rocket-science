using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoProektGames.Memory
{
    class HardGame : NewGame
    {

        public override void inicializeTime()
        {
            this.timeLeft = 80;
            this.totalTimeLeft = timeLeft;
        }

        public override void inicializeRowCount()
        {
            this.RowCount = 6;
        }

        public override void inicializeColumnCount()
        {
            this.ColumnCount = 6;
        }
    }
}
