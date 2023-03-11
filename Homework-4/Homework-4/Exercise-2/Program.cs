using Exercise_2.Classes;


Console.WriteLine("Enter the name of your dog:");
string name = Console.ReadLine();

Console.WriteLine("Enter the race of your dog:");
string race = Console.ReadLine();

Console.WriteLine("Enter the color of your dog:");
string color = Console.ReadLine();

Dog dog1 = new Dog(name, race, color);

Console.WriteLine("Choose one from the three option below:");

Console.WriteLine("Enter 1 for choosing Eat Method:");

Console.WriteLine("Enter 2 for choosing Play Method:");

Console.WriteLine("Enter 3 for choosing ChasingTail Method:");

bool isMethodParsed = int.TryParse(Console.ReadLine(), out int option);

if(isMethodParsed && option > 0 && option < 4)
{
    if(option == 1)
    {
        dog1.Eat();
        Console.WriteLine(dog1);
    }

    if (option == 2)
    {
        dog1.Play();
        Console.WriteLine(dog1);
    }

    if (option == 3)
    {
        dog1.ChaseTail();
        Console.WriteLine(dog1);
    }

} else
{
    Console.WriteLine("Invalid Input");
}