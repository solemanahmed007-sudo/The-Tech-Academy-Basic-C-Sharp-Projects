
using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    // Stores information about an insurance applicant.
    public class Insuree
    {
        // Unique identifier for each applicant.
        public int Id { get; set; }

        // Applicant's first name.
        [Required]
        public string FirstName { get; set; } = "";

        // Applicant's last name.
        [Required]
        public string LastName { get; set; } = "";

        // Applicant's email address.
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; } = "";

        // Applicant's date of birth.
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        // Vehicle information.
        public int CarYear { get; set; }
        public string CarMake { get; set; } = "";
        public string CarModel { get; set; } = "";

        // Whether the applicant has had a DUI.
        public bool DUI { get; set; }

        // Number of speeding tickets.
        public int SpeedingTickets { get; set; }

        // True means full coverage.
        public bool CoverageType { get; set; }

        // Calculated monthly insurance quote.
        public decimal Quote { get; set; }
    }
}
