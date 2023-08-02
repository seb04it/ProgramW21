namespace ProgramW21
{
    public class Employee
    {
        public List<int> score = new List<int>();

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public Employee(string name)
        {
            this.Name = name;
        }

        public int Score
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddGrade(int grade)
        {
            this.score.Add(grade);
        }

    }
}
