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

        private void getListOfCountry()
        {
            DirectoryInfo MyRoot = new DirectoryInfo("../../Pictures");
            FileInfo[] fileList = MyRoot.GetFiles();
            foreach (FileInfo file in fileList)
                countryList.Add(file.Name);
        }
    }
}
