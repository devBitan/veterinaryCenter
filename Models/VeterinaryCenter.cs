namespace veterinaryCenter.Models;
public class VeterinaryClinic
{
    public string Name { get; set; }
    public string Address { get; set; }
    public List<Dog> Dogs { get; set; }
    public List<Cat> Cats { get; set; }

    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
        Dogs = new List<Dog>();
        Cats = new List<Cat>();
    }

    public void SaveDog(Dog newDog)
    {
        Dogs.Add(newDog);
    }

    public void SaveCat(Cat newCat)
    {
        Cats.Add(newCat);
    }

    public void ShowAllPatients()
    {
        Console.WriteLine("All Patients:");
        foreach (var dog in Dogs)
        {
            dog.ShowInformation();
        }
        foreach (var cat in Cats)
        {
            cat.ShowInformation();
        }
    }

    // Implementa los demás métodos aquí...
}