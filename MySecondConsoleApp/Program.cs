namespace MySecondConsoleApp
{
    internal class Program // UI
    {
        static void Main(string[] args) // SRP - UI
        {
            // accept two numbers, find the max then display
            int fno;
            int sno;
            int max;
            Console.WriteLine("Enter First Number: ");
            fno = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            sno = int.Parse(Console.ReadLine());
            max = MyMathLibrary. SimpleMath. FindMax(fno, sno); // Backend
            Console.WriteLine($"The maximum of {fno} and {sno} is {max}");
        }

    }
}
