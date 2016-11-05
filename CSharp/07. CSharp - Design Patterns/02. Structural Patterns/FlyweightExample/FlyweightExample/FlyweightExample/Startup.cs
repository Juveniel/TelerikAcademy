using FlyweightExample.Factory;
using FlyweightExample.Models;

namespace FlyweightExample
{
    internal class Startup
    {
        internal static void Main()
        {
            const string document = "AABBAB";
            char[] characters = document.ToCharArray();

            var factory = new CharacterFactory();
            int pointSize = 10;

            // For each character use a flyweight object
            foreach (var ch in characters)
            {
                pointSize++;
                Character character = factory.GetCharacter(ch);

                character.Display(pointSize);
            }
        }
    }
}
