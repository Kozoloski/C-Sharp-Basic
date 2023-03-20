

using ClassLibrary1.Enums;
using System.Security.Authentication;

namespace ClassLibrary1.Classes
{
    public class SalesPerson : Employee
    {
        public SalesPerson(string firstname, string lastname) {
        
         FirstName = firstname;
         LastName = lastname;
   
        }
        private double SuccessSaleRevenue { get; set; }

        public double AddSuccessRevenue(double number)
        {
            SuccessSaleRevenue = number;
            return SuccessSaleRevenue;
        }

        public override void GetSalary()
        {
          if(SuccessSaleRevenue <= 2000) Console.WriteLine($"Total Salary of {FirstName} {LastName} is {Salary + 500} $");
             
          if (SuccessSaleRevenue > 2000 & SuccessSaleRevenue <=5000) Console.WriteLine($"Total Salary of {FirstName} {LastName} is {Salary + 1000} $");
             
          if (SuccessSaleRevenue > 5000) Console.WriteLine($"Total Salary of {FirstName} {LastName} is {Salary + 1500} $");                  
        }
    }
}
