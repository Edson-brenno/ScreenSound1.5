using System;
using System.Reflection;
using ScreenSound.view.MenuExceptions;

namespace ScreenSound.view{
    
    internal class MenuView{
        
        private bool keepAsking = true; //Will be used to ask the option
        private void Apresentation(){ //Responsible for the screenSound appresentations
            Console.WriteLine(@"
█▀▄▀█ █▀▀ █▄░█ █░█
█░▀░█ ██▄ █░▀█ █▄█");
        }

        private void MenuOptions(){ //Show's the menu options
            Console.WriteLine("======================================");
            Console.WriteLine("(1) Register a new band");
            Console.WriteLine("(2) Show all the bands");
            Console.WriteLine("(3) Rate a band");
            Console.WriteLine("(4) Show a band avg");
            Console.WriteLine("(5) Add a new Album");
            Console.WriteLine("(6) Add a new Music");
            Console.WriteLine("(7) See a Band Albuns");
            Console.WriteLine("(8) See a Band Music");
            Console.WriteLine("(9) Quit");
            Console.WriteLine("======================================");

        }

        private void AskMenuOption(){ //Will ask the user the option
            
            string menuOption = "";

            try{

                Console.Write("Please, write the menu option: ");

                menuOption = Console.ReadLine()!;


                if (String.IsNullOrEmpty(menuOption) || String.IsNullOrWhiteSpace(menuOption)){
                    throw new IsnullException();
                }
                else if (!char.IsDigit(menuOption[0])){
                    throw new IsNotAIntegerException();
                }
                else if (char.IsDigit(menuOption[0]) && int.Parse(menuOption) > 9){
                    throw new InvalidOptionException(menuOption);
                }
                else {
                    Console.WriteLine($"The chosed option were {menuOption} how?");

                    this.keepAsking = false;    
                }

            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);

                Console.Clear();
            }
        }

        public void Main(){ //main function

            while(this.keepAsking){

                Console.CancelKeyPress += new ConsoleCancelEventHandler(FinishingApplicationView.FinishHandler!);

                this.Apresentation();

                this.MenuOptions();

                this.AskMenuOption();

            }
        }
    }
}