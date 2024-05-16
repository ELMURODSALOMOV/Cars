using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.CarInfo
{
    public class Car
    {
        public Car(string model, int year, decimal price, decimal speed) 
        {
            Model = model;
            Year = year;
            Price = price;
            Speed = speed;
        }

        public Car()
        {
        }

        public string Model { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public decimal Speed {  get; set; }


        public string GetCarInfo()
        {
            return $"Model: {Model}\nYear: {Year}\nPrice: {Price}";
        }

        public decimal CalculateDepreciation(int years)
        {
            decimal depreciationRate = 0.1m;
            decimal currentPrice = Price;

            for (int i = 0; i < years; i++)
            {
                currentPrice -= currentPrice * depreciationRate;
            }

            return currentPrice;
        }
    }
}