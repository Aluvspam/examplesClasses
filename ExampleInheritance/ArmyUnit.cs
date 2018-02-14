using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleInheritance
{
    public abstract class AbstractArmyUnit
    {
        protected int hitPoints;
        protected int maxHP;

        public virtual void Regenerate()
        {
            hitPoints = maxHP;
        }
        public virtual void TakeDamage(int damage)
        {
            hitPoints = hitPoints - damage;
        }
        public virtual void TestMethods()
        {
            Regenerate();
            TakeDamage(10);
        }
        public abstract void Atac(AbstractArmyUnit target);

    }
}
