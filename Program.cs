using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
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
            int v1 = Console.Read();
            Console.WriteLine($"The Key is :{v1}");

            Console.WriteLine("please Anothwe Enter a Key");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine($"The Key is :{keyInfo.Key}, {keyInfo.KeyChar} ASCII {(int)keyInfo.KeyChar}");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("This is a colored text");
            Console.Title = "My Console Application";
            Console.WriteLine($"The Console Title is :{Console.Title}");


            Console.WriteLine("\n please enter Student Name");
            string StudentName = Console.ReadLine();
            Console.WriteLine("please Enter Student Address");
            string Address = Console.ReadLine();
            Console.WriteLine("please Enter Student Age");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please Enter your Grade");
            char Gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"Student Name is :{StudentName}");
            Console.WriteLine($"Student Address{Address}");
            Console.WriteLine($"Age:{Age}");
            Console.WriteLine($"Grade:{Gender}");


            Console.WriteLine("please Enter Name");
            string MyName = Console.ReadLine();

            for (int i = 0; i < MyName.Length; i++)
            {
                Console.WriteLine("\n", MyName[i]);
            }
            string FullName = "Dhruvil";

            var nums = FullName.Length * sizeof(char);
            Console.WriteLine($"the size of the Name={FullName} ,{nums})");


            Console.WriteLine("using IEnumerble");

            IEnumerable<int> numbers = new List<int>() { 97, 56, 78, 45, 78, 45, 46, 46, 18, 46 };
            foreach (var number in numbers)
            {
                Console.WriteLine($"Number: {number}");
            }
        }
    }
}
