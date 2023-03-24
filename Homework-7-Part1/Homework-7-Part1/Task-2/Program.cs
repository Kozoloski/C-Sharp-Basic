List<int> listOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> squareOfNumbers = listOfNumbers.Select(number => number * number).ToList();

Console.WriteLine("These are the squares of the numbers in the list above:");

foreach (int square in squareOfNumbers) Console.WriteLine(square);


