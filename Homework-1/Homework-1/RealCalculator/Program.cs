Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the operation: ");
char operation = Convert.ToChar(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if (operation == '+')
{
    Console.WriteLine("The result is: " + (number1 + number2));
}

if (operation == '-')
{
    Console.WriteLine("The result is: " + (number1 - number2));
}
if (operation == '*')
{
    Console.WriteLine("The result is: " + (number1 * number2));
}
if (operation == '/')
{
    Console.WriteLine("The result is: " + (number1 / number2));
}