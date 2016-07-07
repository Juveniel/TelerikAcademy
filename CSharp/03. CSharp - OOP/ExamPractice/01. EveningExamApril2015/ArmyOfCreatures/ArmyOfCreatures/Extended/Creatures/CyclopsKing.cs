namespace ArmyOfCreatures.Extended.Creatures
{
    using Logic.Creatures;
    using Extended.Specialties;

    public class CyclopsKing : Creature
    {
        public CyclopsKing() 
            : base(17, 13, 70, 18)
        {
            this.AddSpecialty(new AddAttackWhenSkip(3));
            this.AddSpecialty(new DoubleAttackWhenAttacking(4));
            this.AddSpecialty(new DoubleDamage(1));
        }
    }
}
