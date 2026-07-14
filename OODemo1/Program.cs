namespace OODemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee e1 = new Employee();
            //e1.EmpNo = 1;
            //e1.EmpName = "Test";
            //e1.Salary = 10000;

            var e2 = new { EmpNo = 111, EmpName = "Ramesh", Salary=650000 }; // Anonymous Types

            //e2.EmpNo = 123;

            var e3 = new  { EmpNo= 123 }; // object initalization syntax

            var e4 = new  { EmpNo = 123, EmpName ="Satish" };

        }
    }

    public class Product
    {
        // State
        // Fields
        //private int productId1;
        //private int productid2;
        //private int backingfield3423423423;

        public string Category { get; set; }

        public int ProductId // Automatic Properties
        {
            get; //{  return productId; }
            set; //{  productId = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //public void SetName(string name)
        //{
        //    this.name = name;
        //}
        //public string GetName()
        //{
        //    return name;
        //}

        private double price;


        public void SetPrice(double p)
        {
            if (p < 100)
            {
                price = 100;
            }
            else
            {
                price = p;
            }

        }
        public double GetPrice() 
        {
            return price;
        }
    }


    //class Employee
    //{
    //    public int EmpNo { get; set; }
    //    public string EmpName { get; set; }
    //    public int Salary { get; set; }

    //    //public Employee()
    //    //{
            
    //    //}
    //    //public Employee(int no, string name, int sal)
    //    //{
    //    //    this.EmpNo = no;
    //    //    this.EmpName = name;
    //    //    this.Salary = sal;
    //    //}

    //    //public Employee(int empno)
    //    //{
    //    //    this.EmpNo = empno;
    //    //}

    //    //public Employee(int no, string name)
    //    //{
    //    //    this.EmpNo = no;
    //    //    this.EmpName= name;
    //    //}
    //}
}
