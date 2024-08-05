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
            Console.WriteLine("8. Validate breeding");
            Console.WriteLine("9. Exit");
            ManagerApp.ShowSeparator();
            Console.Write("Choose an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Dog newDog = ManagerApp.CreateDog();
                    clinic.SaveDog(newDog);
                    break;
                case "2":
                    Cat newCat = ManagerApp.CreateCat();
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
                        Dog updatedDog = ManagerApp.CreateDog(); 
                        clinic.UpdateDog(updateId, updatedDog);
                    }
                    else if (animalType == "cat")
                    {
                        Cat updatedCat = ManagerApp.CreateCat(); 
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
                    Console.Write("Enter patient Name to show: ");
                    string showId = (Console.ReadLine());
                    clinic.ShowPatient(showId);
                    break;
                case "8":
                    Console.Write("Enter patient Name to validate if available for breeding: ");
                    string validateId = (Console.ReadLine());
                    clinic.ToBreeding(validateId);
                    break;
                case "9":
                    Environment.Exit(0);
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
}