using ClassLibrary1.Enums;

namespace ClassLibrary1.Classes
{
    public class Employee
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Role Role { get; set; } = Role.Sales;
        protected double Salary { get; set; } = 500;


        public virtual void PrintInfo()
        {
            Console.WriteLine($"FirstName: {FirstName} LastName: {LastName} Salary: {Salary}");
        }


        public virtual void GetSalary() 
        {
            Console.WriteLine(Salary);
        }   
    }


   
}
