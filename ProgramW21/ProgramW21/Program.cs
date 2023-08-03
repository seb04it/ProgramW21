using ProgramW21;

var employee = new Employee("S", "M");

employee.AddGrade(5);
employee.AddGrade(50);
employee.AddGrade(35);

var statistics = employee.GetStatistics();
Console.WriteLine($"Sum: {statistics.Sum}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Averge: {statistics.Average:N2}");