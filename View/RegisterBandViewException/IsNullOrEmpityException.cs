namespace ScreenSound.view.RegisterBandViewException{
    internal class IsNullOrEmptyException:Exception{
        public IsNullOrEmptyException(){
            
            this.ClearTheCurrentLine();
            
            Console.WriteLine("Error, the name band cannot be null!");

            Thread.Sleep(1100);

            this.ClearTheCurrentLine();
        }

        private void ClearTheCurrentLine(){ // Will clear the current writeline

            Console.SetCursorPosition(0, Console.CursorTop - 1);

            Console.WriteLine(new string(' ', Console.WindowWidth));

            Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}