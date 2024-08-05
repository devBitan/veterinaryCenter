using veterinaryCenter.Models;
class Program
{
    static void Main(string[] args)
    {
        VeterinaryClinic clinic = new VeterinaryClinic("Riwi pet", "Cra 4 Medellin");

        while (true)
        {
            ManagerApp.ShowHeader();
            Console.WriteLine("1. Add Dog");
            Console.WriteLine("2. Add Cat");
            Console.WriteLine("3. Show All Patients");
            Console.WriteLine("4. Update Animal");
            Console.WriteLine("5. Delete Animal");
            Console.WriteLine("6. Show Animals");
            Console.WriteLine("7. show animal by name");
            Console.WriteLine("8. Exit");
            ManagerApp.ShowSeparator();

            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Dog newDog = CreateDog();
                    clinic.SaveDog(newDog);
                    break;
                case "2":
                    Cat newCat = CreateCat();
                    clinic.SaveCat(newCat);
                    break;
                case "3":
                    clinic.ShowAllPatients();
                    break;
                case "4":
                    Console.Write("Enter patient Name to update: ");
                    string updateId = (Console.ReadLine());
                    Console.Write("Is it a dog or a cat? (dog/cat): ");
                    string animalType = Console.ReadLine().ToLower();
                    if (animalType == "dog")
                    {
                        Dog updatedDog = CreateDog(); // Asume que ya tienes este método
                        clinic.UpdateDog(updateId, updatedDog);
                    }
                    else if (animalType == "cat")
                    {
                        Cat updatedCat = CreateCat(); // Asume que ya tienes este método
                        clinic.UpdateCat(updateId, updatedCat);
                    }
                    break;
                case "5":
                    Console.Write("Enter patient Name to delete: ");
                    string deleteId = (Console.ReadLine());
                    Console.Write("Is it a dog or a cat? (dog/cat): ");
                    string deleteType = Console.ReadLine().ToLower();
                    if (deleteType == "dog")
                    {
                        clinic.DeleteDog(deleteId);
                    }
                    else if (deleteType == "cat")
                    {
                        clinic.DeleteCat(deleteId);
                    }
                    break;
                case "6":
                    Console.Write("Show dogs or cats? (dog/cat): ");
                    string showType = Console.ReadLine();
                    clinic.ShowAnimals(showType);
                    break;
                case "7":
                    Console.Write("Enter patient name to show: ");
                    string showId = (Console.ReadLine());
                    clinic.ShowPatient(showId);
                    break;
                case "8":
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            ManagerApp.ShowFooter();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }

    static Dog CreateDog()
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

        Console.Write("Enter dog's bark volume: ");
        string barkVolume = Console.ReadLine();

        Console.Write("Enter dog's coat type (Short/Medium/Long): ");
        string coatType = Console.ReadLine();

        // agregar validaciones 

        return new Dog(
            id: 0, // Asume que el ID se asignará en otro lugar
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

    static Cat CreateCat()
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

        // agregar validaciones 

        return new Cat(
            id: 0, // Asume que el ID se asignará en otro lugar
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