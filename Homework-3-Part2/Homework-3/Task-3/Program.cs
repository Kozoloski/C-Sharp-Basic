Console.WriteLine("Enter a number:");
bool isNumberParsed = int.TryParse(Console.ReadLine(), out int number);

if (isNumberParsed)
{
    int getSum(int number)
    {
        int sum = 0;

        while (number != 0)
        {
            sum = sum + number % 10;
            number = number / 10;
        }

        return sum;
    }
    Console.Write("The sum of the digits is: " + getSum(number));
}
else
{
    Console.WriteLine("Invalid Input!");
}


