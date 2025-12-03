using System;

class Program
{
    static void Main()
    {
        double weight;
        double heightCm;

        while (true)
        {
            Console.Write("Please enter your weight in kilograms: => ");

            if (double.TryParse(Console.ReadLine(), out weight) && weight > 0 && weight < 500)
            {
                break; 
            }
            else
            {
                Console.WriteLine("Invalid weight! Please enter a valid number (1 - 500).");
            }
        }

        while (true)
        {
            Console.Write("Please enter your height in centimeters: => ");

            if (double.TryParse(Console.ReadLine(), out heightCm) && heightCm > 0 && heightCm < 300)
            {
                break;  
            }
            else
            {
                Console.WriteLine("Invalid height! Please enter a valid number (1 - 300).");
            }
        }
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

