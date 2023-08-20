﻿namespace ProgramW21
{
    public abstract class EmployeeBase
    {
        public EmployeeBase(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(char grade);

        public abstract Statistics GetStatisticsForeach();
    }
}
