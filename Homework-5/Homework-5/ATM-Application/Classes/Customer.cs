
namespace ATM_Application.Classes
{
    public class Customer
    {
        public Customer(string firstname, string lastname, Card creditCard)
        {
            Firstname = firstname;
            Lastname = lastname;
            Card = creditCard;
        }

        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public Card Card { get; set; }

        public void GetCustomerInfo()
        {
            Console.WriteLine($"Welcome {Firstname} {Lastname}: Your credit card number is: {Card.Number} Your PIN number is: {Card.GetCardPin()} Your balance is: {Card.Balance}$");
        }

        public void Welcome()
        {
            Console.WriteLine($"Welcome {Firstname} {Lastname}");
        }
    }

}
