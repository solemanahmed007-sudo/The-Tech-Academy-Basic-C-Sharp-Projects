
using System;

// Create a connection to the student database.
using var db = new StudentContext();

// Create the database and tables if they don't exist.
db.Database.EnsureCreated();

// Create a new student with sample information.
Student student = new Student
{
    FirstName = "John",
    LastName = "Smith"
};

// Add the student to the database.
db.Students.Add(student);

// Save the student to the database.
db.SaveChanges();

// Display a success message.
Console.WriteLine("Student added successfully!");
Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
