using System;
using ScreenSound.view.Error;

namespace ScreenSound.view.MenuExceptions{

    internal class IsNotAIntegerException: Exception{
        
        public IsNotAIntegerException(){
            
            Console.Clear();

            ErrorView.ShowMensagem(); 

            System.Console.WriteLine("The option can not be a letter or especial character");

            Thread.Sleep(ErrorView.sleepTimer);

            Console.Clear();

        }
    }
}