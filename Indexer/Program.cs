using System.Threading.Channels;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Count of Employees");
            
            int count = int.Parse(Console.ReadLine());
            Employee [] employees= new Employee[count];
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter details for Employee {i + 1}:");

                Console.Write("Enter Employees Enter Employees ID : ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Employees Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
               
                Console.Write("Enter Employees Hire Date (Day): ");
                int day = int.Parse(Console.ReadLine());
                //HiringDate hireDate = new HiringDate(); //حل اخر
                //hireDate.Day = day;
                Console.Write("Enter Employees Hire Date (Month): ");
                int month = int.Parse(Console.ReadLine()); 
                //hireDate.month = month;
                Console.Write("Enter Employee Hire Date (Year): ");
                int year = int.Parse(Console.ReadLine()); 
                //hireDate.Year = year;
                // call the constractor
               // HiringDate hireDate = new HiringDate( day, month, year);
               //cal the Property
                HiringDate hireDate = new HiringDate(Day: day, Month: month, Year: year);

               // string hire_Date =hireDate.ToString();

                Console.Write("Enter Employee Gender: ");
                string gender = Console.ReadLine();

                // إضافة الموظف إلى المصفوفة
                employees[i] = new Employee(id,name, salary, hireDate, gender);
            }
            // Sort the employees by hire date
            Array.Sort(employees);

            // Print sorted employees
            Console.WriteLine("\nEmployees sorted by Hire Date:");
            foreach (Employee emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
