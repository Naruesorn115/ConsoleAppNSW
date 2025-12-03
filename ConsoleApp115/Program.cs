using System;

class Program
{
    static void Main()
    {
        
        Console.Write("Please enter your weight in kilograms: => ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Please enter your height in centimeters: => ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double height = heightCm / 100;

        double bmi = weight / (height * height);

        Console.WriteLine($"\nYour BMI is: {bmi:0.00}");

        string category;

        if (bmi < 18.5)
            category = "Underweight";
        else if (bmi < 25)
            category = "Normal weight";
        else if (bmi < 30)
            category = "Overweight";
        else
            category = "Obesity";

        Console.WriteLine("Category: " + category);
    }
}

