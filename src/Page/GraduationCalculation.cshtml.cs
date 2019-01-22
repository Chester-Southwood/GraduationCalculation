using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NetCoreBiginner.Pages
{
    public class GraduationCalculationModel : PageModel
    {
        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Date Date1 { get; set; }

        [BindProperty]
        public Date Date2 { get; set; }

        public Date DateResult { get; set; } = new Date();

        public void onGet()
        {

        }

        public async Task<IActionResult> OnPostCalculateAsync()
        {

            if (!ModelState.IsValid)
            {
                Message = $"Cannot Calculate Age From Current Data!";
                return Page();
            }

            DateResult.Day = Date1.Day - Date2.Day;
            DateResult.Month = Date1.Month - Date2.Month;
            DateResult.Year = Date1.Year - Date2.Year;
            DateTime dateTime1 = new DateTime(Date1.Year, Date1.Month, Date1.Day);
            DateTime dateTime2 = new DateTime(Date2.Year, Date2.Month, Date2.Day);
            TimeSpan timeResult = dateTime2.Subtract(dateTime1);
            Message = $"You'll Be {timeResult.Days / 365} When You Graduate!!!!";
            return RedirectToPage("./", );
        }
    }
}