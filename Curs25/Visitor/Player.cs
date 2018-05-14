using System.Collections.Generic;

namespace Curs25.Visitor
{
    class Player
    {
        List<AbstractBuildable> assets = new List<AbstractBuildable>();

        public Player()
        {
            assets = new List<AbstractBuildable>();
        }

        public void AddAsset(AbstractBuildable a)
        {
            assets.Add(a);
        }

        public string Save(Serializer v)
        {
            var res = "";
            foreach (var asset in assets)
            {
                res += asset.Save(v);
            }
            return res;
        }
    }
}
