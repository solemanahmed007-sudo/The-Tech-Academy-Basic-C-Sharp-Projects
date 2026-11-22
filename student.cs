
using Microsoft.EntityFrameworkCore;

// Represents a student in the database.
public class Student
{
    // Unique ID for each student.
    public int StudentId { get; set; }

    // Stores the student's first name.
    public string FirstName { get; set; } = "";

    // Stores the student's last name.
    public string LastName { get; set; } = "";
}

// Manages the connection to the student database.
public class StudentContext : DbContext
{
    // Represents the Students table.
    public DbSet<Student> Students { get; set; } = null!;

    // Configures SQLite as the database.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite("Data Source=Students.db");
    }
}
