using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VizuelnoProektGames.Memory
{
    class EasyGame : NewGame
    {
        public EasyGame() : base() { }

        public override void inicializeTime()
        {
            this.timeLeft = 35;
            this.totalTimeLeft = timeLeft;
        }

        public override void inicializeRowCount()
        {
            this.RowCount = 4;
        }

        public override void inicializeColumnCount()
        {
            this.ColumnCount = 4;
        }
    }
}
