using System;

namespace PhoenixDE
{
    public class Program
    {

        public static void printTitle(string title) {
            string side = "";
            for(int i = 0; i < ((Console.WindowWidth - title.Length) / 2); i++) {
                side = side + "-";
            }
            Console.WriteLine(side + title + side);
        }
        public static void Main(string[] args)
        {
            Console.Clear();
            string fullline = "";
            for(int i = 0; i < Console.WindowWidth; i++) {
                fullline = fullline + "-";
            }
            Console.WriteLine(fullline);
            Console.ForegroundColor = Data.THEMEFOREGROUND;
            Console.Write("Welcome to");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" PhoenixDE");
            Console.ForegroundColor = Data.THEMEFOREGROUND;
            Console.WriteLine(" v" + Data.version);
            Console.WriteLine("Run \"help\" for a list of commands.");
            Random random = new Random();
            Console.WriteLine(Data.motds[random.Next(0,Data.motds.Length)]);
            Console.WriteLine(fullline);
            Console.WriteLine("");

            while(true) {
                Console.ForegroundColor = Data.PROMPTCOLOR;
                Console.Write("PhoenixDE > ");
                Console.ForegroundColor = Data.THEMEFOREGROUND;
                string cmd = Console.ReadLine();
                if(cmd == "bash") {
                    System.Diagnostics.Process proc = System.Diagnostics.Process.Start("/bin/bash");
                    proc.WaitForExit();
                } else if (cmd == "help") {
                    printTitle("Commands");
                    Console.WriteLine("help, bash, exit");
                    Console.WriteLine(fullline);
                    
                } else if (cmd == "exit") {
                    Environment.Exit(0);
                }
            }

        }
    }
}
