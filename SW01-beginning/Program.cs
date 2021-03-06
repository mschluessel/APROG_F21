using System;

namespace SW01_beginning {
    /// <summary>
    ///  Hallo ich bin ein Program
    /// </summary>
    /// <param name="args"> Parameters passed to program. </param>

    class Program {
        //set enum
        [Flags]
        enum FileModes {
            ReadMode = 1,
            WriteMode = 2,
            Execute = 4
        }

        static void Main(string[] args) {

            #region JedeMengeAusgaben
            PrintStr("Hello World!", true);
            if(args.Length != 0) {
                for(int i = 0; i < args.Length; i++) {
                    Console.Write($"{args[i]} ");
                }
            }
            Console.WriteLine();

            //Print Char
            PrintChar("Hello" + " World", false);
            PrintChar("Everything on new line", true);

            //Print Hex
            PrintHex(29, 123);

            //Read from console and Print it
            PrintStr("Write something to output in console...", false);
            string cinput = Console.ReadLine();
            PrintStr($"Your input is: {cinput}", false);

            //foreach
            Console.WriteLine("List all args");
            foreach(string s in args) {
                Console.WriteLine(s);
            }

            //enum
            FileModes m;
            m = FileModes.ReadMode | FileModes.Execute;
            if((m & FileModes.WriteMode) != 0) {
                Console.WriteLine("Write access");
            }
            else {
                Console.WriteLine("No write access");
            }

            //End of Program
            PrintStr("Press any key to End Program...", false);
            Console.ReadKey();


            #endregion

        }

        static void PrintStr(string str, bool toUpper) {
            if(toUpper) {
                Console.WriteLine(str.ToUpper());
            }
            else {
                Console.WriteLine(str);
            }
        }

        static void PrintChar(string str, bool newline) {
            if(newline) {
                for(int i = 0; i < str.Length; i++) {
                    char ch = str[i];
                    Console.WriteLine(ch);
                }
            }
            else {
                for(int i = 0; i < str.Length; i++) {
                    char ch = str[i];
                    Console.Write(ch);
                }
                Console.WriteLine();
            }
        }

        static void PrintHex(int i1, int i2) {
            Console.WriteLine($"{i1} ist in Hex: 0x{i1.ToString("X4")}");
            Console.WriteLine($"{i2} ist in Hex: 0x{i2:X4}");
        }

    }// end Program
} // end namespace