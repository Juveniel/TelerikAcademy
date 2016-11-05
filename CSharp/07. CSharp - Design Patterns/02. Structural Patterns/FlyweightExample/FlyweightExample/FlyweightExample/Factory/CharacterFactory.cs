using System.Collections.Generic;
using FlyweightExample.Models;

namespace FlyweightExample.Factory
{
    public class CharacterFactory
    {
        private readonly IDictionary<char, Character> characters = new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            Character character = null;

            if (characters.ContainsKey(key))
            {
                character = characters[key];
            }
            else
            {
                switch (key)
                {
                    case 'A': character = new CharacterA(); break;
                    case 'B': character = new CharacterB(); break;
                }

                characters.Add(key, character);

            }

            return character;
        }
    }
}
