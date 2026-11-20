
using System;

// Define an interface named IQuittable.
// Any class implementing this interface must have a Quit() method.
public interface IQuittable
{
    // Declare a void method called Quit().
    void Quit();
}

// Create an Employee class that implements the IQuittable interface.
public class Employee : IQuittable
{
    // Create a property to store the employee's first name.
    public string FirstName { get; set; } = "";

    // Create a property to store the employee's last name.
    public string LastName { get; set; } = "";

    // Implement the Quit() method required by the interface.
    public void Quit()
    {
        // Display a message indicating the employee has quit.
        Console.WriteLine(FirstName + " " + LastName + " has quit the company.");
    }
}

// Define the Program class.
class Program
{
    // Main is the entry point of the application.
    static void Main(string[] args)
    {
        // Create an Employee object using the IQuittable interface type.
        // This demonstrates polymorphism.
        IQuittable employee = new Employee
        {
            // Assign the employee's first name.
            FirstName = "John",

            // Assign the employee's last name.
            LastName = "Smith"
        };

        // Call the Quit() method through the interface reference.
        employee.Quit();
    }
}
