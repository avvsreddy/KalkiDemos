namespace CollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // accept 10 numbers from the user and store them in an array and find the sum of all the numbers in the array

            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter number {i+1}");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            // Find the sum
            int sum = numbers.Sum();
            int max = numbers.Max();
            int min = numbers.Min();
            double average = numbers.Average();

            //foreach (int i in numbers) 
            //{
            //    sum += i;
            //}

            Console.WriteLine($"The sum is {sum}");

            // create an array with initial values;

            int[] x1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] x2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] x3 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // 2d int ary[][]

            int[,] twoDArray = new int[2,5];
            twoDArray[1, 2] = 10;

            // Jagged array

            int[][] scores = new int[3][]; // no of rows is 3 but no of columns is not defined
            scores[0] = new int[3];
            scores[1] = new int[4];
            scores[2] = new int[20];

        }
    }
}
