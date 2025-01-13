namespace Sork.Commands;
using Sork.World;

public class LookCommand : BaseCommand
{
    private readonly UserInputOutput io;

    public LookCommand(UserInputOutput io)
    {
        this.io = io;
    }

    public override bool Handles(string userInput)
    {
        return GetCommandFromInput(userInput) == "look" && GetParametersFromInput(userInput).Length == 0;
    }

    public override CommandResult Execute(string userInput, GameState gameState)
    {
        var currentLocation = gameState.Player.Location;
        
        io.WriteMessageLine($"\nYou are in the {currentLocation.Name}");        
        io.WriteMessageLine(currentLocation.Description);        
        io.WriteMessageLine("\nExits:");
        foreach (var exit in currentLocation.Exits)
        {
            io.WriteMessageLine($"- {exit.Key}");
        }

        return new CommandResult { RequestExit = false, IsHandled = true };
    }
}