namespace ProgramW21
{
    public class Employee : Person
    {
        public List<float> grades = new List<float>();

        public Employee()
            :this("No name", "No surname")
        {

        }

        public Employee(string name)
            :this(name, "No Surname")
        {

        }

        public Employee(string name, string surname)
            :base(name, surname)
        {
            
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(grade.Length == 1)
            {
                char gradeChar = char.ToUpper(grade[0]);
                
                if (gradeChar >= 'A' && gradeChar <= 'E')
                {
                    this.AddGrade(gradeChar);
                    return;
                }
            }
            if(float.TryParse(grade, out float stringAsFloat))
            {
                this.AddGrade(stringAsFloat);
            }
            else
            {
                throw new Exception("Invalid type of string");
            }
        }

        public void AddGrade(char grade)
        {
            switch(grade)
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

        public void AddGrade(int grade)
        {
            var intAsFloat = (float)grade;
            this.AddGrade(intAsFloat);
        }
        public void AddGrade(long grade)
        {
            var longAsFloat = (float)grade;
            this.AddGrade(longAsFloat);
        }
        public void AddGrade(double grade)
        {
            var doubleAsFloat = (float)grade;
            this.AddGrade(doubleAsFloat);
        }

        public Statistics GetStatisticsForeach()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            statistics.Sum = this.grades.Sum();

            for (var counter = 0; counter < this.grades.Count; counter++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[counter]);
                statistics.Min = Math.Min(statistics.Min, this.grades[counter]);
                statistics.Average += this.grades[counter];
            }

            statistics.Average /= this.grades.Count;
            
            switch (statistics.Average)
            {
                case var Average when Average >= 80:
                    statistics.AverageGrade = 'A';
                    break;
                case var Average when Average >= 60:
                    statistics.AverageGrade = 'B';
                    break;
                case var Average when Average >= 40:
                    statistics.AverageGrade = 'C';
                    break;
                case var Average when Average >= 20:
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
