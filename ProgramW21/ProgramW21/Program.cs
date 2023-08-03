using ProgramW21;

var employee = new Employee("S", "M");

employee.AddGrade(5);
employee.AddGrade(50);
employee.AddGrade(33);

var statistics = employee.GetStatistics();
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Averge: {statistics.Average:N2}");