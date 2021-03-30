﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.StructuralPatterns.Flyweight
{
    public class Client
    {
        public static void Execute()
        {
            var factory = new CarFlyweightFactory(new List<CarFlyweight>
            {
                new CarFlyweight { Manufacturer = "Chevrolet", Model = "Camaro", Color = "Orange" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "White" },
                new CarFlyweight { Manufacturer = "Opel", Model = "Astra I", Color = "Pink" },
                new CarFlyweight { Manufacturer = "Opel", Model = "Astra II", Color = "Blue" },
                new CarFlyweight { Manufacturer = "BMW", Model = "X6", Color = "Orange" }
            });

            factory.ListFlyweights();

            var car1 = new Car
            {
                Owner = "John Doe",
                Number = "AMS8786",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Pink"
            };
            car1.CarFlyweight = factory.GetFlyweight(car1.CarFlyweight);
            factory.ListFlyweights();

            var car2 = new Car
            {
                Owner = "Ewa Ewowska",
                Number = "AAMS886",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Black"
            };
            car2.CarFlyweight = factory.GetFlyweight(car2.CarFlyweight);
            factory.ListFlyweights();

            var car3 = new Car
            {
                Owner = "Ewa Ewowska",
                Number = "ASK99210",
                Manufacturer = "Opel",
                Model = "Astra I",
                Color = "Black"
            };
            car3.CarFlyweight = factory.GetFlyweight(car3.CarFlyweight);
            factory.ListFlyweights();

            car2.CarFlyweight.Operate(car2);
            car3.CarFlyweight.Operate(car3);

            //car3.Manufacturer = "ABC";
            car3.CarFlyweight = factory.GetFlyweight(new CarFlyweight { Manufacturer = "ABC", Color = car3.Color, Model = car3.Model });
            car2.CarFlyweight.Operate(car2);
            car3.CarFlyweight.Operate(car3);
        }
    }
}
