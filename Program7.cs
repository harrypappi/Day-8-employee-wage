using System;

class Employee
{
    // Class variables
    private static double baseHourlyRate = 10.0;
    private static double overtimeRate = 1.5;

    // Class method to compute employee wage
    public static double ComputeWage(double hoursWorked)
    {
        double wage = 0.0;

        if (hoursWorked <= 40)
        {
            wage = hoursWorked * baseHourlyRate;
        }
        else
        {
            double overtimeHours = hoursWorked - 40;
            wage = (40 * baseHourlyRate) + (overtimeHours * baseHourlyRate * overtimeRate);
        }

        return wage;
    }
}

class Program
{
    static void Main(string[] args)
    {
        double hoursWorked = 45;
        double wage = Employee.ComputeWage(hoursWorked);

        Console.WriteLine($"Employee wage for {hoursWorked} hours: ${wage}");
    }
}
