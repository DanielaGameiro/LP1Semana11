using System;

namespace GuessTheNumber
{
    public class Model
    {
        private Random random;
        private int targetNumber;
        private int attempts;

        public Model()
        {
            random = new Random();
            attempts = 0;
        }

        public void StartGame()
        {
            targetNumber = random.Next(1, 101);
        }

        public bool MakeGuess(int guess)
        {
            attempts++;

            if (guess == targetNumber)
            {
                return true;
            }
            else if (guess < targetNumber)
            {
                Console.WriteLine("Too low! Try again.");
            }
            else
            {
                Console.WriteLine("Too high! Try again.");
            }

            return false;
        }

        public int GetAttempts()
        {
            return attempts;
        }
    }
}
