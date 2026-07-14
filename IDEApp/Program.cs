namespace IDEApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CSharpLanguage cs = new CSharpLanguage();
            JavaLanguage java = new JavaLanguage();
            CLanguage c = new CLanguage();
            IDE ide = new IDE();
            ide.Languages.Add(cs);
            //ide.Languages.Add(java);
            ide.Languages.Add(c);
            //ide.CS = cs;
            //ide.Java = java;
            //ide.C = c;
            ide.DoWork();


        }
    }

    class IDE // OCP
    {
        //public CSharpLanguage CS { get; set; }
        //public JavaLanguage Java { get; set; }
        //public CLanguage C { get; set; }

        public List<ILanguage> Languages { get; set; } = new List<ILanguage>();


        public void DoWork() 
        {
            foreach (var language in Languages)
            {
                Console.WriteLine(language.GetName());
                Console.WriteLine(language.GetUnit());
                Console.WriteLine(language.GetParadigm());
                Console.WriteLine("----------------------");
            }

            //Console.WriteLine(Java.GetName());
            //Console.WriteLine(Java.GetUnit());
            //Console.WriteLine(Java.GetParadigm());
            //Console.WriteLine("----------------------");
            //Console.WriteLine(C.GetName());
            //Console.WriteLine(C.GetUnit());
            //Console.WriteLine(C.GetParadigm());
            //Console.WriteLine("----------------------");

        }
    }


    public interface ILanguage
    {
        string GetName();
        string GetUnit();
        string GetParadigm();
    }


    abstract public class OOLanguage : ILanguage
    {

        abstract public string GetName();
        //{
        //    return "Object Oriented Language";
        //}
        public string GetUnit()
        {
            return "Class";
        }
        public string GetParadigm()
        {
            return "Object-Oriented";
        }
    }

    class CSharpLanguage : OOLanguage
    {
        public override string GetName()
        {
            return "C# Language";
        }

       
        //public string GetUnit()
        //{
        //    return "Class";
        //}
        //public string GetParadigm()
        //{
        //    return "Object-Oriented";
        //}
    }

    class JavaLanguage : OOLanguage
    {
        public override string GetName()
        {
            return "Java Language";
        }
        //public string GetUnit()
        //{
        //    return "Class";
        //}
        //public string GetParadigm()
        //{
        //    return "Object-Oriented";
        //}
    }

    class CLanguage : ILanguage
    {
        public string GetName()
        {
            return "C Language";
        }
        public string GetUnit()
        {
            return "Function";
        }
        public string GetParadigm()
        {
            return "Procedure-Oriented";
        }
    }
}
