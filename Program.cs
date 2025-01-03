// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        ICommand lol = new LaughCommand();
        ICommand dance = new DanceCommand();
        ICommand sing = new SingCommand();
        ICommand whistle = new WhistleCommand();
        ICommand exit = new ExitCommand();
        List<ICommand> commands = new List<ICommand> {lol, dance, sing, whistle, exit};

        do
        {
            Console.Write(" > ");
            string input = Console.ReadLine();
            input = input.ToLower();
            input = input.Trim();

            var result = new CommandResult() {RequestExit = false, IsHandled = false};
            var handled = false;
            foreach (var command in commands)
            {
                if (command.Handles(input)) 
                { 
                    handled = true;
                    result = command.Execute();
                    if (result.RequestExit) { break; }
                }
            }
            if (!handled) {Console.WriteLine("Unknown command");} 
            if (result.RequestExit) { break; }

        } while (true);
    }
}

public interface ICommand
{
    bool Handles(string userInput);

    CommandResult Execute();
}

public class ExitCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "exit";

    public CommandResult Execute() => new CommandResult {RequestExit = true, IsHandled = true};
}

public class CommandResult
{
    public bool RequestExit {get; set;}

    public bool IsHandled {get; set;}
}

public class DanceCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "dance";

    public CommandResult Execute()
    {
        Console.WriteLine("You are a dancing machine!");
        return new CommandResult {RequestExit = false, IsHandled = true};
    }
}

public class SingCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "sing";

    public CommandResult Execute() 
    {
        Console.WriteLine("You are a singing fool!");
        return new CommandResult {RequestExit = false, IsHandled = true};
    }
}

public class WhistleCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "whistle";


        public CommandResult Execute() 
        {
            Console.WriteLine("You whistle while you work!");
            return new CommandResult {RequestExit = false, IsHandled = true};
    }
}

public class LaughCommand : ICommand
{
    public bool Handles(string userInput) => userInput == "lol";

    public CommandResult Execute()
    {
        Console.WriteLine("You laugh out loud!");
        return new CommandResult {RequestExit = false, IsHandled = true};
    }
}