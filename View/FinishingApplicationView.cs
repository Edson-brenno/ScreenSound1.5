using System;

namespace ScreenSound.view{

    internal class FinishingApplicationView{

        static public void FinishHandler(object sender, ConsoleCancelEventArgs args){

                Console.Clear();

                Console.WriteLine(@"Fɪɴɪsʜɪɴɢ SᴄʀᴇᴇɴSᴏᴜɴᴅ...");

                Thread.Sleep(2000);

                Console.Clear();

                Console.WriteLine(@"
█▄▄ █▄█ █▀▀   ▀ ▀▄
█▄█ ░█░ ██▄   ▄ ▄▀");

    
        }
    }
}