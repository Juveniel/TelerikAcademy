using System;
using System.Text;

namespace _01.DefineClass
{
    public class Display
    {
        private int size;
        private int? numberOfColors;

        public Display()
        {

        }

        public Display(int size) : this(size, null)
        {

        }

        public Display(int size, int? numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }

        public int Size
        {
            get { return this.size; }
            set
            {
                if(value >= 0)
                {
                    this.size = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public int? NumberOfColors
        {
            get { return this.numberOfColors; }
            set
            {
                if(value == null || value >= 0)
                {
                    this.numberOfColors = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }

        public override string ToString()
        {
            var displayCharacteristics = new StringBuilder();
            displayCharacteristics.AppendLine("Display characteristics: ");
            displayCharacteristics.AppendLine("===============================");
            displayCharacteristics.Append("Display size: ").Append(this.size.ToString()).AppendLine();
            displayCharacteristics.Append("Display umber of colors: ").Append(this.numberOfColors.ToString()).AppendLine();
            displayCharacteristics.AppendLine("===============================");

            return displayCharacteristics.ToString();
        }
    }
}
