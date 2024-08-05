namespace veterinaryCenter.Models;
public class Cat : Animal
{
    public bool BreedingStatus { get; set; }
    public string FurLength { get; set; }

    public Cat(int id, string name, DateTime birthdate, string breed, string color, double weightInKg, 
               bool breedingStatus, string furLength) 
        : base(id, name, birthdate, breed, color, weightInKg)
    {
        BreedingStatus = breedingStatus;
        FurLength = furLength;
    }

    public override void ShowInformation()
    {
        Console.WriteLine($"Cat: {Name}, Breed: {Breed}, Age: {CalculateAgeInMonths()} months");
    }

    public override void BasicReview()
    {
        Console.WriteLine($"Performing basic review for cat {Name}");
    }

    public void Hairdress()
    {
        if (FurLength != "None")
        {
            Console.WriteLine($"Grooming {Name}'s fur");
        }
        else
        {
            Console.WriteLine($"{Name} has no fur to groom");
        }
    }
}