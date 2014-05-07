using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VizuelnoProektGames.Memory
{
    class NormalGame : NewGame
    {
        public NormalGame() : base() { }

        public override void inicializeTime()
        {
            this.timeLeft = 55;
            this.totalTimeLeft = timeLeft;
        }

        public override void inicializeRowCount()
        {
            this.RowCount = 6;
        }

        public override void inicializeColumnCount()
        {
            this.ColumnCount = 4;
        }
    }
}
