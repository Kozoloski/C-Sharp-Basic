
using System.Net.Security;

namespace Task_2.Classes
{
    public class Car
    {
        public Car (string model, int speed) 
        {
            Model = model;
            Speed = speed;
            
        }

        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }



        public int CalculateSpeed(Driver driver)
        {

            int skill = 0;
            skill = driver.Level * Speed;
            Console.WriteLine($"{driver.Name} has a skill level of {skill}");
            return skill;
        }


    }
}
