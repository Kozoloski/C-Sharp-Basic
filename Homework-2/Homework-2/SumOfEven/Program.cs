int[] newArray;
int even = 0;

Console.WriteLine("Enter the first number:");
bool isFirstParsed = int.TryParse(Console.ReadLine(), out int firstNumber);

Console.WriteLine("Enter the second number:");
bool isSecondParsed = int.TryParse(Console.ReadLine(), out int secondNumber);

Console.WriteLine("Enter the third number:");
bool isThirdParsed = int.TryParse(Console.ReadLine(), out int thirdNumber);


Console.WriteLine("Enter the fourth number:");
bool isFourthParsed = int.TryParse(Console.ReadLine(), out int fourthNumber);

Console.WriteLine("Enter the fifth number:");
bool isFifthParsed = int.TryParse(Console.ReadLine(), out int fifthNumber);

Console.WriteLine("Enter the sixth number:");
bool isSixhtParsed = int.TryParse(Console.ReadLine(), out int sixthNumber);


if (isFirstParsed && isSecondParsed && isThirdParsed && isFourthParsed && isFifthParsed && isSixhtParsed)
{
    newArray = new int[6] {firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber, sixthNumber};

    foreach (int number in newArray)
    {
        if (number % 2 == 0)
        {
            even += number;
        }
    }

    Console.WriteLine("The sum of the even numbers is: " + even);
} else
{
    Console.WriteLine("Invalid Input! You've probably entered something else instead of number!");
}






