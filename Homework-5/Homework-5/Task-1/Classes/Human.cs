

using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Task_1.Classes
{
    public class Human
    {


        public  Human(string firstName, string lastName, int age) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public void GetPersonDetails()
        {
            Console.WriteLine($"FullName: {FirstName} {LastName} ");
            Console.WriteLine($"Age: {Age}");       

        }

    }
}
