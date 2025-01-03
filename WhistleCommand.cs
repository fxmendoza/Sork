public class WhistleCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "whistle";

        public CommandResult Execute() 
        {
            Console.WriteLine("You whistle while you work!");
            return new CommandResult {RequestExit = false, IsHandled = true};
    }
}