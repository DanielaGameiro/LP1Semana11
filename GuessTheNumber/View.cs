using System;

namespace GuessTheNumber
{
    public class View
    {
        public void DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public int GetGuessFromUser()
        {
            Console.Write("Take a guess: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        public void DisplaySuccessMessage(int attempts)
        {
            Console.WriteLine("Congratulations! You guessed the number correctly!");
            Console.WriteLine("Number of attempts: " + attempts);
        }

        public void DisplayTryAgainMessage()
        {
            Console.WriteLine("Try again.");
        }

        public void DisplayThankYouMessage()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}
