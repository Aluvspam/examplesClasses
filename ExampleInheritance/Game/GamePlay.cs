using System.Collections.Generic;

namespace Solid_Examples.Game
{
    public class GamePlay
    {
        private static GamePlay instance;
        public static GamePlay Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GamePlay();
                }
                return instance;
            }
        }
        public void Start()
        {
            List<AbstractUnit> units = new List<AbstractUnit>();
            units.Add(new Marine(new Point[1] { new Point(5, 7) }));
            units.Add(new MissileLauncher(new Point[2] { new Point(3, -2), new Point(3, -1) }));
            units.Add(new Tank(new Point [1] {new Point(0,9)}));
        }
    }
}
