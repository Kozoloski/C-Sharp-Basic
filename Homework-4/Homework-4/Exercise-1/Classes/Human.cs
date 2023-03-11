
using System.Xml.Linq;

namespace Exercise_1.Classes
{
    public class Human
    {

        public Human (string firstName, string lastName, int age) 
        { 
          FirstName = firstName;
          LastName = lastName;
          Age = age;
        
        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public void GetPersonStats()
        {
            Console.WriteLine($"{FirstName} {LastName} is {Age} years old");
        }

    }



}
