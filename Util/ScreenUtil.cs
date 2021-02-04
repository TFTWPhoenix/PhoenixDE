using System;
namespace PhoenixDE.Util {
    public class ScreenUtil {
        public static void printTitle(string title) {
            string side = "";
            for(int i = 0; i < ((Console.WindowWidth - title.Length) / 2); i++) {
                side = side + "-";
            }
            Console.WriteLine(side + title + side);
        }
        public static string fullline = "";
    }
}