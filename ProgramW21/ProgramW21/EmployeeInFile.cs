namespace ProgramW21
{
    public class EmployeeInFile : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        public const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);

                    if(GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
                else
                {
                    throw new Exception("invalid grade value");
                }
            }
        }
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float grade0))
            {
                this.AddGrade(grade0);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20); ;
                    break;
                default:
                    throw new Exception("Invalid letter");
            }
        }

        public override void AddGrade(int grade)
        {
            var intAsFloat = (float)grade;
            this.AddGrade(intAsFloat);
        }

        public override void AddGrade(long grade)
        {
            var longAsFloat = (float)grade;
            this.AddGrade(longAsFloat);
        }


        public override void AddGrade(double grade)
        {
            var doubleAsFloat = (float)grade;
            this.AddGrade(doubleAsFloat);
        }

        public override Statistics GetStatisticsForeach()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;

            foreach (var grade in grades)
            {
                if (grade >= 0)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }

            }
            statistics.Average /= grades.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageGrade = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageGrade = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageGrade = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageGrade = 'D';
                    break;
                default:
                    statistics.AverageGrade = 'E';
                    break;

            }
            return statistics;
        }
    }
}
