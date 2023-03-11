using Exercise_1.Classes;


Console.WriteLine("Enter your First Name:");
string firstName = Console.ReadLine();

Console.WriteLine("Enter your Last Name:");
string lastName = Console.ReadLine();

Console.WriteLine("Enter your age:");
bool isAgeParsed = int.TryParse(Console.ReadLine(), out int age);


if (isAgeParsed)
{
    Human human1 = new Human(firstName, lastName, age);
    human1.GetPersonStats();
} else
{
    Console.WriteLine("Invalid Input! Enter a number in the age category!");
}
