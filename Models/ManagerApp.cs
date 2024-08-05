namespace veterinaryCenter.Models;
public class ManagerApp
{
    public static void ShowHeader()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("       Veterinary Clinic App      ");
        Console.WriteLine("==================================");
    }

    public static void ShowFooter()
    {
        Console.WriteLine("==================================");
        Console.WriteLine("          End of Report           ");
        Console.WriteLine("==================================");
    }

    public static void ShowSeparator()
    {
        Console.WriteLine("----------------------------------");
    }
    
    public static Dog CreateDog()
    {
        Console.WriteLine("Creating a new dog:");
        Console.Write("Enter dog's name: ");
        string name = Console.ReadLine();
        Console.Write("Enter dog's birthdate (yyyy-MM-dd): ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter dog's breed: ");
        string breed = Console.ReadLine();
        Console.Write("Enter dog's color: ");
        string color = Console.ReadLine();
        Console.Write("Enter dog's weight in kg: ");
        double weightInKg = double.Parse(Console.ReadLine());
        Console.Write("Is the dog available for breeding? (true/false): ");
        bool breedingStatus = bool.Parse(Console.ReadLine());
        Console.Write("Enter dog's temperament (Timid/Normal/Aggressive): ");
        string temperament = Console.ReadLine();
        Console.Write("Enter dog's microchip number: ");
        string microchipNumber = Console.ReadLine();
        Console.Write("Enter dog's bark volume (low/normal/high): ");
        string barkVolume = Console.ReadLine();
        Console.Write("Enter dog's coat type (Short/Medium/Long): ");
        string coatType = Console.ReadLine();

        return new Dog(
            id: 0,
            name: name,
            birthdate: birthdate,
            breed: breed,
            color: color,
            weightInKg: weightInKg,
            breedingStatus: breedingStatus,
            temperament: temperament,
            microchipNumber: microchipNumber,
            barkVolume: barkVolume,
            coatType: coatType
        );
    }

    public static Cat CreateCat()
    {
        Console.WriteLine("Creating a new cat:");
        Console.Write("Enter cat's name: ");
        string name = Console.ReadLine();
        Console.Write("Enter cat's birthdate (yyyy-MM-dd): ");
        DateTime birthdate = DateTime.Parse(Console.ReadLine());
        Console.Write("Enter cat's breed: ");
        string breed = Console.ReadLine();
        Console.Write("Enter cat's color: ");
        string color = Console.ReadLine();
        Console.Write("Enter cat's weight in kg: ");
        double weightInKg = double.Parse(Console.ReadLine());
        Console.Write("Is the cat available for breeding? (true/false): ");
        bool breedingStatus = bool.Parse(Console.ReadLine());
        Console.Write("Enter cat's fur length (None/Short/Medium/Long): ");
        string furLength = Console.ReadLine();

        return new Cat(
            id: 0,
            name: name,
            birthdate: birthdate,
            breed: breed,
            color: color,
            weightInKg: weightInKg,
            breedingStatus: breedingStatus,
            furLength: furLength
        );
    }
}