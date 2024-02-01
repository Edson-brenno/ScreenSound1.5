using System;
using ScreenSound.view;
using ScreenSound.Model;

namespace ScreenSound{

    class ScreenSound{
        static public void Main(){

            //ScreenSoundView.Apresentation();
            
            //MenuView menu = new MenuView();

            //menu.Main();

            //Console.CancelKeyPress += new ConsoleCancelEventHandler(FinishingApplicationView.FinishHandler!);

            List<BandModel> band = new List<BandModel>();

            band.Add(new BandModel("Ac-Dc"));
            band.Add(new BandModel("Car"));

            band.ForEach( a => Console.WriteLine($"Banda: {a.Criacao}"));
        }
    }
}