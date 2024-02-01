using System;
using ScreenSound.view.Error;

namespace ScreenSound.view.MenuExceptions{

    internal class IsnullException: Exception{
        
        public IsnullException(){
            
            Console.Clear();

            ErrorView.ShowMensagem(); 

            System.Console.WriteLine("The menu option can not be null or blank");

            Thread.Sleep(ErrorView.sleepTimer);

            Console.Clear();
        }
    }
}