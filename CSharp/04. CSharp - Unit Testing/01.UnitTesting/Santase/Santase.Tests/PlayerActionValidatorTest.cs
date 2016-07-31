

namespace Santase.Tests
{
    using System.Collections.Generic;
    using System.Linq;
    using Logic;
    using Logic.Cards;
    using Logic.Players;
    using NUnit.Framework;

    [TestFixture]
    public class PlayerActionValidatorTest
    {
        [Test]
        public void IsValid_ShouldReturnFalse_WhenActionIsNull()
        {
            var action = new PlayerAction(null, new Card(CardSuit.Club, CardType.Ace));
        }
    }
}
