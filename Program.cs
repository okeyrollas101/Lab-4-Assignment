using System;

namespace Lab_4_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This Program calculates the CGPA and CGPA percentage of a given student
           double cgpa = 0;
           double cgpaPercentage;
           double totalGrade = 0;
           Console.WriteLine("Welcome, Please Enter Your Name");
           string studentName = Console.ReadLine().ToUpper();
           Console.WriteLine($"Hello {studentName}, this is the calculation for your cgpa");
           Console.Write("Please Enter your first score: ");
           int firstScore = int.Parse(Console.ReadLine());
           Console.Write("Please Enter your second score: ");
           int secondScore = int.Parse(Console.ReadLine());
           Console.Write("Please Enter your third score: ");
           int thirdScore = int.Parse(Console.ReadLine());
           Console.Write("Please Enter your fourth score: ");
           int fourthScore = int.Parse(Console.ReadLine());
           Console.Write("Please Enter your fifth score: ");
           int fifthScore = int.Parse(Console.ReadLine());

           int[] grades = new int [5];
           grades[0] = firstScore / 10;
           grades[1] = secondScore / 10;
           grades[2] = thirdScore / 10;
           grades[3] = fourthScore / 10;
           grades[4] = fifthScore / 10;
           foreach (var score in grades)
           {
               totalGrade += score;
               cgpa = totalGrade/grades.Length; // which is 5.
           }

           cgpaPercentage = (cgpa * 9.5);
           Console.WriteLine($"Hello {studentName},your cgpa is: {cgpa}");
           Console.WriteLine($"{studentName} your percentage cgpa is:{cgpaPercentage.ToString("0.00")}%");
        }
    }
}
