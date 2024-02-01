using System;
using ScreenSound.view.Error;

namespace ScreenSound.view.MenuExceptions{

    internal class InvalidOptionException: Exception{

        public InvalidOptionException(string chosedOption){
            
            Console.Clear();

            ErrorView.ShowMensagem(); 

            System.Console.WriteLine($"The option {chosedOption} is invalid");

            Thread.Sleep(ErrorView.sleepTimer);

            Console.Clear();
        }
    }
}