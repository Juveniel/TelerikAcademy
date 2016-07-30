namespace Poker.Contracts
{
    using Enumerations;

    public interface ICard
    {
        CardFace Face { get; }

        CardSuit Suit { get; }

        string ToString();
    }
}
