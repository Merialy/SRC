using System.ComponentModel;
using System.Text.RegularExpressions;
using RCLibrary.Interfaces;

namespace RCLibrary.Entities
{
    //ToDo #2.1 Абстрактний клас для користувачів системи. +
    public abstract class User : IFile
    {
        private string email = string.Empty;
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string middleName = "-";
        private string phoneNumber = string.Empty;
        private string password = string.Empty;

        private static Regex FormatEmail = new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        [DisplayName("Електронна пошта")]
        public string? Email
        {
            get => email;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Електронна пошта не повинна бути порожньою!");
                if (!FormatEmail.IsMatch(value))
                    throw new ArgumentException("В електронній пошті має бути символ \"@\" та \".\". (Наприклад: \"user@gmail.com\")");
                email = value.ToLower();
            }
        }

        [DisplayName("Прізвище")]
        public string? LastName
        {
            get => lastName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Прізвище не повинно бути порожнім");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("Прізвище має складатися лише з літер");
                lastName = value;
            }
        }

        [DisplayName("Ім'я")]
        public string? FirstName
        {
            get => firstName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Ім'я не повинно бути порожнім");
                if (value.Any(char.IsDigit))
                    throw new ArgumentException("Ім'я має складатися лише з літер");
                firstName = value;
            }
        }

        [DisplayName("По-батькові")]
        public string? MiddleName
        {
            get => middleName;
            set
            {
                if (string.IsNullOrEmpty(value))
                    middleName = "-";
                else if (value.Any(char.IsDigit))
                    throw new ArgumentException("По-батькові має складатися тільки з літер");
                else
                    middleName = value;
            }
        }

        [DisplayName("Номер телефону")]
        public string? PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Номер телефону не повинен бути порожнім");
                else if(value.Length != 10)
                    throw new ArgumentException("У номері телефону має бути 10 цифр");

                long.Parse(value); // Пытаемся преобразовать строку в число
                phoneNumber = value;
            }
        }

        [DisplayName("Пароль")]
        public string? Password
        {
            get => password;
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 8)
                    password = value;
                else
                    throw new ArgumentException("Пароль повинен бути не порожнім і мати хоча б 8 символів");
            }
        }

        [DisplayName("Роль")]
        public string? TypeClass { get; set; }

        public abstract bool Serialize();
        public abstract bool Deserialize();

        public override string ToString()
        {
            return $"{lastName} {FirstLetter(firstName)}.{FirstLetter(middleName)}.";
        }

        private string FirstLetter(string? s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return s[0].ToString().ToUpper();
        }
    }
}
