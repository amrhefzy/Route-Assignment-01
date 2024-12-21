using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Route_Assignment_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //// 1. Enter a number and print it.
            //Console.Write("Enter a number: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"You entered: {number}");
            //Console.WriteLine(); // For spacing

            //// 2. Convert a string to an integer (non-numeric characters).
            //string input = "123abc";
            //try
            //{
            //    int converted = Convert.ToInt32(input);
            //    Console.WriteLine($"Converted value: {converted}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("The string contains non-numeric characters and cannot be converted.");
            //}
            //Console.WriteLine(); // For spacing

            //// 3. Arithmetic operation with floating-point numbers.
            //float num1 = 10.5f;
            //float num2 = 2.3f;
            //float result = num1 * num2;
            //Console.WriteLine($"Result: {result}");
            //Console.WriteLine(); // For spacing

            //// 4. Extract a substring from a string.
            //string text = "Hello, world!";
            //string substring = text.Substring(7, 5); // Extracts "world"
            //Console.WriteLine($"Extracted substring: {substring}");
            //Console.WriteLine(); // For spacing

            //// 5. Value type assignment and modification.
            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine($"a = {a}, b = {b}"); // a remains unchanged
            //Console.WriteLine(); // For spacing



            //// 7. Combine two strings.
            //string str1 = "Hello";
            //string str2 = "World";
            //string combined = str1 + " " + str2;
            //Console.WriteLine(combined);
            //Console.WriteLine(); // For spacing

            //// 8. Simple interest calculation.
            //double principal = 1000, rate = 5, time = 2;
            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine($"Simple Interest: {interest}");
            //Console.WriteLine(); // For spacing

            //// 9. BMI calculation.
            //double weight = 70; // kg
            //double height = 1.75; // meters
            //double bmi = weight / (height * height);
            //Console.WriteLine($"BMI: {bmi}");
            //Console.WriteLine(); // For spacing

            // 10. Ternary operator for temperature check.
            int temperature = 25;
            string resultTernary = temperature < 10 ? "Just Cold" : temperature > 30 ? "Just Hot" : "Just Good";
            Console.WriteLine(resultTernary);
            Console.WriteLine(); // For spacing
        }
    }
}