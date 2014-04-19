using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace VizuelnoProektGames.Flags
{
    public class Game
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

        public void generateNextQuestion()
        {
            answerList.Clear();

            answerList.Add(countryList.ElementAt(currentQuestion));

            for (int i = 0; i < 3; i++)
            {
                String country = generateRandomCountry();

                if (answerList.Contains(country))
                    i--;
                else
                    answerList.Add(country);

            }

            answerList = shuffle(answerList);

            setTrueAnswer();

            numQuestion++;
        }

        private void setTrueAnswer()
        {
            for (int i = 0; i < answerList.Count; i++)
            {
                if (answerList.ElementAt(i) == countryList.ElementAt(currentQuestion))
                {
                    indexOfTrueAnswer = i;
                    break;
                }
            }

        }

        private String generateRandomCountry()
        {
            Random ran = new Random();
            while (true)
            {
                String temp = countryList.ElementAt(ran.Next(0, numberOfQuestion));
                if (temp != countryList.ElementAt(currentQuestion))
                    return temp;
            }
        }

        public int isCorrect(int n)
        {
            if (n == indexOfTrueAnswer)
                points++;

            currentQuestion++;
            return indexOfTrueAnswer;
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
