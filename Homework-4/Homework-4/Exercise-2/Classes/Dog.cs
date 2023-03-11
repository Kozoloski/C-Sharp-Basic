

namespace Exercise_2.Classes
{
    public class Dog
    {



        public Dog(string name, string race, string color) 
        {
          Name = name;
          Race = race;
          Color = color;
        
        }

        public string Name { get; set; }
        public string Race { get; set; }
        public string Color { get; set; }


        public void Eat()
        {
            Console.WriteLine($"The dog {Name} which is {Race} and has {Color} color is now eating.");
        }

        public void Play()
        {
            Console.WriteLine($"The dog {Name} which is {Race} and has {Color} color is now playing.");
        }

        public void ChaseTail()
        {
            Console.WriteLine($"The dog {Name} which is {Race} and has {Color} color is now chasing its tail.");
        }

    }
}
