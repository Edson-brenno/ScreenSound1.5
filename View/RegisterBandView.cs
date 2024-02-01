using System;
using System.Runtime.InteropServices.Marshalling;
using ScreenSound.view.RegisterBandViewException;

namespace ScreenSound.view{

    internal class RegisterBandView{

        private string? bandName;
        private void Apresentation(){ //The band Register apresentation

            Console.Clear();

            Console.WriteLine(@"
█▄▄ ▄▀█ █▄░█ █▀▄   █▀█ █▀▀ █▀▀ █ █▀ ▀█▀ █▀▀ █▀█
█▄█ █▀█ █░▀█ █▄▀   █▀▄ ██▄ █▄█ █ ▄█ ░█░ ██▄ █▀▄");

            Console.WriteLine("==============================================");
        }

        private void ClearTheCurrentLine(){ // Will clear the current writeline

            Console.SetCursorPosition(0, Console.CursorTop - 1);

            Console.WriteLine(new string(' ', Console.WindowWidth));

            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        private void AskBandName(){ //Ask the band name

            string inputedBandName;

            while(true){

                try{
                    Console.Write("Write the Band name: ");

                    inputedBandName = Console.ReadLine() ?? String.Empty;

                    if (String.IsNullOrEmpty(inputedBandName) || String.IsNullOrWhiteSpace(inputedBandName)){
                        
                        throw new IsNullOrEmptyException();

                    }
                    else{
                        
                        this.bandName = inputedBandName;
                        Console.SetCursorPosition(0, Console.WindowTop);
                        Console.Clear();
                        break;

                    }
                }catch( Exception message){
                    Console.WriteLine(message.InnerException);
                    this.ClearTheCurrentLine();
                }
                
            }
            
        }

        public void Main(){
            this.Apresentation();
            this.AskBandName();
        }
    }
}