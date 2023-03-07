string[] studentsG1 = new string[5] {"Tomo", "Ivana", "Simon", "Bojan", "Simona"};

string[] studentsG2 = new string[5] {"Anastasija", "Filip", "Sofija", "Teodora", "Vase"};


Console.WriteLine("Enter 1 or 2 to get the list of students from the given group: ");
bool isNumberParsed = int.TryParse(Console.ReadLine(), out int number);


if(isNumberParsed)
{
    if(number == 1)
    {
        Console.WriteLine("The students in G1 are: ");
        for (int i = 0; i < studentsG1.Length; i++)
        {
            Console.WriteLine(studentsG1[i]);
        }
    }

    if(number == 2)
    {
        Console.WriteLine("The students in G2 are: ");
        for (int i = 0; i < studentsG2.Length; i++)
        {
            Console.WriteLine(studentsG2[i]);
        }
    }
    
} else
{
    Console.WriteLine("Invalid Input");
}




