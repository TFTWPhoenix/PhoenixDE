using System;
using PhoenixDE.Util;
namespace PhoenixDE {
    public class Command {
        public static void exec(String cmd) {
            if(cmd == "bash") {
                System.Diagnostics.Process proc = System.Diagnostics.Process.Start("/bin/bash");
                proc.WaitForExit();
            } else if (cmd == "help") {
                ScreenUtil.printTitle("Commands");
                Console.WriteLine("help, bash, exit, zsh (requires zsh)");
                Console.WriteLine(ScreenUtil.fullline);
                    
            } else if (cmd == "exit") {
                Environment.Exit(0);
            } else if (cmd == "zsh") {
                System.Diagnostics.Process proc = System.Diagnostics.Process.Start("/bin/zsh");
                proc.WaitForExit();
            }
        }
    }
}