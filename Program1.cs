using System;

public class Employee
{
    private bool isPresent;

    public void MarkAttendance()
    {
        Random random = new Random();
        isPresent = random.Next(0, 2) == 1;
    }

    public string GetAttendanceStatus()
    {
        return isPresent ? "Present" : "Absent";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.MarkAttendance();

        string attendanceStatus = employee.GetAttendanceStatus();
        Console.WriteLine("Employee is " + attendanceStatus);
    }
}
