using System;

class Program
{
    static void Main(string[] args)
    {
        // get input of grade
        Console.WriteLine("What is your grade percentage?");
        float gradePercentage = float.Parse(Console.ReadLine());
        
        // if statement determining what letter is equivalent to a percentage.
        string letterGrade = "A";
        string specificGrade = "";
        
        if (90 <= gradePercentage && gradePercentage <= 100)
        {
            letterGrade = "A";
        } 
        else if (80 <= gradePercentage && gradePercentage < 90)
        {
            letterGrade = "B";
        }
        else if (70 <= gradePercentage && gradePercentage < 80)
        {
            letterGrade = "C";
        }
        else if (60 <= gradePercentage && gradePercentage < 70)
        {
            letterGrade = "D";
        }
        else 
        {
            letterGrade = "F";
        }
        
        // determine what grade a student has and if it is a + or - grade. 
        if ((gradePercentage % 10) <= 3 && (gradePercentage % 10) > 0 && gradePercentage >= 60)
        {
            specificGrade = "-";
        }
        else if ((gradePercentage % 10) >= 7 && gradePercentage < 90 && gradePercentage >= 60)
        {
            specificGrade = "+";
        }
        else
        {
            specificGrade = "";
        }
        
        // print grade and or encouragement.
        Console.Write($"Letter Grade: {letterGrade}{specificGrade} ");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("You did not pass. Please try taking this class again for a better grade.");
        }

    }
}