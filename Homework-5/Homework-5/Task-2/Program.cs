using Task_2.Classes;

Driver driver1 = new Driver("Bob", 3);
Driver driver2 = new Driver("Greg", 2);
Driver driver3 = new Driver("Jill", 5);
Driver driver4 = new Driver("Anne", 4);

Driver[] driversArray = new Driver[] {driver1, driver2, driver3, driver4};

Car car1 = new Car("Hyundai", 150);
Car car2 = new Car("Mazda", 170);
Car car3 = new Car("Ferrari", 220);
Car car4 = new Car("Porsche", 250);

Car[] carsArray = new Car[] {car1, car2, car3, car4};

bool continueDriving;
do
{
    Car selectedCar1 = null;
    Car selectedCar2 = null;
    Driver selectedDriver1 = null;
    Driver selectedDriver2 = null;

    Console.WriteLine("Choose car no.1");
    foreach (Car car in carsArray)
    {
        Console.WriteLine(car.Model);
    }
    string firstCar = Console.ReadLine();

    Console.WriteLine("Choose a driver");
    foreach (Driver driver in driversArray)
    {
        Console.WriteLine(driver.Name);
    }
    string firstDriver = Console.ReadLine();

    Console.WriteLine("Choose car no.2");
    foreach (Car car in carsArray)
    {
        if (car.Model.ToLower() != firstCar.ToLower())
            Console.WriteLine(car.Model);
    }
    string secondCar = Console.ReadLine();

    Console.WriteLine("Choose a driver");
    foreach (Driver driver in driversArray)
    {
        if (driver.Name.ToLower() != firstDriver.ToLower())
        {
            Console.WriteLine(driver.Name);
        }
    }
    string secondDriver = Console.ReadLine();


    foreach (Car car in carsArray)
    {
        if (car.Model.ToLower() == firstCar.ToLower())
        {
            selectedCar1 = car;
        }
        if (car.Model.ToLower() == secondCar.ToLower())
        {
            selectedCar2 = car;
        }
    }
    foreach (Driver driver in driversArray)
    {
        if (driver.Name.ToLower() == firstDriver.ToLower())
        {
            selectedDriver1 = driver;
        }
        if (driver.Name.ToLower() == secondDriver.ToLower())
        {
            selectedDriver2 = driver;
        }
    }
    if (selectedCar1 != null && selectedCar2 != null && selectedDriver1 != null && selectedDriver2 != null && firstDriver.ToLower() != secondDriver.ToLower() && firstCar.ToLower() != secondCar.ToLower())
    {
        RaceCars(selectedCar1, selectedDriver1, selectedCar2, selectedDriver2);

    }
    else
    {
        Console.WriteLine("ERROR");
    }
    Console.WriteLine("Continue Driving? Y/N");
    continueDriving = Console.ReadLine().ToLower() == "y";
}
while (continueDriving);
Console.WriteLine("Done racing!");


void RaceCars(Car car1, Driver driver1, Car car2, Driver driver2)
{
    int firstResult = car1.CalculateSpeed(driver1);
    int secondResult = car2.CalculateSpeed(driver2);


    if (firstResult > secondResult)
    {
        Console.WriteLine($"The car model that won the race was: {car1.Model} driven by the driver {driver1.Name} going {car1.Speed} km/h");
    }
    if (firstResult < secondResult)
    {
        Console.WriteLine($"The car model that won the race was: {car2.Model} driven by the driver {driver2.Name} going {car2.Speed} km/h");
    }

}