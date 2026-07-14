namespace DynamicCollectionsDemo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dynamic Collections in .Net

            List<int> ints = new List<int>(); // declare the collection
            // add data
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);

            // read data

            int data = ints[0];
            int sum = ints.Sum();

            ints.Sort();
            
            // LIFO
            Stack<int> stack = new Stack<int>();
            // add
            stack.Push(10);
            stack.Push(20);

            // only read

            int x = stack.Peek();

            // read and remove
            x = stack.Pop();

            // FIFO
            Queue<int> q = new Queue<int>();
            // add data
            q.Enqueue(10);
            q.Enqueue(20);

            // only read
            x = q.Peek();

            // read and remove
            x = q.Dequeue();


            Dictionary<int,string> results = new Dictionary<int,string>();

            // add
            results.Add(111, "Pass");
            results.Add(222, "Fail");


            // read
            string result = results[111];

            // Hashset

            HashSet<int> set = new HashSet<int>();
            // add
            set.Add(1);
            set.Add(2);
            set.Add(2);

            // read
            x = set.ElementAt(1);

            //System.Collections.Generic.

            //System.Collections.Concurrent.ConcurrentQueue


        }
    }
}
