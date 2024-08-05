// using veterinaryCenter.Models;

// void Menu()
// {
//     Console.Clear();
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine("|            Veterinary Center             |");
//     Console.WriteLine("--------------------------------------------");
//     Console.WriteLine("| 1.  Add driver                           |");
//     Console.WriteLine("| 2.  Delete driver                        |");
//     Console.WriteLine("| 3.  Show drivers                         |");
//     Console.WriteLine("| 4.  Update driver                        |");
//     Console.WriteLine("| 5.  Add customer                         |");
//     Console.WriteLine("| 6.  Delete customer                      |");
//     Console.WriteLine("| 7.  Show customers                       |");
//     Console.WriteLine("| 8.  Update customer                      |");
//     Console.WriteLine("| 9.  Add vehicle                          |");
//     Console.WriteLine("| 10. Delete vehicle                       |");
//     Console.WriteLine("| 11. Show vehicles                        |");
//     Console.WriteLine("| 12. Update vehicle                       |");
//     Console.WriteLine("| 13. Users older than 30                  |");
//     Console.WriteLine("| 14. Drivers ordered by experience (dec)  |");
//     Console.WriteLine("| 15. Customers that pays with credit card |");
//     Console.WriteLine("| 16. Drivers with 'A2' license            |");
//     Console.WriteLine("| 17. Exit                                 |");
//     Console.WriteLine("--------------------------------------------");
//     Console.Write("Write the number of the option that you want: ");
//     int option = int.Parse(Console.ReadLine());

//     switch (option)
//     {
//         case 1:
//             Console.Clear();
//             AddDriver();
//             getMenu();
//             break;
//         case 2:
//             Console.Clear();
//             ShowDrivers();
//             DeleteDriver();
//             getMenu();
//             break;
//         case 3:
//             Console.Clear();
//             ShowDrivers();
//             getMenu();
//             break;
//         case 4:
//             Console.Clear();
//             ShowDrivers();
//             UpdateDriver();
//             getMenu();
//             break;
//         case 5:
//             Console.Clear();
//             AddCustomer();
//             getMenu();
//             break;
//         case 6:
//             Console.Clear();
//             ShowCustomers();
//             DeleteCustomer();
//             getMenu();
//             break;
//         case 7:
//             Console.Clear();
//             ShowCustomers();
//             getMenu();
//             break;
//         case 8:
//             Console.Clear();
//             ShowCustomers();
//             UpdateCustomer();
//             getMenu();
//             break;
//         case 9:
//             Console.Clear();
//             ShowDrivers();
//             AddVehicle();
//             getMenu();
//             break;
//         case 10:
//             Console.Clear();
//             ShowVehicles();
//             DeleteVehicle();
//             getMenu();
//             break;
//         case 11:
//             Console.Clear();
//             ShowVehicles();
//             getMenu();
//             break;
//         case 12:
//             Console.Clear();
//             ShowVehicles();
//             UpdateVehicle();
//             getMenu();
//             break;
//         default:
//             Console.WriteLine("Invalid option.");
//             getMenu();
//             break;
//     }
//  }

// Menu();
using veterinaryCenter.Models;
class Program
{
    static void Main(string[] args)
    {
        VeterinaryClinic clinic = new VeterinaryClinic("Pet Care", "123 Main St");

        while (true)
        {
            ManagerApp.ShowHeader();
            Console.WriteLine("1. Add Dog");
            Console.WriteLine("2. Add Cat");
            Console.WriteLine("3. Show All Patients");
            Console.WriteLine("4. Exit");
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
                    return;
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