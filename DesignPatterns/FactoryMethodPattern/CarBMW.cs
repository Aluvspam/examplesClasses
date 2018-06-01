using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public class CarBMW : ICarProduct
    {
        int _weels = 4;
        string _name = "BMW 120";
        double _engine = 2.0;
        string _gadgets = "full option";
        string _color = "black";
        int _doors = 3;
        CarType _bodyModel = CarType.hatchback;
        public CarType BodyModel
        {
            get
            {
                return _bodyModel;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
        }
        public int Doors
        {
            get
            {
                return _doors;
            }
        }
        public double Engine
        {
            get
            {
                return _engine;
            }
        }
        public string Gadgets
        {
            get
            {
                return _gadgets;
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
        }
        public int Weels
        {
            get
            {
                return _weels;
            }
        }
    }
}
