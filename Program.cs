
using System;

// Create a class that contains our math operation.
public class MathOperations
{
    // Define a void method that accepts two integers.
    // Void means the method does not return a value.
    public void PerformOperation(int firstNumber, int secondNumber)
    {
        // Multiply the first integer by 2.
        int result = firstNumber * 2;

        // Display the result of the math operation.
        Console.WriteLine("Math result: " + result);

        // Display the second integer on the screen.
        Console.WriteLine("Second number: " + secondNumber);
    }
}

// Create the main Program class.
class Program
{
    // Main is the entry point of the console application.
    static void Main(string[] args)
    {
        // Instantiate the MathOperations class.
        MathOperations math = new MathOperations();

        // Call the method using two integer arguments.
        math.PerformOperation(5, 10);

        // Call the method using named parameters.
        math.PerformOperation(firstNumber: 8, secondNumber: 20);
    }
}
