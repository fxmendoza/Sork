namespace Sork.Commands;
using Sork.World;

public class WhistleCommand : BaseCommand
{
    private readonly UserInputOutput io;

    public WhistleCommand(UserInputOutput io)
    {
        this.io = io;
    }

    public override bool Handles(string userInput) => GetCommandFromInput(userInput) == "whistle";

    public override CommandResult Execute(string userInput, GameState gameState) 
        {
            Console.WriteLine("You whistle while you work!");
            return new CommandResult {RequestExit = false, IsHandled = true};
    }
}