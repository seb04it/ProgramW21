using System.Diagnostics;

namespace ProgramW21
{
    public class Employee
    {
        public List<float> grades = new List<float>();

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float stringAsFloat))
            {
                this.AddGrade(stringAsFloat);
            }
            else
            {
                Console.WriteLine("Invalid type of string");
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

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsFor()
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
            return statistics;
        }

        public Statistics GetStatisticsDoWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            statistics.Sum = this.grades.Sum();
            var counter = 0;

            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[counter]);
                statistics.Min = Math.Min(statistics.Min, this.grades[counter]);
                statistics.Average += this.grades[counter];
                counter++;
            } while (counter < this.grades.Count);

            statistics.Average /= this.grades.Count;
            return statistics;
        }
        public Statistics GetStatisticsWhile()
        {
            var statistics = new Statistics();
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            statistics.Average = 0;
            statistics.Sum = this.grades.Sum();
            var counter = 0;

            while (counter < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[counter]);
                statistics.Min = Math.Min(statistics.Min, this.grades[counter]);
                statistics.Average += this.grades[counter];
                counter++;
            }

            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}
