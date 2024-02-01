﻿using System;
using ScreenSound.view;

namespace ScreenSound{

    class ScreenSound{
        static public void Main(){

            ScreenSoundView.Apresentation();
            
            MenuView menu = new MenuView();

            menu.Main();

            Console.CancelKeyPress += new ConsoleCancelEventHandler(FinishingApplicationView.FinishHandler!);
        }
    }
}