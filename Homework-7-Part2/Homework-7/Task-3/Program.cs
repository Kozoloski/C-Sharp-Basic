using Domain.Classes;
using Domain.Enums;
using System;

List<Animal> animals = new List<Animal>()
{
    new Animal("Lion", "Yellow", 6, Gender.Male),
    new Animal("Bear", "Brown", 2, Gender.Male),
    new Animal("Elephant", "Gray", 7, Gender.Female),
    new Animal("Albatross", "White", 3, Gender.Male),
    new Animal("Antilope", "Brown", 4, Gender.Male),
    new Animal("Anaconda", "Yellow", 5, Gender.Male),
    new Animal("Capybara", "Brown", 7, Gender.Female),
    new Animal("Hummingbird", "Brown", 7, Gender.Female),
    new Animal("Caterpillar", "Green", 4, Gender.Female)
};


List<Animal> animalAge = animals.Where(animal => animal.Age >= 5).ToList();
Console.WriteLine("These animals have 5 or more years:");
foreach (Animal animal in animalAge) Console.WriteLine(animal.Name);

List<Animal> animalsThatStartWithA = animals.Where(animal => animal.Name.StartsWith("A")).ToList();
Console.WriteLine("\nThese animals start with A:");
foreach (Animal animal in animalsThatStartWithA) Console.WriteLine(animal.Name);

List<Animal> animalsThatAreBrownAndMale = animals.Where(animal => animal.Color == "Brown").Where(animal => animal.Gender == Gender.Male).ToList();
Console.WriteLine("\nThese animals are male and brown:");
foreach (Animal animal in animalsThatAreBrownAndMale) Console.WriteLine(animal.Name);

Animal firstAnimalWithMoreThanTenCharacters = animals.First(animal => animal.Name.Length >10);
Console.WriteLine("\nThis is the first animal with more than 10 characters:");
Console.WriteLine(firstAnimalWithMoreThanTenCharacters.Name);

