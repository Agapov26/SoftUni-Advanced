using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class DateModifier
    {
        private int dayDifference;
        private DateTime firstDate;
        private DateTime secondDate;

        public DateModifier(string firstDate, string secondDate)
        {
            this.firstDate = DateTime.Parse(firstDate);
            this.secondDate = DateTime.Parse(secondDate);
        }

        public int DayDifference
        {
            get { return dayDifference = Math.Abs((int)(firstDate - secondDate).TotalDays); }
        }
    }
}
