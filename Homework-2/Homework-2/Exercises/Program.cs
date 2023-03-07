#region Exerise 1


string[] animals = new string[5] {"Lion", "Cat", "Dog", "Fish", "Bird"};

double[] decimals = new double[5] { 2.5, 4.5, 6.4, 0.2, 1.5 };

char[] characters = new char[5] {'s', 'g', 'f', 'g', 'g'};

bool[] boolArray = new bool[5] { true, false, true, true, false};

int[,] arrayWithinArray = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 8, 9 } };


#endregion

#region Exerise 2

int[] newArray;

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


if(isFirstParsed && isSecondParsed && isThirdParsed && isFourthParsed && isFifthParsed)
{
    newArray = new int[5] {firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber};
    int sum = firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber;
    Console.WriteLine("The sum is:" + sum);
}
else
{
    Console.WriteLine("Invalid Input! You've probably entered something else instead of number!");
}

#endregion

#region Exerise 3

string[] namesList = new string[1];

int num = 0;


for (int i = 0; i <= namesList.Length; i++) {

    Console.WriteLine("Please enter a name");
    string name = Console.ReadLine();

    Array.Resize(ref namesList, namesList.Length + i);
    namesList[i] = name;

    Console.WriteLine("Enter Y to continue, or N to stop and print the list of names!");
    string yesOrNo = Console.ReadLine();


   if (yesOrNo == "Y") {

     num++;
     continue;
    }
    
    else if (yesOrNo == "N") {
     Console.WriteLine("These are the names in the list: ");

     for (int j = 0; j <= num; j++) {
            
     Console.WriteLine(namesList[j]);
     }
        break;
    }
    
    else {
     
     Console.WriteLine("Invalid Input!");
     break;
    }
}

#endregion
