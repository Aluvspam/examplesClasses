using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curs25.Visitor
{
    public class RunExamples
    {
        public static void Run()
        {
            Player p = new Player();
            p.AddAsset(new Farm() {
                Id = "1",
                Life = 100,
                X = 10,
                Y = 5
            });

            p.AddAsset(new Peasant()
            {
                Id = "2",
                X = 22,
                Y = 1
            });

            Serializer csvSerializer = new CsvSerializer();
            Serializer xmlSerializer = new XmlSerializer();
            //var text = p.Save(csvSerializer);
            var text = p.Save(xmlSerializer);
        }
    }
}
