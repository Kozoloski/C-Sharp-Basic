using Exercise_3.Classes;


Student student1 = new Student("Jonh", "Programming", "G5");

Student student2 = new Student("Jim", "Web Design", "G2");

Student student3 = new Student("Tom", "Digital Marketing", "G3");

Student student4 = new Student("Jessica", "Data Science", "G1");

Student student5 = new Student("Kate", "UI Design", "G4");

Student[] studentsArray = new Student[] {student1, student2, student3, student4, student5};


Console.WriteLine("Enter a name:");
string name = Console.ReadLine();

int a = 0;
for (int i = 0; i < studentsArray.Length; i++)
{
    string names = studentsArray[i].Name;

    studentsArray[i].Name = names;

    
  for (int j = 0; j < names.Length; j++)
    {
        if(names == name)
        {
            Console.WriteLine("The student is in our database! Here are his/her personal informations: ");
            studentsArray[i].GetPersonInformation();
            a++;
            break;
        }        
                                      
    } 
  
}

if (a == 0)
{
    Console.WriteLine("ERROR! There is no such person in the database!");
}