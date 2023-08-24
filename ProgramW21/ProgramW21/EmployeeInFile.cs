namespace ProgramW21
{
    public class EmployeeInFile : EmployeeBase
    {

        public const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {

            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("invalid grade value");
            }

        }
        public override void AddGrade(string grade)
        {
            if (grade.Length == 1)
            {
                char gradeChar = char.ToUpper(grade[0]);
                if (gradeChar >= 'A' && gradeChar <= 'E')
                {
                    this.AddGrade(gradeChar);
                    return;
                }
            }
            if (float.TryParse(grade, out float stringAsFloat))
            {
                this.AddGrade(stringAsFloat);
            }
            else
            {
                throw new Exception("Invalid type of string");
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
                        if (!string.IsNullOrWhiteSpace(line))
                        {
                            try
                            {
                                var number = float.Parse(line);
                                grades.Add(number);
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine($"Invalid format in line: {line}");
                            }
                        }
                        line = reader.ReadLine();
                    }
                }
                if (grades.Count == 0)
                {
                    Console.WriteLine("The file is empty, add grades");
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
