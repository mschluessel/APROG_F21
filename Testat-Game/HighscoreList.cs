using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testat_Game {
    class HighscoreList {

        private static int capacity = 10;
        private int count = 0;

        List<double> highscoreList = new List<double>(capacity);

        public bool HighscoreAdd(double score) {
            if (count==capacity) {
                if (score < highscoreList[9]) {
                    highscoreList.RemoveAt(9);
                    highscoreList.Add(score);
                    highscoreList.Sort();
                    return true;
                }
                else {
                    return false;
                }
            }
            highscoreList.Add(score);
            highscoreList.Sort();
            count++;
            return true;
        }

        public void PrintHighscoreList() {
            for (int i = 0; i < count; i++) {
                Console.Write($"{i+1}: ");
                Console.WriteLine($"{highscoreList[i]} s");
            }
        }


    }
}
