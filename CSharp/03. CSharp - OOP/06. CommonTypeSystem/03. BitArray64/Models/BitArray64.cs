namespace BitArray64.Models
{
    using System;   
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        public BitArray64(ulong number)
        {
            this.Number = number;
        }

        public ulong Number
        {
            get
            {
                return this.number;
            }

            set
            {
                if (value < ulong.MinValue || value > ulong.MaxValue)
                {
                    throw new ArgumentOutOfRangeException("Value not in range!");
                }

                this.number = value;
            }
        }
       
        public ulong this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }

                return (this.number >> index) & 1;
            }

            set
            {
                if (value != 0 && value != 1)
                {
                    throw new ArgumentException("value must be 0 or 1!");
                }

                this.number &= ~(ulong)(1 << index);
                this.number |= value << index;
            }
        }

        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !first.Equals(second);
        }

        public override bool Equals(object obj)
        {
            BitArray64 val = obj as BitArray64;

            if (obj == null)
            {
                return false;
            }
            else
            {
                return this.number.Equals(val.number);
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 63; i >= 0; i--)
            {
                yield return (int)(this.number >> i) & 1;
            }                
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }       

        public override int GetHashCode()
        {
            unchecked
            {
                int result = 17;
                result = (result * 29) + this.number.GetHashCode();

                return result;
            }
        }       

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();

            info.Append("Binary: ");

            for (int i = 63; i >= 0; i--)
            {
                info.Append((this.number >> i) & 1);

                if (i % 4 == 0)
                {
                    info.AppendFormat(" ");
                }                    
            }

            info.AppendLine("\nDecimal: " + this.number);

            return info.ToString();
        }

        private int[] GetBits(ulong input)
        {
            int[] result = new int[64];
            int bitIndex = 63;

            while (input != 0)
            {
                result[bitIndex] = (int)(input % 2);

                bitIndex--;
                input >>= 1;
            }

            return result;
        }
    }
}
