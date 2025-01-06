namespace Sork.Commands;

public class WhistleCommand : ICommand
{
    private readonly UserInputOutput io;

    public WhistleCommand(UserInputOutput io)
    {
        this.io = io;
    }

    public bool Handles(string userInput) => userInput == "whistle";

        public CommandResult Execute() 
        {
            Console.WriteLine("You whistle while you work!");
            return new CommandResult {RequestExit = false, IsHandled = true};
    }
}