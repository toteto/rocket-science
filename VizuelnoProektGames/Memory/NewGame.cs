using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VizuelnoProektGames.Memory
{
    abstract public class NewGame
    {
        public int RowCount;
        public int ColumnCount;
        public int timeLeft;
        public int totalTimeLeft;
        public float points;
        public int matchedIcons;
        public List<string> icons;
        public bool gameOver;
        public Label iconLabel;

        public NewGame()
        {
            inicializeColumnCount();
            inicializeRowCount();
            inicializeTime();
            points = 50;
            matchedIcons = 0;
            icons = new List<string>();
            generateIcons();
            iconLabel = new Label();
            points -= (float)50 / totalTimeLeft;
        }


        abstract public void inicializeTime();
        abstract public void inicializeRowCount();
        abstract public void inicializeColumnCount();

        public static void Shuffle<T>(IList<T> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void generateIcons()
        {
            Random random = new Random();
            while (icons.Count != ColumnCount * RowCount)
            {
                char c = (char)random.Next(48, 122);
                if (!icons.Contains(Char.ToString(c)))
                {
                    icons.Add(Char.ToString(c));
                    Shuffle(icons);
                    icons.Add(Char.ToString(c));
                }
            }
        }
    }
}
