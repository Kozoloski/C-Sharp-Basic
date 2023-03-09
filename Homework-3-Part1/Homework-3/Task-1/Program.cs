Console.WriteLine("Enter a word:");
string word = Console.ReadLine();

if (word.Length > 5)
{
    string result = word.Substring(word.Length - 5);

    Console.WriteLine("The last 5 characters are: " + result);
}
else
{
    Console.WriteLine("Invalid Input");
}