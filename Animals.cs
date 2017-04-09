using System;
using System.Collections.Generic;

class Animal
{
    public int Age;
    public string Name;
    public string Species;
}

public class Program
{
    public static void Main()
    {
        Animal cow = new Animal();
        cow.Age = 2;
        cow.Name = "C";
        cow.Species = "Cow";

        Animal dog = new Animal();
        dog.Age = 5;
        dog.Name = "Jason";
        dog.Species = "Dog";

        List<Animal> PetsList = new List<Animal>() {cow, dog};

        Console.WriteLine("Enter an age and I will Show you all the animals Below that age.");
        string ageString = Console.ReadLine();
        int ageInt = int.Parse(ageString);

        List<Animal> AnimalMatchSearch = new List<Animal>();

        foreach (Animal species in PetsList)
        {
            if (species.Age < ageInt)
            {
                AnimalMatchSearch.Add(species);
            }
        }

        foreach (Animal species in AnimalMatchSearch)
        {
            Console.WriteLine(species.Species);
        }
    }
}