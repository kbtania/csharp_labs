using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12Task1
{
    class Date
    {
        private int day;
        private int month;
        private int year;

        public int Day
        {
            get { return day; }
            set
            {
                if (value < 0 || value > 31)
                    throw new Exception("Day must be in range 1-31");
                day = value;
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if (value < 1 || value > 12)
                    throw new Exception("Month must be in range 1-12");
                month = value;
            }
        }

        public int Year
        {
            get { return year; }
            set
            {
                if (value < 0)
                    throw new Exception("Year must be a positive integer");
            }
        }

        public Date(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        // indexer
        public int this[char indx]
        {
            get
            {
                switch (indx)
                {
                    case 'd': return Day;
                    case 'm': return Month;
                    case 'y': return Year;
                    default: return 0;
                }
            }

            set
            {
                switch (indx)
                {
                    case 'd':
                        Day = value;
                        break;
                    case 'm':
                        Month = value;
                        break;
                    case 'y':
                        Year = value;
                        break;
                }
            }
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }

        public void ChangeDate(ref Date date, char choice, int add)
        {
            if (choice == 'd')
                date =  new Date(this['d'] + add, Month, Year);
            else if (choice == 'm')
                date =  new Date(Day, this['m'] + add, Year);
            else if (choice == 'y')
                date =  new Date(Day, Month, this['y']);
            else
                date = this;
        }

    }
}
