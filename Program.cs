using System.Reflection.Metadata.Ecma335;

namespace BasicUnderstadng
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("please enter something: ");
            string? nameInput = Console.ReadLine();
            string Name = nameInput ?? string.Empty;
            Console.WriteLine("You entered: " + Name);
            Console.Write("please Enter a Numbers: ");
            int Nummber = Convert.ToInt32(Console.ReadLine());
            int Nummber1 = Convert.ToInt32(Console.ReadLine());
         
            int Sum = Nummber + Nummber1;
            Console.WriteLine($"The Sum is:{Sum} ");
            string FirstName = "John";
            Console.WriteLine($"Hello, {FirstName}!");


            Console.WriteLine("please Enter a Key");
            int v1 =Console.Read();
            Console.WriteLine($"The Key is :{v1}");

            Console.WriteLine("please Anothwe Enter a Key");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine($"The Key is :{keyInfo.Key}, {keyInfo.KeyChar} ASCII {(int)keyInfo.KeyChar}");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("This is a colored text");
            Console.Title= "My Console Application";
            Console.WriteLine($"The Console Title is :{Console.Title}");
        }
    }
}
