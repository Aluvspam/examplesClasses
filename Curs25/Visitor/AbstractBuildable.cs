using System;

namespace Curs25.Visitor
{
    abstract class Serializer
    {
        public abstract string VisitFarm(Farm farm);
        public abstract string VisitPeasnt(Peasant peasant);
    }

    class CsvSerializer : Serializer
    {
        public override string VisitFarm(Farm farm)
        {
            string res = "type:Farm " + " { " + farm.Id + "-" + farm.Life + "-" + farm.X + "-" + farm.Y + "}";
            return res;
        }

        public override string VisitPeasnt(Peasant peasant)
        {
            string res = "type:Peasant " + " { " + peasant.Id + "-" + peasant.X + "-" + peasant.Y + "}";
            return res;
        }
    }

    class XmlSerializer : Serializer
    {
        public override string VisitFarm(Farm farm)
        {
            string res = "type:Farm " + " < " + farm.Id + "-" + farm.Life + "-" + farm.X + "-" + farm.Y + ">";
            return res;
        }

        public override string VisitPeasnt(Peasant peasant)
        {
            string res = "type:Peasant " + " < " + peasant.Id + "-" + peasant.X + "-" + peasant.Y + ">";
            return res;
        }
    }

    abstract class AbstractBuildable
    {
        public abstract string Save(Serializer v);
    }

    interface JsonSave
    {

    }

    class Peasant : AbstractBuildable
    {
        public string Id;
        public int X;
        public int Y;

        public override string Save(Serializer v)
        {
            return v.VisitPeasnt(this);
        }
    }

    class Farm : AbstractBuildable
    {
        public string Id;
        public int Life;
        public int X;
        public int Y;

        public override string Save(Serializer v)
        {
           return v.VisitFarm(this);
        }
    }
}
