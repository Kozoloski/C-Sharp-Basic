Queue<int> numbers = new Queue<int>();

while (true)
{
    Console.WriteLine("Enter a number:");
    bool isNumberParsed = int.TryParse(Console.ReadLine(), out int number);

    if (isNumberParsed)
    {
        numbers.Enqueue(number);

        Console.WriteLine("Enter a Y to continue, or any other key to exit and print the result:");
        string input = Console.ReadLine();

        if (input.ToLower() == "Y".ToLower())
        {
            continue;
        }

        else
        {
            Console.WriteLine("These are the numbers you have entered in that particular order:");
            foreach (int item in numbers) Console.WriteLine(item);
        }

        break;
    }
    else Console.WriteLine("You didn't enter a number!");
}


