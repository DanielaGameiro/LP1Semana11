namespace GuessTheNumber
{
    public class Program
    {
        private static void Main()
        {
            Model model = new Model();
            View view = new View();
            Controller controller = new Controller(model, view);
            controller.PlayGame();
        }
    }
}
