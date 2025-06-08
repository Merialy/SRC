using RCLibrary.Interfaces;
using System.ComponentModel;
using System.Text.Json;

namespace RCLibrary.Entities
{
    //ToDo #2.8 Клас договор +
    public class Contract : IFile
    {
        private static List<Contract> contracts = new();
        public static List<Contract> Contracts { get => contracts; }

        private int id = 0;
        private Auto? car = new();
        private Client? renter = new();
        private Manager? employee = new();
        private DateTime startDate;
        private DateTime endDate;
        private int? rentalPrice = 0;

        [DisplayName("Номер договору")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Орендар")]
        public Client? Renter
        {
            get { return renter; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Для оренди має бути обраний орендодавець!");

                renter = value;
            }
        }

        [DisplayName("Автомобіль")]
        public Auto? Car
        {
            get { return car; }
            set
            {
                if (value == null)
                    throw new ArgumentException("Для оренди має бути обраний автомобіль!");

                car = value;
            }
        }

        [DisplayName("Працівник")]
        public Manager? Employee
        {
            get { return employee; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Для оренди має бути обраний працівник!");

                employee = value;
            }
        }

        [DisplayName("Дата початку оренди")]
        public DateTime StartDate
        {
            get => startDate;
            set => startDate = value;
        }

        [DisplayName("Дата закінчення оренди")]
        public DateTime EndDate
        {
            get => endDate;
            set => endDate = value;
        }

        [DisplayName("Ціна оренди (грн)")]
        public int? RentalPrice
        {
            get {
                if (endDate < startDate)
                    rentalPrice = 0;
                else 
                    rentalPrice = ((int)(endDate - startDate).TotalDays + 1) * car?.DailyPrice;
                return rentalPrice;
            }
        }

        public bool Serialize()
        {
            string jsonstring = "";
            foreach (var item in Contracts)
            {
                jsonstring += JsonSerializer.Serialize(item);
                jsonstring += "\n";
            }
            File.WriteAllText("Contracts.json", jsonstring);
            return true;
        }

        public bool Deserialize()
        {
            List<string> lines = new();
            string filePath = "Contracts.json";

            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            lines = File.ReadAllLines(filePath).ToList();
            if (lines.Count != 0)
            {
                contracts.Clear();
                foreach (var item in lines)
                {
                    Contract? account = JsonSerializer.Deserialize<Contract>(item);
                    if (account != null)
                    {
                        contracts.Add(account);
                    }
                }
            }
            return true;
        }
    }
}