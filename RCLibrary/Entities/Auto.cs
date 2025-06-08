using RCLibrary.Interfaces;
using System.ComponentModel;
using System.Text.Json;

namespace RCLibrary.Entities
{
    //ToDo #2.5 Клас автомобіль +
    public class Auto : IFile
    {
        private static List<Auto> autos = new();
        public static List<Auto> Autos { get => autos; }

        public Guid Id { get; set; } = Guid.NewGuid();
        private string brand = string.Empty;
        private string model = string.Empty;
        private int? dailyPrice = 0;

        [DisplayName("Бренд")]
        public string? Brand
        {
            get => brand;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Необхідно вказати бренд автомобіля.");
                if (value.Length > 15)
                    throw new ArgumentException("Бренд автомобіля надто довгий!");
                brand = value;
            }
        }

        [DisplayName("Модель")]
        public string? Model
        {
            get => model;
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Потрібно вказати модель автомобіля.");
                if (value.Length > 15)
                    throw new ArgumentException("Модель автомобіля надто довга!");
                model = value;
            }
        }

        [DisplayName("Клас авто")]
        public classAuto? Aclass { get; set; }

        [DisplayName("Тип КПП")]
        public gearboxType? Atype { get; set; }

        [DisplayName("Колір")]
        public colorAuto? Acolor { get; set; }

        [DisplayName("Ціна оренди (грн/добу)")]
        public int? DailyPrice
        {
            get => dailyPrice;
            set
            {
                if (value < 800)
                    throw new ArgumentException("Оренда автомобіля має бути більше 800 грн.");
                if (value > 10000)
                    throw new ArgumentException("Оренда автомобіля має бути меншою за 10 000 грн.");

                dailyPrice = value;
            }
        }

        public bool Serialize()
        {
            string jsonstring = "";
            foreach (var item in Autos)
            {
                jsonstring += JsonSerializer.Serialize(item);
                jsonstring += "\n";
            }
            File.WriteAllText("Autos.json", jsonstring);
            return true;
        }

        public bool Deserialize()
        {
            List<string> lines = new();
            string filePath = "Autos.json";

            if (!File.Exists(filePath))
                File.Create(filePath).Close();

            lines = File.ReadAllLines(filePath).ToList();
            if (lines.Count != 0)
            {
                Autos.Clear();
                foreach (var item in lines)
                {
                    Auto? car = JsonSerializer.Deserialize<Auto>(item);
                    if (car != null)
                    {
                        autos.Add(car);
                    }
                }
            }
            return true;
        }

        public override string ToString()
        {
            return $"{brand} {model} ({Aclass}, {Atype}, {Acolor})";
        }
    }
}