﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Query
    {
        public delegate void EmployeeOperator(Employee employee);

        internal static Client GetClient(string userName, string password)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        public static void RunEmployeeQueries(Employee employee, string crudOperation)
        {
            EmployeeOperator EOP = setDelegate(crudOperation);
            EOP(employee);
        }

        private static EmployeeOperator setDelegate(string crudOperation)
        {
            

            switch (crudOperation)
            {
                case "create":
                    return new EmployeeOperator(EmployeeCreator);
                case "read":
                    return new EmployeeOperator(EmployeeReader);
                case "update":
                    return new EmployeeOperator(EmployeeUpdater);
                case "delete":
                    return new EmployeeOperator(EmployeeDeleter);
                default:
                    return new EmployeeOperator(EmployeeReader);
            }
        }

        public static void EmployeeCreator(Employee employee)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            database.Employees.InsertOnSubmit(employee);
            database.SubmitChanges();
        }

        public static void EmployeeReader(Employee employee)
        {
            
        }

        public static void EmployeeUpdater(Employee employee)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            database.Employees.InsertOnSubmit(employee);
            database.SubmitChanges();
        }

        public static void EmployeeDeleter(Employee employee)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            database.Employees.DeleteOnSubmit(employee);
            database.SubmitChanges();
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

        internal static void AddNewClient(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            database.Clients.InsertOnSubmit(client);
            database.SubmitChanges();
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

        internal static int? GetBreed(string breedName, string patternType)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var breedQueries = (
                from breedQuery in database.Breeds
                where breedName == breedQuery.breed1 && patternType == breedQuery.pattern
                select breedQuery).ToList();
            if (breedQueries.Count == 0)
            {
                Breed breed = new Breed();
                breed.breed1 = breedName;
                breed.pattern = patternType;
                database.Breeds.InsertOnSubmit(breed);
                database.SubmitChanges();
                breedQueries.Add(breed);
            }
            return breedQueries[0].ID;
            throw new NotImplementedException();
        }

        internal static IQueryable<ClientAnimalJunction> GetPendingAdoptions()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

            database.SubmitChanges();
            throw new NotImplementedException();
        }

        internal static int? GetDiet(string foodType, int foodAmount)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var dietQueries = (
                from dietQuery in database.DietPlans
                where foodType == dietQuery.food && foodAmount == dietQuery.amount
                select dietQuery).ToList();
            if (dietQueries.Count == 0)
            {
                DietPlan dietplan = new DietPlan();
                dietplan.food = foodType;
                dietplan.amount = foodAmount;
                database.DietPlans.InsertOnSubmit(dietplan);
                database.SubmitChanges();
            }
            return dietQueries[0].ID;
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
            Console.WriteLine("Please enter the animal's ID number");
            int animalID = int.Parse(Console.ReadLine());
            var shots = database.AnimalShotJunctions.Where(a => a.Animal_ID == animalID);
            return shots;
        }

        public static Shot GetShot(int shotId)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var shot = database.Shots.Where(s => s.ID == shotId).First();
            return shot;
        }

        public static void UpdateShot(int shotId, Animal animal)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var updateShot = database.AnimalShotJunctions.Where(s => s.Animal_ID == animal.ID && s.Shot_ID == shotId).First();
            updateShot.dateRecieved = DateTime.Now;

            database.SubmitChanges();
        }

        public static void AddShot(Shot shot, Animal animal)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            AnimalShotJunction shotUpdate = new AnimalShotJunction();
            shotUpdate.Animal_ID = animal.ID;
            shotUpdate.dateRecieved = DateTime.Now;
            shotUpdate.Shot_ID = shot.ID;

            database.AnimalShotJunctions.InsertOnSubmit(shotUpdate);
            database.SubmitChanges();
        }

        public static IQueryable<Shot> GetAllShots()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            return database.Shots;
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
            database.Animals.DeleteOnSubmit(animal);
            database.SubmitChanges();
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
            var addressUpdate = database.Clients.Where(c => c.ID == client.ID);
            database.Clients.InsertOnSubmit(client);
            database.SubmitChanges();
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
            database.Clients.DeleteOnSubmit(client);
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
            var usernameUpdate = database.Clients.Where(c => c.ID == client.ID);
            database.Clients.InsertOnSubmit(client);
            database.SubmitChanges();
        }

        internal static void UpdateLastName(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var lastNameUpdate = database.Clients.Where(c => c.ID == client.ID);
            database.Clients.InsertOnSubmit(client);
            database.SubmitChanges();
        }

        internal static void UpdateFirstName(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var firstNameUpdate = database.Clients.Where(c => c.ID == client.ID);
            database.Clients.InsertOnSubmit(client);
            database.SubmitChanges();
        }

        internal static void UpdateEmail(Client client)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var emailUpdate = database.Clients.Where(c => c.ID == client.ID);
            database.Clients.InsertOnSubmit(client);
            database.SubmitChanges();
        }

    }
}
