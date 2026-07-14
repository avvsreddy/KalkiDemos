namespace TrainingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Orgranization org = new Orgranization();
            org.Name = "ABC Intitute";

            Trainer trainer = new Trainer();
            trainer.Org = org;

           Training training = new Training();
           training.TheTrainer = trainer;


            Trainee t1 = new();
            Trainee t2 = new();
            Trainee t3 = new();

            training.Trainees.Add(t1);
            training.Trainees.Add(t2);
            training.Trainees.Add(t3);

            Console.WriteLine(training.GetOrgName());


            Console.WriteLine(training.GetTreaineesCount());

            Console.WriteLine(training.GetTrainingDuration());
        }
    }

    class Orgranization
    {
        public string Name { get; set; }
    }
    class Trainer
    {
        //private Orgranization org = new Orgranization();
        public Orgranization Org { get; set; }

        public List<Trainee> Trainees { get; set; } = new List<Trainee>();

        public List<Training> Trainings { get; set; } = new List<Training>();
    }
    class Trainee
    {
        public Trainer TheTrainer { get; set; }
        public List<Training> Trainings { get; set; } = new List<Training>();

    }
    class Training
    {
        public Trainer TheTrainer { get; set; }
        public List<Trainee> Trainees { get; set; } = new List<Trainee>();
        public Course TheCourse { get; set; }

        public string GetOrgName() 
        {
            // return the org name
            return TheTrainer.Org.Name;
        }

        public int GetTreaineesCount()
        {
            return Trainees.Count;
        }

        public int GetTrainingDuration() 
        {
            int totalDuration = 0;
            // for each module in a course
            foreach (Module module in TheCourse.Modules)
            {
                // for each unit in a module
                foreach (Unit unit in module.Units)
                {
                    totalDuration += unit.DurationHrs;
                }
            }
            return totalDuration;
        }


    }
    class Course
    {
        public List<Training> Trainings { get; set; } = new List<Training>();
        public List<Module> Modules { get; set; } = new List<Module>();
    }
    class Module
    {
        public List<Unit> Units { get; set; } = new List<Unit>();
    }
    class Unit
    {
        public int DurationHrs { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
    }
    class Topic
    {

    }
}
