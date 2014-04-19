using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VizuelnoProektGames.Flags
{
    class Game
    {
        public List<String> countryList { get; set; }
        public List<String> answerList { get; set; }

        public int currentQuestion { get; set; }
        public int numQuestion { get; set; }
        public int numberOfQuestion { get; set; }

        public int indexOfTrueAnswer { get; set; }

        public int points { get; set; }


        public Game()
        {
            countryList = new List<String>();
            answerList = new List<String>();

            getListOfCountry();
        }

        public void startNewGame()
        {
            answerList.Clear();
            points = 0;
            numQuestion = 0;
            countryList = shuffle(countryList);

            currentQuestion = 0;
            numberOfQuestion = countryList.Count - 1;

        }
       
        private List<String> shuffle(List<String> input)
        {
            List<String> output = new List<String>();
            Random rnd = new Random();

            int FIndex;
            while (input.Count > 0)
            {
                FIndex = rnd.Next(0, input.Count);
                output.Add(input[FIndex]);
                input.RemoveAt(FIndex);
            }

            input.Clear();
            input = null;
            rnd = null;

            return output;
        }

        private void getListOfCountry()
        {
            DirectoryInfo MyRoot = new DirectoryInfo("../../Pictures");
            FileInfo[] fileList = MyRoot.GetFiles();
            foreach (FileInfo file in fileList)
                countryList.Add(file.Name);
        }
    }
}
