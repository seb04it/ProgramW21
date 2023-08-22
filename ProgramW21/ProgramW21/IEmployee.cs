using static ProgramW21.EmployeeBase;

namespace ProgramW21
{
    public interface IEmployee
    {
        event GradeAddedDelegate GradeAdded;

        string Name { get; }
        string Surname { get; }

        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(char grade);
        void AddGrade(int grade);
        void AddGrade(long grade);
        void AddGrade(double grade);

        Statistics GetStatisticsForeach();
    }
}