using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._10_Modifiers
{
    public class Car
    {
        //Protected allows our properties only accessible to our child classes.
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }

        public string CarDetails()
        {
            return $"Make: {Make}\nModel: {Model}\nYear: {Year}";
        }

    }

    public class Lotus : Car
    {
        //The private protects our variable from being changed without creating an object
        private int price;
        public Lotus(string model, int year, int price = 20000)
        {
            this.Make = "Lotus";
            this.Model = model;
            this.Year = year;
            this.price = price;
        }

        public void LotusDetails()
        {
            Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\nPrice: {price}");
        }
    }
}