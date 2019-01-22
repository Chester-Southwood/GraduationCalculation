using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NetCoreBiginner
{
    public class Date
    {
        [Required]
        [Range(1, 31)]
        public int Day { get; set; }

        [Required]
        [Range(1, 12)]
        public int Month { get; set; }

        private int ThisYear { get; set; } = DateTime.Now.Year;

        [Required]
        [Range(1900, 2099)]
        public int Year { get; set; }

        public static string GetDay()
        {
            int intDay = (int)DateTime.Now.DayOfWeek;
            intDay = intDay % 7;
            string day;
            switch (intDay)
            {
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                default:
                    day = "Saturday";
                    break;
            }
            return day;
        }

        public static string GetMonth()
        {
            int intMonth = DateTime.Now.Month;
            string strMonth;
            switch (intMonth)
            {
                case 0:
                    strMonth = "January";
                    break;
                case 1:
                    strMonth = "Februrary";
                    break;
                case 2:
                    strMonth = "March";
                    break;
                case 3:
                    strMonth = "April";
                    break;
                case 4:
                    strMonth = "May";
                    break;
                case 5:
                    strMonth = "June";
                    break;
                case 6:
                    strMonth = "July";
                    break;
                case 7:
                    strMonth = "August";
                    break;
                case 8:
                    strMonth = "September";
                    break;
                case 9:
                    strMonth = "October";
                    break;
                case 10:
                    strMonth = "November";
                    break;
                default:
                    strMonth = "December";
                    break;
            }
            return strMonth;
        }

    }
}
