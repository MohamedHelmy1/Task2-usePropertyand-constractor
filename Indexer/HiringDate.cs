using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    public class HiringDate 
    {
        public int Day;
        public int Month;
        public int Year {  get; set; }
        public int day
        {
            get { return Day; }
            set
            {
                if (value<1 || value>31)
                {
                    throw new Exception("Day Must By Between 1 and 31");
                }
                Day = value;
            }
        }
        public int month
        {
            get { return Month; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new Exception("Month Must By Between 1 and 12");
                }
                Month = value;
            }
        }
       
        public HiringDate(int Day,int Month,int Year)
        {
            //this is to call local Varible
            if (Day < 1 || Day > 31)
            {
                throw new Exception("Day Must By Between 1 and 31");
            }
            else 
            this.Day = Day;
            if (Month < 1 || Month > 12)
            {
                throw new Exception("Month Must By Between 1 and 12");
            }
           else
            this.Month = Month;
            this.Year = Year;
        }
        public HiringDate():this(0,0,0)//constractor chaning
        {

        }
        public override string ToString()
        {
            return $"{Day} / {Month} / {Year}";
        }

        
    }
}
