
using System;

// Create an Employee class to store employee information.
public class Employee
{
    // Property to store the employee's unique ID.
    public int Id { get; set; }

    // Property to store the employee's first name.
    public string FirstName { get; set; } = "";

    // Property to store the employee's last name.
    public string LastName { get; set; } = "";

    // Overload the == operator to compare employees by their IDs.
    public static bool operator ==(Employee? employee1, Employee? employee2)
    {
        // If both references point to the same object, return true.
        if (ReferenceEquals(employee1, employee2))
            return true;

        // If either employee is null, they are not equal.
        if (employee1 is null || employee2 is null)
            return false;

        // Compare the ID properties of both employees.
        return employee1.Id == employee2.Id;
    }

    // Overload the != operator, which is required alongside ==.
    public static bool operator !=(Employee? employee1, Employee? employee2)
    {
        // Return the opposite result of the == comparison.
        return !(employee1 == employee2);
    }

    // Override Equals to maintain consistency with the == operator.
    public override bool Equals(object? obj)
    {
        // Check whether obj is an Employee with the same ID.
        return obj is Employee other && Id == other.Id;
    }

    // Override GetHashCode to use the employee's ID.
    public override int GetHashCode()
    {
        // Return a hash code based on the employee's ID.
        return Id.GetHashCode();
    }
}

// Create the main Program class.
class Program
{
    // Main is the starting point of the application.
    static void Main(string[] args)
    {
        // Create the first Employee object.
        Employee employee1 = new Employee
        {
            Id = 101,
            FirstName = "John",
            LastName = "Smith"
        };

        // Create the second Employee object.
        Employee employee2 = new Employee
        {
            Id = 101,
            FirstName = "Jane",
            LastName = "Doe"
        };

        // Compare the employees using the overloaded == operator.
        Console.WriteLine("Employees are equal: " + (employee1 == employee2));

        // Compare the employees using the overloaded != operator.
        Console.WriteLine("Employees are not equal: " + (employee1 != employee2));
    }
}
