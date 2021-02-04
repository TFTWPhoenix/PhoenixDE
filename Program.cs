using System;

namespace PhoenixDE
{
    public class Program
    {

        
        public static void Main(string[] args)
        {
            Console.Clear();
            for(int i = 0; i < Console.WindowWidth; i++) {
                Util.ScreenUtil.fullline = Util.ScreenUtil.fullline + "-";
            }
            Console.WriteLine(Util.ScreenUtil.fullline);
            Console.ForegroundColor = Data.THEMEFOREGROUND;
            Console.Write("Welcome to");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" PhoenixDE");
            Console.ForegroundColor = Data.THEMEFOREGROUND;
            Console.WriteLine(" v" + Data.version);
            Console.WriteLine("Run \"help\" for a list of commands.");
            Random random = new Random();
            Console.WriteLine(Data.motds[random.Next(0,Data.motds.Length)]);
            Console.WriteLine(Util.ScreenUtil.fullline);
            Console.WriteLine("");

            while(true) {
                Console.ForegroundColor = Data.PROMPTCOLOR;
                Console.Write("PhoenixDE > ");
                Console.ForegroundColor = Data.THEMEFOREGROUND;
                string cmd = Console.ReadLine();
                Command.exec(cmd);
            }

        }
    }
}
