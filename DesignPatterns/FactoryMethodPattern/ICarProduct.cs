using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethodPattern
{
    public interface ICarProduct
    {
        int Weels { get; }
        string Name { get; }
        double Engine { get; }//capacitatea cilindrica
        string Gadgets { get; }
        string Color { get; }
        int Doors { get; }
        CarType BodyModel { get; }
    }
    public enum CarType
    {
        hatchback, limousine
    }
}
