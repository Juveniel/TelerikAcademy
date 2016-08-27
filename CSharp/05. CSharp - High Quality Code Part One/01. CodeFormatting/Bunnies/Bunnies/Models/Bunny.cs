namespace Bunnies.Models
{
    using System;
    using System.Text;
    using Bunnies.Contracts;
    using Bunnies.Enumerations;
    using Bunnies.Utils;

    [Serializable]
    internal class Bunny : IBunny
    {
        public Bunny()
        {
            
        }

        public Bunny(string name, int age, FurType type)
        {
            this.Name = name;
            this.Age = age;
            this.FurType = type;
        }

        public int Age { get; set; }

        public string Name { get; set; }

        public FurType FurType { get; set; }    

        public void Introduce(IWriter writer)
        {
            writer.WriteLine($"{this.Name} - \"I am {this.Age} years old!\"");
            writer.WriteLine($"{this.Name} - \"And I am {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");
        }

        public override string ToString()
        {
            const int builderSize = 200;
            var builder = new StringBuilder(builderSize);

            builder.AppendLine($"Bunny name: {this.Name}");
            builder.AppendLine($"Bunny age: {this.Age}");
            builder.AppendLine($"Bunny fur: {this.FurType.ToString().SplitToSeparateWordsByUppercaseLetter()}");

            return builder.ToString();
        }
        
    }
}
