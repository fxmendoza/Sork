// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        do
        {
            Console.Write(" > ");
            string input = Console.ReadLine();
            input = input.ToLower();
            input = input.Trim();
            if (input == "lol") {Console.WriteLine("You laugh out loud!");}
            if (input == "dance") {Console.WriteLine("You are a dancing machine!");}
            if (input == "sing") {Console.WriteLine("You are a singing fool!");}
            if (input == "whistle") {Console.WriteLine("You whistle while you work!");}
            else if (input == "exit") {break;}            
            else {Console.WriteLine("Unknown command");}
        } while (true);
    }
}
