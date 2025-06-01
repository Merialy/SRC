using RCLibrary.Entities;
using System.Text.Json;

namespace RCLibrary
{
    //ToDo #2.2 Клас для всіх користувачів системи. +
    public class UserSystem : Entities.User
    {
        private static List<UserSystem> users = new();
        public static List<UserSystem> Users { get => users; }

        public static UserSystem activeUser = new();

        public bool Register(UserSystem user)
        {
            // Перевірка, що користувач з таким же e-mail ще не зареєстрований
            if (users.Any(u => u.Email == user.Email))
                return false;

            // Додавання нового користувача до списку
            users.Add(user);
            return true;
        }

        public bool Authenticate(string email, string password)
        {
            // Пошук користувача по email та паролю
            UserSystem? user = users.FirstOrDefault(u => u.Email == email && u.Password == password);

            // Якщо користувач знайдено, то вхід виконано успішно
            if (user != null)
            {
                activeUser = user;
                return true;
            }

            return false;
        }

        public static bool IsEmailAvailable(string email)
        {
            return UserSystem.Users.Any(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
        }

        public static bool ResetPassword(string email, string newPassword)
        {
            // Знаходимо користувача в головному списку
            UserSystem? user = UserSystem.Users.FirstOrDefault(u => u.Email.Equals(email, StringComparison.OrdinalIgnoreCase));

            if (user == null)
            {
                return false; // Користувача не знайдено
            }
            // Встановлюємо новий пароль
            user.Password = newPassword;

            // Оновлюємо в конкретному списку за роллю
            switch (user.TypeClass)
            {
                case "Адміністратор":
                    var admin = Administrator.Administrators.FirstOrDefault(a => a.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
                    if (admin != null) { admin.Password = newPassword; admin.Serialize(); }
                    break;

                case "Менеджер":
                    var manager = Manager.Managers.FirstOrDefault(m => m.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
                    if (manager != null) { manager.Password = newPassword; manager.Serialize(); }
                    break;

                case "Клієнт":
                    var client = Client.Clients.FirstOrDefault(c => c.Email.Equals(email, StringComparison.OrdinalIgnoreCase));
                    if (client != null) { client.Password = newPassword; client.Serialize(); }
                    break;
            }

            // Зберігаємо зміни
            user.Serialize();
            return true;
        }

        public override bool Serialize()
        {
            string jsonstring = "";
            foreach (var item in Client.Clients)
            {
                jsonstring += JsonSerializer.Serialize<UserSystem>(item);
                jsonstring += "\n";
            }

            foreach (var item in Manager.Managers)
            {
                jsonstring += JsonSerializer.Serialize<UserSystem>(item);
                jsonstring += "\n";
            }

            foreach (var item in Administrator.Administrators)
            {
                jsonstring += JsonSerializer.Serialize<UserSystem>(item);
                jsonstring += "\n";
            }

            File.WriteAllText("Users.json", jsonstring);
            return true;
        }

        public override bool Deserialize()
        {
            List<string> lines = [];
            string filePath = "Users.json";

            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            lines = [.. File.ReadAllLines(filePath)];

            if (lines.Count != 0)
            {
                UserSystem.users.Clear();
                foreach (var item in lines)
                {
                    UserSystem? account = JsonSerializer.Deserialize<UserSystem>(item);
                    if (account != null)
                        users.Add(account);
                }
            }
            return true;
        }
    }
}
