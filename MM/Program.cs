using System;

namespace MM
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            bool isInputValid = false;
            int starsForLetter = 0;

            isInputValid = ValidateUserInput.ValidateInput(input, out starsForLetter);

            while (isInputValid == false)
            {
                input = Console.ReadLine();

                isInputValid = ValidateUserInput.ValidateInput(input, out starsForLetter);
            }

            if (isInputValid)
            {
                
                IPrintable printLetter = new PrintLetter(starsForLetter);

                printLetter.PrintLogo();
               
            }
                   
        }
        
    }
}
