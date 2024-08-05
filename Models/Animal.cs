namespace veterinaryCenter.Models;
public abstract class Animal
{
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Birthdate { get; set; }
    public string Breed { get; set; }
    public string Color { get; set; }
    public double WeightInKg { get; set; }

    public Animal(int id, string name, DateTime birthdate, string breed, string color, double weightInKg)
    {
        Id = id;
        Name = name;
        Birthdate = birthdate;
        Breed = breed;
        Color = color;
        WeightInKg = weightInKg;
    }

    public abstract void ShowInformation();
    public abstract void BasicReview();
    public int CalculateAgeInMonths()
    {
        return (int)((DateTime.Now - Birthdate).TotalDays / 30);
    }
}







