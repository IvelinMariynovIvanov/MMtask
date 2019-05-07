using System;
using System.Collections.Generic;
using System.Text;

namespace MM
{
    public class PrintLetter : IPrintable
    {

        private  char Space { get; set; }
        private  char Letter { get; set; }
        private  int StarsCount { get; set; }
        private  int SpacesCount { get; set; }
        private  int StartIndex { get; set; }
        private  int StarsForLetter { get; set; }

        public PrintLetter(int starsForLetter)
        {
            Space = '-';
            Letter = '*';
            StarsCount = starsForLetter;
            SpacesCount = starsForLetter;
            StartIndex = (starsForLetter + 1)/2 ;
            StarsForLetter = starsForLetter;
        }


        public void PrintLogo()
        {
            PrintTopHalf();

            PrintBottomHalf();
        }

        private void PrintTopHalf()
        {
         
            for (int i = 0; i < StartIndex; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    PrintLeadingSpaces(StarsForLetter, Space, i);

                    PrintLetters(Letter, StarsCount);

                    PrintEndSpaces(Space, SpacesCount);

                    PrintLetters(Letter, StarsCount);

                    PrintLeadingSpaces(StarsForLetter, Space, i);
                }


                StarsCount += 2;
                SpacesCount -= 2;

                if (StarsCount > 2 * StarsForLetter)
                {
                    StarsCount = 2 * StarsForLetter - 1;
                }

                if (SpacesCount < 0)
                {
                    SpacesCount = 1;
                }

                Console.WriteLine();

            }
        }

        private void PrintBottomHalf()
        {
            for (int i = StartIndex; i < StarsForLetter; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    PrintLeadingSpaces(StarsForLetter, Space, i);

                    PrintAlwaysNStars(StarsForLetter, Letter);

                    PrintEndSpaces(Space, SpacesCount);

                    PrintLetters(Letter, StarsCount);

                    PrintEndSpaces(Space, SpacesCount);

                    PrintAlwaysNStars(StarsForLetter, Letter);

                    PrintLeadingSpaces(StarsForLetter, Space, i);
                }



                StarsCount -= 2;
                SpacesCount += 2;

                Console.WriteLine();
            }
        }


        private void PrintAlwaysNStars(int n, char letter)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(letter);
            }
        }

        private void PrintEndSpaces(char space, int spacenumber)
        {
            for (int i = 0; i < spacenumber; i++)
            {
                Console.Write(space);
            }
        }

        private void PrintLetters(char letter, int starNumber)
        {
            for (int i = 0; i < starNumber; i++)
            {
                Console.Write(letter);
            }
        }

        private void PrintLeadingSpaces(int n, char space, int i)
        {
            for (int j = n - i; j > 0; j--)
            {
                Console.Write(space);
            }
        }
    }
}
