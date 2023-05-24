using System;

namespace GuessTheNumber
{
    public class Controller
    {
        private Model model;
        private View view;

        public Controller(Model model, View view)
        {
            this.model = model;
            this.view = view;
        }

        public void PlayGame()
        {
            view.DisplayWelcomeMessage();
            model.StartGame();

            bool guessedCorrectly = false;

            while (!guessedCorrectly)
            {
                int guess = view.GetGuessFromUser();
                guessedCorrectly = model.MakeGuess(guess);

                if (guessedCorrectly)
                {
                    int attempts = model.GetAttempts();
                    view.DisplaySuccessMessage(attempts);
                }
                else
                {
                    view.DisplayTryAgainMessage();
                }
            }

            view.DisplayThankYouMessage();
        }
    }
}
