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

        public Game()
        {
            countryList = new List<String>();
            answerList = new List<String>();

            getListOfCountry();
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
