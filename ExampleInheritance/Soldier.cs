using System;

namespace ExampleInheritance
{
    public sealed class Soldier : AbstractArmyUnit
    {
        private int armor;
        public override void Atac(AbstractArmyUnit target)
        {
            throw new NotImplementedException();
        }
        public Soldier()
        {
            hitPoints = 100;
            armor = 2;
        }
        public override void TakeDamage(int damage)
        {
            int armorDamage = armor * damage / 100;
            armor -= armorDamage;
            base.TakeDamage(damage);
            hitPoints = hitPoints + armorDamage;
        }
    }
}
