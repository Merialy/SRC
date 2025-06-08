using RCLibrary.Interfaces;
using System.Text.Json;

namespace RCLibrary.Entities
{
    //ToDo #2.3 Клас для менеджера.
    public class Manager : UserSystem, IManager
    {
        private static List<Manager> managers = new();
        public static List<Manager> Managers { get => managers; }

        // +
        public bool AddCar(Auto car)
        {
            Auto.Autos.Add(car);
            car.Serialize();
            return true;
        }

        // +
        public bool AddClient(Client newClient)
        {
            newClient.TypeClass = "Клієнт";
            bool res = Register(newClient);
            if (res)
            {
                Client.Clients.Add(newClient);
                newClient.Serialize();
                return true;
            }
            return false;
        }

        // +
        public bool RemoveCar(int value)
        {
            Auto.Autos.RemoveAt(value);
            return true;
        }
        
        // +
        public bool RemoveClient(int value)
        {
            Client.Clients.RemoveAt(value);
            return true;
        }

        public bool AddContract(Contract newContract)
        {
            if (Contract.Contracts.Count == 0)
                newContract.Id = 1;
            else
                newContract.Id = Contract.Contracts[Contract.Contracts.Count - 1].Id + 1;
            
            Contract.Contracts.Add(newContract);
            newContract.Serialize();
            return true;
        }

        public bool RemoveContract(int value)
        {
            Contract.Contracts.RemoveAt(value);
            return true;
        }

        public override bool Serialize()
        {
            string jsonstring = "";
            foreach (var item in Managers)
            {
                jsonstring += JsonSerializer.Serialize(item);
                jsonstring += "\n";
            }
            File.WriteAllText("Managers.json", jsonstring);
            return true;
        }

        public override bool Deserialize()
        {
            List<string> lines = new();
            string filePath = "Managers.json";

            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            lines = File.ReadAllLines(filePath).ToList();
            if (lines.Count != 0)
            {
                Managers.Clear();
                foreach (var item in lines)
                {
                    Manager? account = JsonSerializer.Deserialize<Manager>(item);
                    if (account != null)
                    {
                        managers.Add(account);
                    }
                }
            }
            return true;
        }
    }
}
