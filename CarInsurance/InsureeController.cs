using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarInsurance.Data;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    // Handles insurance applications and quotes.
    public class InsureeController : Controller
    {
        private readonly CarInsuranceContext _context;

        // Connect to the database.
        public InsureeController(CarInsuranceContext context)
        {
            _context = context;
        }

        // Display the insurance application form.
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // Calculate and save the insurance quote.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Insuree insuree)
        {
            // Calculate the quote on the server.
            ModelState.Remove(nameof(Insuree.Quote));

            if (!ModelState.IsValid)
                return View(insuree);

            decimal quote = 50m;

            // Add the age-based charge.
            int age = DateTime.Today.Year -
                      insuree.DateOfBirth.Year;

            if (insuree.DateOfBirth.Date >
                DateTime.Today.AddYears(-age))
                age--;

            if (age <= 18)
                quote += 100m;
            else if (age <= 25)
                quote += 50m;
            else
                quote += 25m;

            // Add charges for vehicle age.
            if (insuree.CarYear < 2000)
                quote += 25m;

            if (insuree.CarYear > 2015)
                quote += 25m;

            // Add Porsche charges.
            if (string.Equals(insuree.CarMake?.Trim(),
                "Porsche", StringComparison.OrdinalIgnoreCase))
            {
                quote += 25m;

                if (string.Equals(insuree.CarModel?.Trim(),
                    "911 Carrera", StringComparison.OrdinalIgnoreCase))
                    quote += 25m;
            }

            // Add $10 per speeding ticket.
            quote += insuree.SpeedingTickets * 10m;

            // Add 25% for a DUI.
            if (insuree.DUI)
                quote *= 1.25m;

            // Add 50% for full coverage.
            if (insuree.CoverageType)
                quote *= 1.50m;

            // Save the calculated monthly quote.
            insuree.Quote = Math.Round(quote, 2);

            _context.Insurees.Add(insuree);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        // Show all insurance quotes.
        public async Task<IActionResult> Index()
        {
            return View(await _context.Insurees.ToListAsync());
        }

        // Show administrator quote records.
        public async Task<IActionResult> Admin()
        {
            return View(await _context.Insurees.ToListAsync());
        }
    }
}