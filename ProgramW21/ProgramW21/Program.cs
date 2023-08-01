using ProgramW21;

Employee employee0 = new Employee("Seba", "M", 18);
Employee employee1 = new Employee("KSWN", "WW", 15);
Employee employee2 = new Employee("83102317", "123912371", 88959);

employee0.AddGrade(10);
employee0.AddGrade(10);
employee0.AddGrade(10);
employee0.AddGrade(10);
employee0.AddGrade(10);

employee1.AddGrade(7);
employee1.AddGrade(7);
employee1.AddGrade(7);
employee1.AddGrade(7);
employee1.AddGrade(7);

employee2.AddGrade(2);
employee2.AddGrade(2);
employee2.AddGrade(2);
employee2.AddGrade(2);
employee2.AddGrade(2);

List<Employee> employees = new List<Employee>()
{
    employee0, employee1, employee2
};

int highScore = -1;
Employee employeeWithHighScore = null;

foreach(var employee in employees)
{
    if(employee.Score > highScore)
    {
        highScore = employee.Score;
        employeeWithHighScore = employee;
    }
}
Console.WriteLine("Pracownik z najlepszym wynikiem to: "
    + employeeWithHighScore.Name + ", "
    + employeeWithHighScore.Surname + ", "
    + employeeWithHighScore.Age + ". "
    + "Z wynikiem: "
    + employeeWithHighScore.Score);