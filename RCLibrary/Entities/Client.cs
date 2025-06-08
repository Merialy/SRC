using RCLibrary.Interfaces;
using System.ComponentModel;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace RCLibrary.Entities
{
    //ToDo #2.7 Клас для клієнта.
    public class Client : UserSystem, IClient
    {
        private static List<Client> clients = new();
        public static List<Client> Clients { get => clients; }

        private string driverLicense = string.Empty;
        private DateTime birthDate;

        private static Regex FormatDriverLicense = new(@"^[A-Za-z]{3}-\d{6}$");

        [DisplayName("Права")]
        public string? DriverLicense
        {
            get { return driverLicense; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Права не повинні бути порожніми");

                if (!FormatDriverLicense.IsMatch(value))
                    throw new ArgumentException("Неправильний формат поля права. (Наприклад: \"BXX-161565\")");
                driverLicense = value[..3].ToUpper() + value[3..];
            }
        }

        [DisplayName("Дата народження")]
        public DateTime BirthDate
        {
            get { return birthDate.Date; }
            set
            {
                if (DateTime.Now.Year - value.Year < 18)
                    throw new ArgumentException("Водій має бути старше 18 років");
                birthDate = value;
            }
        }

        public bool Register(Client newClient)
        {
            newClient.TypeClass = "Клієнт";
            // Перевірка, що користувач з таким же e-mail ще не зареєстрований
            if (Users.Any(u => u.Email == newClient.Email))
                return false;

            // Додавання нового користувача до списку
            Users.Add(newClient);
            clients.Add(newClient);
            return true;
        }

        public bool RentCar(Auto auto)
        {
            throw new NotImplementedException();
        }

        public bool ReturnCar(Auto auto)
        {
            throw new NotImplementedException();
        }

        public override bool Serialize()
        {
            string jsonstring = "";
            foreach (var item in Clients)
            {
                jsonstring += JsonSerializer.Serialize(item);
                jsonstring += "\n";
            }
            File.WriteAllText("Clients.json", jsonstring);
            return true;
        }

        public override bool Deserialize()
        {
            List<string> lines = new();
            string filePath = "Clients.json";

            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            lines = File.ReadAllLines(filePath).ToList();
            if (lines.Count != 0)
            {
                Clients.Clear();
                foreach (var item in lines)
                {
                    Client? account = JsonSerializer.Deserialize<Client>(item);
                    if (account != null)
                    {
                        clients.Add(account);
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            return base.ToString() + " (" + driverLicense + ")";
        }
    }
}