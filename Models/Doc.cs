namespace veterinaryCenter.Models;
public class Dog : Animal
{
    public bool BreedingStatus { get; set; }
    public string Temperament { get; set; }
    public string MicrochipNumber { get; set; }
    public string BarkVolume { get; set; }
    public string CoatType { get; set; }

    public Dog(int id, string name, DateTime birthdate, string breed, string color, double weightInKg, 
               bool breedingStatus, string temperament, string microchipNumber, string barkVolume, string coatType) 
        : base(id, name, birthdate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        Temperament = temperament;
        MicrochipNumber = microchipNumber;
        BarkVolume = barkVolume;
        CoatType = coatType;
    }

    public override void ShowInformation()
    {
        Console.WriteLine($"Dog: {Name}, Breed: {Breed}, Age: {CalculateAgeInMonths()} months");
    }

    public override void BasicReview()
    {
        Console.WriteLine($"Performing basic review for dog {Name}");
    }

    public void Hairdress()
    {
        if (CoatType != "Short")
        {
            Console.WriteLine($"Giving {Name} a haircut");
        }
        else
        {
            Console.WriteLine($"{Name}'s coat is too short for a haircut");
        }
    }
}