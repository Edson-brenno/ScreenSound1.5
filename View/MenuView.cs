using System;
using System.Reflection;
using ScreenSound.view.MenuExceptions;

namespace ScreenSound.view{
    
    internal class MenuView{
        
        private string? menuOption = "";
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
           
            try{

                Console.Write("Please, write the menu option: ");

                this.menuOption = Console.ReadLine()!;


                if (String.IsNullOrEmpty(this.menuOption) || String.IsNullOrWhiteSpace(this.menuOption)){
                    throw new IsnullException();
                }
                else if (!char.IsDigit(this.menuOption[0])){
                    throw new IsNotAIntegerException();
                }
                else if (char.IsDigit(this.menuOption[0]) && int.Parse(this.menuOption) > 9){
                    throw new InvalidOptionException(this.menuOption);
                }
                else {
                    Console.WriteLine($"The chosed option were {this.menuOption} how?");

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

            switch (Convert.ToInt32(this.menuOption)){
                case 1:
                    RegisterBandView registerBandView = new RegisterBandView();
                    
                    registerBandView.main();
                    break;
                case 2:
                    Console.WriteLine("Unvailable Now");
                    break;
                case 3:
                    Console.WriteLine("Unvailable Now");
                    break;
                case 4:
                    Console.WriteLine("Unvailable Now");
                    break;
                case 5:
                    Console.WriteLine("Unvailable Now");
                    break;
                case 6:
                    Console.WriteLine("Unvailable Now");
                    break;
                case 7:
                    Console.WriteLine("Unvailable Now");
                    break;
                case 8:
                    Console.WriteLine("Unvailable Now");
                    break;
                case 9:
                    Console.WriteLine("Bye");
                    break;
                default:
                    Console.WriteLine("Wrong shoice");
                    break;
            }
        }
    }
}