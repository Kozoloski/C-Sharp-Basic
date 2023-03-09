Console.WriteLine("Enter your date of birth in these possible formats: mm/dd/yyyy, mm.dd.yyyy, or mm dd yyyy");
string dateOfBirth = Console.ReadLine();

DateTime convertedDateOfBirth = Convert.ToDateTime(dateOfBirth);

DateTime dateTime = DateTime.Now;

int age = dateTime.Year - convertedDateOfBirth.Year;

if (age > 1)
{
    if (dateTime.Month < convertedDateOfBirth.Month ||
    (dateTime.Month == convertedDateOfBirth.Month && dateTime.Day < convertedDateOfBirth.Day)) age--;

    Console.WriteLine($"You are: {age} years old");
}

if (age == 0)
{
    age = dateTime.Month - convertedDateOfBirth.Month;

    age = age <= 0 ? (12 + age) : age;

    age = dateTime.Day - convertedDateOfBirth.Day >= 0 ? age : --age;

    Console.WriteLine($"You are: {age} months old");
}

if (convertedDateOfBirth > dateTime)
{
    Console.WriteLine("Invalid Input");
}




