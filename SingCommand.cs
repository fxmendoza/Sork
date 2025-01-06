namespace Sork;

public class SingCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "sing";

    public CommandResult Execute() 
    {
        Console.WriteLine("You are a singing fool!");
        return new CommandResult {RequestExit = false, IsHandled = true};
    }
}