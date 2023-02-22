namespace Mindfulness
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserInterface ui = new UserInterface();

            string input = ui.GetMenuInput();

            while (input != "4")
            {
                Activity activity = ui.DetermineActivity(input);

                activity.DoWelcome();
                activity.Start();
                activity.Complete();

                input = ui.GetMenuInput();
            }

        }
    }
}