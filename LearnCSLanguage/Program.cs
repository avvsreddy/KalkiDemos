namespace LearnCSLanguage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept 2 numbers from the user, find the sum and print their sum 
            // step 1: accept 2 numbers from the user
            int num1, num2, sum;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32( Console.ReadLine());

            // step 2: find the sum of the 2 numbers
            Console.WriteLine("Enter second number: ");
            num2 = int.Parse( Console.ReadLine());
            // step 3: print the sum of the 2 numbers
            sum = num1 + num2;
            Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
        }
    }
}
