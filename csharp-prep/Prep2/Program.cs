using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Write("What is your grade percentage? ");
        string stringGrade = Console.ReadLine();
        float grade = float.Parse(stringGrade);

        string letter = "";
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string passFail = "";
        if (grade >= 70)
        {
            passFail = "Congratulations! You have passed the class!";
        }
        else
        {
            passFail = "So close! You'll get it next time tiger!";
        }

        Console.WriteLine($"Your letter grade: {letter} \n{passFail}");
    }
}