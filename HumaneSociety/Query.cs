using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        internal static Client GetClient(string userName, string password)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void RunEmployeeQueries(Employee employee, string v)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static IQueryable<ClientAnimalJunction> GetUserAdoptionStatus(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static Animal GetAnimalByID(int iD)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void Adopt(object animal, Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void PurchaseAnimal()
        {
            Animal animal = new Animal();
            bankAccount bankAccount = new bankAccount();
            bankAccount.account += animal.price;
        }

        internal static IQueryable<Client> RetrieveClients()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void AddAnimal(Animal animal)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            database.Animals.InsertOnSubmit(animal);
            database.SubmitChanges();
        }

        internal static void AddNewClient(string firstName, string lastName, string username, string password, string email, string streetAddress, int zipCode, int state)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void AddUsernameAndPassword(Employee employee)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static bool CheckEmployeeUserNameExist(string username)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static Employee EmployeeLogin(string userName, string password)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void EnterUpdate(Animal animal, Dictionary<int, string> updates)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static int? GetBreed()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static IQueryable<ClientAnimalJunction> GetPendingAdoptions()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static int? GetDiet()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void UpdateLocation(Animal animal)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Room room = new Room();
            Console.WriteLine("This pet is currently in room # " + animal.location + " It can be moved into the following rooms:");
            var roomNumber = database.Animals.Where(a => a.name == null);
            Console.WriteLine(roomNumber);
        }

        internal static int? GetLocation()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Animal animal = new Animal();
            Console.WriteLine("What is the pet's name?");
            string petName = Console.ReadLine();
            var roomNumber = database.Animals.Where(a => a.name == petName).Select(a => a.location);
            database.SubmitChanges();
            return animal.location;
        }

        internal static IQueryable<AnimalShotJunction> GetShots(Animal animal)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static IQueryable<USState> GetStates()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void RemoveAnimal(Animal animal)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static Employee RetrieveEmployeeUser(string email, int employeeNumber)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void UpdateAddress(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void UpdateAdoption(bool v, ClientAnimalJunction clientAnimalJunction)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Animal animal = new Animal();
            animal.adoptionStatus = "adopted";
            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void updateClient(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }
        internal static void UpdateShot(string v, Animal animal)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void UpdateUsername(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void UpdateLastName(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void UpdateFirstName(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static void UpdateEmail(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

    }
}
