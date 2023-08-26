namespace ProgramW21
{
    public abstract class EmployeeBase : IEmployee
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public virtual void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float stringAsFloat))
            {
                this.AddGrade(stringAsFloat);
            }
            else if (char.TryParse(grade, out char charAsFloat))
            {
                this.AddGrade(charAsFloat);
            }
            else
            {
                throw new Exception("Invalid type of string");
            }
        }

        public abstract void AddGrade(float grade);

        public virtual void AddGrade(int grade)
        {
            var intAsFloat = (float)grade;
            this.AddGrade(intAsFloat);
        }

        public virtual void AddGrade(long grade)
        {
            var longAsFloat = (float)grade;
            this.AddGrade(longAsFloat);
        }

        public virtual void AddGrade(double grade)
        {
            var doubleAsFloat = (float)grade;
            this.AddGrade(doubleAsFloat);
        }

        public virtual void AddGrade(char grade)
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
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Invalid char");
            }
        }

        public abstract Statistics GetStatisticsForeach();
    }
}
