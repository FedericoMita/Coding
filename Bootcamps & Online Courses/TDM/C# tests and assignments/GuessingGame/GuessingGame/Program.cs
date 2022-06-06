using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "sharp"; //this could be... any word, but since we are coding in C#...
            string guess = ""; //this value will be enstablished by the user
            int guessCount = 0; //how many time the use has made guesses
            int guessLimit = 2; //This is the maximum of tries
            bool outOfGuesses = false; //when this gets true, the game is lost

            while(guess != secretWord && !outOfGuesses)
            {
                Console.Write("Guess what word am I thinking of. Hint: it's something you can 'SEE'! Make your guess or type Q to quit the game: ");
                guess = Console.ReadLine();
                if (!guess.ToUpper().Equals("Q")) //this will escape the program
                {
                    if (guess.Length > 20) //this limits the number of char for the guess
                    {
                        Console.Write("Word is too long!");
                    }
                    else if (guess.Length <= 20 && guessCount < guessLimit)
                    {
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }
                    }
                else if (guess.ToUpper().Equals("Q"))
                    Environment.Exit(0);

            }
            if (outOfGuesses)
            {
                Console.Write("You Lose!");
                Environment.Exit(0);
            }
            else
            {
                Console.Write("You Win!");
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
