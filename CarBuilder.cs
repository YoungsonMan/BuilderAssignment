using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderAssignment
{
    public class Car
    {
        public int year;
        public string brand;
        public string name;
        public int price;
        public string engine;
        public string horsePower;
        public string transmission;
        public double zeroSixty;
    }
    public class CarBuilder
    {
        public int year;
        public string brand;
        public string name;
        public int price;
        public string engine;
        public string horsePower;
        public string transmission;
        public double zeroSixty;

        public CarBuilder()
        {
            this.year = 2024;
            this.brand = "brand";
            this.name = "car";
            this.price = 10000;
            this.engine = "engine";
            this.horsePower = "100 to 200";
            this.transmission = "4-speed automatic";
            this.zeroSixty = 10.35f;
        }
        public Car Build()
        {
            Car car = new Car();
            car.year = year;
            car.brand = brand;
            car.name = name;
            car.price = price;
            car.engine = engine;
            car.horsePower = horsePower;
            car.transmission = transmission;
            car.zeroSixty= zeroSixty;
            return car;
        }
        public CarBuilder SetYear(int year)
        {
            this.year = year;
            return this;
        }
        public CarBuilder SetBrand(string brand)
        {
            this.brand = brand;
            return this;
        }
        public CarBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }
        public CarBuilder SetPrice(int price)
        {
            this.price = price;
            return this;
        }
        public CarBuilder SetEngine(string engine)
        {
            this.engine = engine;
            return this;
        }
        public CarBuilder SetHorsePower(string horsePower)
        {
            this.horsePower = horsePower;
            return this;
        }
        public CarBuilder SetTransmission(string transmission)
        {
            this.transmission = transmission;
            return this;
        }
        public CarBuilder SetZeroSixty(double zeroSixty)
        {
            this.zeroSixty = zeroSixty;
            return this;
        }
    }
}
