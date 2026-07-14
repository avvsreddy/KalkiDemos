namespace DynamicCollectionsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // store n number of ints and find the sum
           //IntDynamicArray array = new IntDynamicArray();

            List<int> intArray = new List<int>();

            DynamicArray<string> array = new DynamicArray<string>();

            DynamicArray<double> arry1 = new DynamicArray<double>();
            arry1.Add(10.45);


            array.Add("1");
            array.Add("2");
            array.Add("3");
            array.Add("4");
            array.Add("5");
            array.Add("6");
            array.Add("7");
            array.Add("8");
            array.Add("9");
            array.Add("10");
            array.Add("11");
            array.Add("12");
            array.Add("13");
            array.Add("14");
            array.Add("15");
            array.Add("16");
            array.Add("17");
            array.Add("18");
            array.Add("19");
            array.Add("20");
            array.Add("21");
            array.Add("22");

            for (int i = 0; i < array.Length(); i++)
            {
                Console.WriteLine(array.Get(i));
            }


        }
    }

    // backend dev
    class DynamicArray<idontknow> 
    {
        private idontknow[] data = new idontknow[10];
        private int index = 0;
        public void Add(idontknow value) 
        {

            if (index < data.Length) // space is available
            {
                data[index++] = value;
            } 
            else 
            {

                idontknow[] temp = new idontknow[data.Length * 2];
                data.CopyTo(temp, 0);
                data = temp;
                data[index] = value;
            }
         
        }

        public idontknow Get(int i)
        { 
            return data[i]; 
        }

        public int Length()
        {
            return index + 1;
        }

    }


    
}
