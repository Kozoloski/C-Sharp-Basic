Console.WriteLine("Write a short sentence:");
string shortSentence = Console.ReadLine();

string[] words = shortSentence.Split();

for (int i = 0; i < words.Length; i++)
{
    Console.WriteLine(words[i]);
}

