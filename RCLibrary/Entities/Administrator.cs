using RCLibrary.Interfaces;
using System.Text.Json;

namespace RCLibrary.Entities
{
    // ToDo #2.4 Клас для адміністратора. +
    public class Administrator : Manager, IAdministrator
    {
        private static List<Administrator> administrators = new();
        public static List<Administrator> Administrators { get => administrators; }

        // Додавання менеджера +
        public bool AddManager(Manager newManager)
        {
            newManager.TypeClass = "Менеджер";
            bool res = Register(newManager);
            if (res)
            {
                Managers.Add(newManager);
                newManager.Serialize();
                return true;
            }
            return false;
        }

        // Видалення менеджера +
        public bool RemoveManager(int value)
        {
            Managers.RemoveAt(value);
            return true;
        }

        // Додавання адміністратора +
        public bool AddAdmin(Administrator newAdmin)
        {
            newAdmin.TypeClass = "Адміністратор";
            bool res = Register(newAdmin);
            if (res)
            {
                administrators.Add(newAdmin);
                newAdmin.Serialize();
                return true;
            }
            return false;
        }

        // Видалення администратора +
        public bool RemoveAdmin(int value)
        {
            administrators.RemoveAt(value);
            return true;
        }

        public override bool Serialize()
        {
            string jsonstring = "";
            foreach (var item in Administrators)
            {
                jsonstring += JsonSerializer.Serialize(item);
                jsonstring += "\n";
            }
            File.WriteAllText("Admins.json", jsonstring);
            return true;
        }

        public override bool Deserialize()
        {
            List<string> lines = new();
            string filePath = "Admins.json";

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
                AddAdmin(new Administrator() { 
                    Email = "root@gmail.com", FirstName = "root", LastName = "root", 
                    Password = "Admin_01", PhoneNumber = "0999999999", TypeClass = "Адміністратор"
                });
            }

            lines = File.ReadAllLines(filePath).ToList();
            if (lines.Count != 0)
            {
                administrators.Clear();
                foreach (var item in lines)
                {
                    Administrator? account = JsonSerializer.Deserialize<Administrator>(item);
                    if (account != null)
                    {
                        administrators.Add(account);
                    }
                }
            }
            return true;
        }
    }
}