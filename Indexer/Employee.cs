using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Indexer
{
    public class Employee : IComparable<Employee>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary;
        public HiringDate Hire_date { get; set; }
        public string Gender { get; set; }
        public decimal salary
        {
            get { return Salary; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary Must By Biger than 0");
                }
                Salary = value;
            }
        }

        public Employee(int Id,string Name, decimal Salary, HiringDate Hire_date,string Gender)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
            this.Hire_date=Hire_date;
            this.Gender = Gender;
        }
        public override string ToString()
        {
            return $"Employee Data is :- Id :{Id} - Name is {Name} - Salary Is {Salary} - Hire date is {Hire_date} - Gender is {Gender}";
        }
        public int CompareTo(Employee? other)
        {
            if (Hire_date.Year != other.Hire_date.Year)
                return Hire_date.Year.CompareTo(other.Hire_date.Year);
            if (Hire_date.Month != other.Hire_date.Month)
                return Hire_date.Month.CompareTo(other.Hire_date.Month);
            return Hire_date.Day.CompareTo(other.Hire_date.Day);
        }

    }
}
