using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Luciana Puerta", "C#");
        Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("Kaleb Sharpe", "Fractions", "Section 7.3", "5.25");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("Joseph Albert", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}