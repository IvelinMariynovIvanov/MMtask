using System;
using System.Collections.Generic;
using System.Text;

namespace MM
{
    public static class ValidateUserInput
    {
        public static bool ValidateInput(string input, out int starsForLetter)
        {
            try
            {
                starsForLetter = int.Parse(input);

                if (starsForLetter < 2 || starsForLetter > 10000)
                {
                    Console.WriteLine("Enter a number in interval 2 < N < 10 000");
                    return false;
                }

                if (starsForLetter % 2 == 0)
                {
                    Console.WriteLine("Enter an odd number");
                    return false;
                }

                if (starsForLetter % 2 == 1)
                    return true;

                return false;
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{input}'");
            
                starsForLetter = 0;
                return false;

            }
        }
    }
}
