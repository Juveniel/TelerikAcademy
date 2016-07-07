namespace ArmyOfCreatures.Extended.Creatures
{
    using Logic.Creatures;
    using Extended.Specialties;

    public class WolfRaider : Creature
    {
        public WolfRaider() 
            : base(8, 5, 10 , 3.5M)
        {
            this.AddSpecialty(new DoubleDamage(7));
        }
    }
}
