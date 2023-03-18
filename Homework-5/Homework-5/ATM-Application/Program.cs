using ATM_Application.Classes;
using System.Data;
using System.Xml.Linq;

Customer[] database = new Customer[]
{
    new Customer("Tom", "Jonhson", new Card(1234123412341234, 100)),
    new Customer("John", "Doe", new Card(3221442143214321, 1400)),
    new Customer("Kate", "Dawson", new Card(4234123422341234, 400)),
    new Customer("Richard", "Simmons", new Card(2321332141214321, 900)),
};

while(true)
{
    Console.WriteLine();
    Console.WriteLine("1.Register");
    Console.WriteLine("2.Login");
    bool userInput1 = int.TryParse(Console.ReadLine(), out int userInputParsed1);
    Console.WriteLine();


    if (!userInput1 || (userInputParsed1 != 1 && userInputParsed1 != 2))
    {
        Console.WriteLine("Invalid Input!");
        continue;
    }
    if (userInputParsed1 == 1)
    {
        Console.WriteLine("Enter First Name:");
        string newName = Console.ReadLine();
        Console.WriteLine("Enter Last Name:");
        string lastName = Console.ReadLine();
        long seg1 = new Random().Next(1000, 9999);
        long seg2 = new Random().Next(1000, 9999);
        long seg3 = new Random().Next(1000, 9999);
        long seg4 = new Random().Next(1000, 9999);
        long newNumber = seg1 * 1000000000000 + seg2 * 100000000 + seg3 * 1000 + seg4;

        Customer newCustomer = new Customer(newName, lastName, new Card(newNumber, 0));
        Array.Resize(ref database, database.Length + 1);
        database[database.Length - 1] = newCustomer;

        continue;
    }
    foreach (Customer customer in database)
    {
        customer.GetCustomerInfo();
    }
    Console.WriteLine();
    Console.WriteLine("Welcome to the ATM app!");
    Console.WriteLine("Please enter your credit number:");
    bool isCreditNumberParsed = long.TryParse(Console.ReadLine(), out long creditNumber);

    Console.WriteLine("Please enter your pin number:");
    bool isPinParsed = int.TryParse(Console.ReadLine(), out int pin);

if (isCreditNumberParsed && isPinParsed )
{
    for (int i = 0; i < database.Length; i++)
    {
        Customer customer = database[i];

        if (creditNumber == customer.Card.Number)
        {
            if (pin == customer.Card.GetCardPin())
            {
                customer.Welcome();
            }            
        }
    }

} else
{
    Console.WriteLine("Invalid Input! Try again!");
        continue;
    
}


Customer CheckBalance (Customer[] database, long creditNumber, int pin)
{
    foreach (Customer customer in database)
    {
        if (customer.Card.Number == creditNumber)
        {
            if(pin == customer.Card.GetCardPin())
            {
                Console.WriteLine($"Your balance is: {customer.Card.Balance} $");
            }
        }       
    }
    return null;
}


Customer Deposit (Customer[] database, long creditNumber, int pin)
{
    foreach (Customer customer in database)
    {
        if (customer.Card.Number == creditNumber)
        {
            if (pin == customer.Card.GetCardPin())
            {
                Console.WriteLine("Enter the amount of money you wish to deposit: ");
               
                bool moneyDeposited = int.TryParse(Console.ReadLine(), out int moneyDepositedParsed);

                if (moneyDeposited)
                {
                    Console.WriteLine($"New balance after deposit: {customer.Card.Balance + moneyDepositedParsed} $\n");
                }
                else
                {
                    Console.WriteLine("Enter a valid amount!!!");
                }
            }
        }
    }
    return null;
}



Customer Withdraw (Customer[] database, long creditNumber, int pin)
{
    foreach (Customer customer in database)
    {
        if (customer.Card.Number == creditNumber)
        {
            if (pin == customer.Card.GetCardPin())
            {
                Console.WriteLine("Enter the amount of money you wish to withdraw: \n");

                bool moneyWithdrawn = int.TryParse(Console.ReadLine(), out int moneyWithdrawnParsed);

                if (moneyWithdrawn)
                {
                    if (moneyWithdrawnParsed <= customer.Card.Balance)
                    {
                        Console.WriteLine($"You have succesfully withdrawn: {moneyWithdrawnParsed} $\n");

                        Console.WriteLine($"New Balance after withdraw: {customer.Card.Balance - moneyWithdrawnParsed} $\n");
                    }
                    else
                    {
                        Console.WriteLine("You don't have that amount of money in your account!!!");
                    }
                }
                else
                {
                    Console.WriteLine("Enter a valid amount!!!");
                }
            }
        }

    }
    return null;
}
 

    bool Choice(Customer[] database)
{
    Console.WriteLine("Choose: \n1. Check Balance \n2. Cash Withdrawal \n3. Cash Deposit"); 
    int choice;
    bool isNumber = int.TryParse(Console.ReadLine(), out choice);
    if (!isNumber)
    {
        Console.WriteLine("That was not a number! Try again.");
        return false;
    }
    switch (choice)
    {
        case 1:         
            CheckBalance (database, creditNumber, pin);
            Console.Write("Press any key to try again or X to exit.");
            if (Console.ReadLine().ToUpper() != "X") return false;
            return true;

        case 2:
            Withdraw (database, creditNumber, pin);
            Console.Write("Press any key to try again or X to exit.");
            if (Console.ReadLine().ToUpper() != "X") return false;
            return true;

        case 3:
            Deposit (database, creditNumber, pin);
            Console.Write("Press any key to try again or X to exit.");
            if (Console.ReadLine().ToUpper() != "X") return false;
            return true;
                              
        default:
            Console.WriteLine("Please enter 1, 2 or 3");
            return false;           
    }    
}
while (!Choice(database)) ;
Console.ReadLine();
}



