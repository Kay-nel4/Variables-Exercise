namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {   Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, Let's Have some Fun!");
            
         Console.WriteLine("Please enter a Color.");
         string color = Console.ReadLine();
         
         Console.WriteLine("Please enter a Number.");
         double number = double.Parse (Console.ReadLine());
         
         Console.WriteLine("Please enter a Letter");
         char letter = char.Parse (Console.ReadLine());
         
         Console.WriteLine($"Please enter a profession.");
         string profession = Console.ReadLine();
         
         
         Console.WriteLine($"The silly {color} cat has {number} tails! His name will start with a {letter} and he is an excellent {profession}!");
         Console.WriteLine("Let's name Him!");
         string kittyName = Console.ReadLine();
         
         Console.WriteLine($"{kittyName}, it is... Hello {kittyName}! Nice to meet you!");
         Console.ReadLine();
         
         Console.WriteLine("Please enter any number between 2 and 1000.");
         decimal percent = decimal.Parse(Console.ReadLine());
         
         Console.WriteLine($"Thanks {percent}% for playing!");

        }
    }
}
