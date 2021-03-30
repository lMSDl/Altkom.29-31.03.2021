﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.CreationalPatterns.AbstractFactory
{
    class Order
    {
        private readonly ICar _car;

        public Order(ICarFactory factory, string type, string segment)
        {
            switch(type)
            {
                case nameof(ISedan):
                    _car = factory.ManufactureSedan(segment);
                    break;
                case nameof(ISuv):
                    _car = factory.ManufactureSuv(segment);
                    break;
            }
        }

        /*public Order(string manufacturer, string type, string segment)
        {
            switch (manufacturer)
            {
                case "Honda":
                    switch (type)
                    {
                        case nameof(ISedan):
                            switch (segment)
                            {
                                case "compact":
                                    _car = new HondaCompactSedan();
                                    break;
                                case "full":
                                    _car = new HondaFullSedan();
                                    break;
                            }
                            break;
                        case nameof(ISuv):
                            switch (segment)
                            {
                                case "compact":
                                    _car = new HondaCompactSuv();
                                    break;
                                case "full":
                                    _car = new HondaFullSuv();
                                    break;
                            }
                            break;
                    }
                    break;
                case "Toyota":
                    switch (type)
                    {
                        case nameof(ISedan):
                            switch (segment)
                            {
                                case "compact":
                                    _car = new ToyotaCompactSedan();
                                    break;
                                case "full":
                                    _car = new ToyotaFullSedan();
                                    break;
                            }
                            break;
                        case nameof(ISuv):
                            switch (segment)
                            {
                                case "compact":
                                    _car = new ToyotaCompactSuv();
                                    break;
                                case "full":
                                    _car = new ToyotaFullSuv();
                                    break;
                            }
                            break;
                    }
                    break;
            }
        }*/

        public string ManufacturedCarName()
        {
            return _car.Name();
        }
    }
}
