using System;

namespace LeapYearKata.Domain
{
    public class LeapYearValidator
    {
        public bool IsLeapYear(int year)
        {
            return year % 4 == 0; 
        }
    }
}
