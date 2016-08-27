namespace Bunnies.Contracts
{
    using Bunnies.Enumerations;

    public interface IBunny
    {
        int Age { get; }

        string Name { get; }

        FurType FurType { get; }

        void Introduce(IWriter writer);
    }
}
   