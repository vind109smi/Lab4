using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCLab.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Name"] = "MVCLab4";
            // Create a DateTime object to instantiate
            DateTime today = DateTime.Now;

            // Declare currentHour variable and check to see if time fits
            int presentTime = today.Hour;
            if (presentTime < 12)
            {
                ViewData["Greeting"] = "Good Morning!";
            }
            else if (presentTime < 18)
            {
                ViewData["Greeting"] = "Good Afternoon!";
            }
            else
            {
                ViewData["Greeting"] = "Good Evening";
            }

            //Get the remaining days using DateTime object
            int remainingDays = 0;
            bool isLeap = DateTime.IsLeapYear(today.Year);
            if (isLeap)
            {
                remainingDays = 366 - today.DayOfYear;
            }
            else
            {
                remainingDays = 365 - today.DayOfYear;
            }
            ViewData["Time"] = today.ToShortTimeString();
            ViewData["Date"] = today.ToShortDateString();
            ViewData["Days Left"] = remainingDays;
            ViewData["Year"] = today.Year;

            return View();

        }
        public IActionResult Items(int id)
        {
            ViewData["ID"] = id;
            // This is the language listing stored in an array.
            string[] languages = { "C#","HTML5","JavaScript", "Python", "C++", "Java" };
            return View(languages);
        }

    }
}
