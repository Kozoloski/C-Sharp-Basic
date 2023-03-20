using ClassLibrary1.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Classes
{
    public class Manager : Employee
    {
        public Manager(string firstname, string lastname) 
        {
            FirstName = firstname;
            LastName = lastname;

        }

        public Role Role { get; set; } = Role.Manager;
        private double Bonus { get; set; }

        public double AddBonus(double number)
        {
            Bonus = number;
            return Bonus;
        }

        public override void GetSalary()
        {
            Console.WriteLine($"Total Salary of {FirstName} {LastName} is {Salary + Bonus} $");
        }

    }
}
