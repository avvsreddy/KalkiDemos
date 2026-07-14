namespace ExceptionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exception Handling

            // accept two ints find sum display and repeat
            // Business Rules
            // non-zero, positive and even numbers only
            while (true)
            {
                try
                {
                    int fno, sno, sum;
                    Console.WriteLine("Enter First Number: ");
                    fno = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number: ");
                    sno = int.Parse(Console.ReadLine());
                    SimpleCalculator sc = new SimpleCalculator();
                    sum = sc.FindSum(fno, sno);

                    Console.WriteLine($"The sum of {fno} and {sno} is {sum}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter numbers only...");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("Please enter small numbers only...");
                }

                catch (NegativeInputException ex)
                {
                    Console.WriteLine(ex.Message);
                }                //catch (Exception ex) // Catch all Block
                //{
                //    Console.WriteLine(ex.Message);
                //}

            }

        }
    }
    // backend code
    // this class is used for calculating 
    class SimpleCalculator
    {
        // this method will find sum of two numbers

        /// <summary>
        /// this method will find sum of two numbers
        /// </summary>
        /// <param name="fno"></param>
        /// <param name="sno"></param>
        /// <returns>sum of two numbers</returns>
        /// <exception cref="NegativeInputException"></exception>
        public int FindSum(int fno, int sno) 
        {
            if(fno < 0 || sno < 0)
            {
                throw new NegativeInputException("Please enter positive numbers only");
            }

            return fno + sno;
        }
    }

    // custom exception

    class NegativeInputException :ApplicationException
    {
        public NegativeInputException(string msg) : base(msg)
        {
            //Message = msg;
        }
    }
}
