

namespace Exercise_3.Classes
{
    public class Student
    {

        public Student(string name, string academy, string group) 
        {
          Name = name;
          Academy = academy;
          Group = group;
    
        
        
        }
        public string Name { get; set; }
        public string Academy { get; set; }
        public string Group { get; set; }


        public void GetPersonInformation()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Academy: {Academy}");
            Console.WriteLine($"Group: {Group}");

        }

    }
}
