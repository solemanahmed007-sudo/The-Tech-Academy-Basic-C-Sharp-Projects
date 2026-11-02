
using System;

// Display the welcome message to the user.
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Ask the user to enter the package weight.
Console.WriteLine("Please enter the package weight:");
decimal weight = Convert.ToDecimal(Console.ReadLine());

// Check whether the package exceeds the weight limit.
if (weight > 50)
{
    // Display an error and stop the program if too heavy.
    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
    return;
}

// Ask the user to enter the package width.
Console.WriteLine("Please enter the package width:");
decimal width = Convert.ToDecimal(Console.ReadLine());

// Ask the user to enter the package height.
Console.WriteLine("Please enter the package height:");
decimal height = Convert.ToDecimal(Console.ReadLine());

// Ask the user to enter the package length.
Console.WriteLine("Please enter the package length:");
decimal length = Convert.ToDecimal(Console.ReadLine());

// Calculate the sum of all three dimensions.
decimal totalDimensions = width + height + length;

// Check whether the combined dimensions exceed 50.
if (totalDimensions > 50)
{
    // Display an error and stop the program if too large.
    Console.WriteLine("Package too big to be shipped via Package Express.");
    return;
}

// Calculate the shipping quote using the required formula.
decimal shippingQuote = (width * height * length * weight) / 100;

// Display the shipping quote formatted as a dollar amount.
Console.WriteLine($"Your estimated total for shipping this package is: ${shippingQuote:F2}");

// Thank the user for using Package Express.
Console.WriteLine("Thank you!");
