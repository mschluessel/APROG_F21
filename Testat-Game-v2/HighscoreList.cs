using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testat_Game {
    class HighscoreList {

        private static int capacity = 10;
        private int count = 0;
        private bool newHighscore = false;

        //generiert generische liste mit der Kapazität capacity 
        List<TimeSpan> highscoreList = new List<TimeSpan>(capacity);

        //fügt die erreichte Zeit in die highscore liste ein
        public void HighscoreAdd(TimeSpan score) {

            //überpüft ob es die beste Zeit ist
            if (count > 0) {
                CheckHighscore(score);
            }

            //falls die liste voll ist wird geprüft ob die Zeit in die Liste eingetragen wird
            if (count == capacity) {
                if (score < highscoreList[9]) {
                    highscoreList.RemoveAt(9);
                    highscoreList.Add(score);
                    highscoreList.Sort();
                    if (!newHighscore) {
                        Console.WriteLine("Glückwunsch du hast es in die Top 10 geschafft!");
                    }
                    return;
                }
                else {
                    Console.WriteLine("Du hast es leider nicht in die Top 10 geschafft.");
                    return;
                }
            }

            //fügt die Zeit in die Liste ein, falls die Liste noch nicht voll ist
            highscoreList.Add(score);
            highscoreList.Sort();
            count++;

            if (!newHighscore) {
                Console.WriteLine("Glückwunsch du hast es in die Top 10 geschafft!");
            }

            return;
        }

        //gibt die highscore list in die Konsole aus
        public void PrintHighscoreList() {

            Console.WriteLine("\n-----------");
            Console.WriteLine($"Top {capacity}");
            Console.WriteLine("-----------");

            //nimmt jeden eintrag aus der highscore liste und gibt sie nacheinander auf der Konsole aus
            for (int i = 0; i < count; i++) {
                Console.Write($"{i + 1}: ");
                string output = highscoreList[i].ToString(@"ss\.fff");          //formatiert die Zeit auf Sekunde und die milisekunden auf den tausendstel
                Console.WriteLine($"{output} s");
            }
        }

        //prüft ob es ein neuer highscore ist
        public void CheckHighscore(TimeSpan score) {
            if (score < highscoreList[0]) {
                Console.WriteLine("NEW HIGHSCORE!!!!");
                newHighscore = true;
            }
        }
    }
}