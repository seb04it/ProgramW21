﻿using ProgramW21;

Console.WriteLine("Witaj w programie do oceny pracowników!");
Console.WriteLine("===============================================");
Console.WriteLine();

var employee = new EmployeeInFile("S", "M");
employee.GradeAdded += Employee_GradeAdded;

void Employee_GradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Grade added");
}


while (true)
{
    Console.Write("Podaj ocenę pracownika: ");
    var input = Console.ReadLine();
    if (input == "quit")
    {
        Console.WriteLine();
        Console.WriteLine("Dziękuję za skorzystanie z programu, oto wyniki: ");
        break;
    }

    try
    {
        employee.AddGrade(input);
        employee.GetStatisticsForeach();
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Exception cought: {exception.Message}");
    }
}

var statistics = employee.GetStatisticsForeach();
Console.WriteLine($"Sum: {statistics.Sum}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Averge: {statistics.Average:N2}");
Console.WriteLine($"Average Grade: {statistics.AverageGrade}");