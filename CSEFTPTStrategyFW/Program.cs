using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSEFTPTStrategyFW
{
    class Program
    {
        static void Main(string[] args)
        {
            var ctx = new Context();

            try
            {
                ctx.Employees.Add(new PermanentEmployee()
                {
                    FirstName = "Darth",
                    LastName = "Vader",
                    Gender = "male",
                    AnnualSalary = 156230
                });

                ctx.SaveChanges();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
