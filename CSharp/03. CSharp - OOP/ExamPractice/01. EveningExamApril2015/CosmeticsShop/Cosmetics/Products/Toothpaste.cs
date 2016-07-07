namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Common;
    using Contracts;

    public class Toothpaste : Product, IToothpaste
    {
        private const int IngredientMinLength = 4;
        private const int IngredientMaxLength = 12;

        private readonly IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.ValidateIngredients(ingredients);
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); }
        }

        public void ValidateIngredients(IList<string> ingredients)
        {
            if (ingredients.Any(x => x.Length < IngredientMinLength || x.Length > IngredientMaxLength))
            {
                throw new ArgumentOutOfRangeException(
                    string.Format(GlobalErrorMessages.InvalidStringLength, "Each ingredient", IngredientMinLength, IngredientMaxLength));
            }
        }

        public override string Print()
        {
            var toothpasteInformation = new StringBuilder();
            toothpasteInformation.AppendLine(base.Print());
            toothpasteInformation.AppendLine(string.Format("  * Ingredients: {0}", this.Ingredients));

            return toothpasteInformation.ToString().Trim();
        }
    }
}