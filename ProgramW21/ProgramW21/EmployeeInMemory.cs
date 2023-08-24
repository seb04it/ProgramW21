namespace ProgramW21
{
    public class EmployeeInMemory : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;

        public List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public override void AddGrade(string grade)
        {
            char gradeChar = char.ToUpper(grade[0]);
            if (gradeChar >= 'A' && gradeChar <= 'E')
            {
                this.AddGrade(gradeChar);
                GradeAdded?.Invoke(this, EventArgs.Empty);
            }
            else if (float.TryParse(grade, out float stringAsFloat))
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
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                default:
                    throw new Exception("Invalid char");
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
            var statistics = new Statistics();

            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
