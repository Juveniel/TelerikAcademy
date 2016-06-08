namespace _02.GenericList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class GenericList<T> where T : IComparable
    {
        private const int DefaultCapacity = 1000;
        private T[] elements;

        public GenericList(int capacity = DefaultCapacity)
        {
            this.Count = 0;
            this.Capacity = capacity;
            this.elements = new T[DefaultCapacity];
        }

        public int Capacity { get; set; }

        public int Count { get; set; }

        public T this[int index]
        {
            get
            {
                return this.elements[index];
            }

            set
            {
                this.elements[index] = value;
            }
        }

        public void Add(T element)
        {
            this.Count++;
            this.Resize(this.Count);
            this.elements[this.Count - 1] = element;
        }

        public int GetByIndex(T element)
        {
            return Array.IndexOf(this.elements, element);
        }

        public void RemoveAtIndex(int position)
        {
            if (position < 0 || position >= this.Count)
            {
                throw new ArgumentOutOfRangeException("Position is outside of the bounds of the collection!");
            }
            else
            {                
                this.Count--;
                this.Resize(this.Count);

                for (int a = position; a < this.elements.Length - 1; a++)
                {
                    this.elements[a] = this.elements[a + 1];
                }
            }
        }

        public void InsertAtPosition(int position, T element)
        {
            if (position < 0 || position > this.Count)
            {
                throw new ArgumentOutOfRangeException("Position is outside of the bounds of the collection!");
            }
            else
            {
                this.Count++;
                this.Resize(this.Count);



                // store
                //elements[position] = element; // add the new element

                // shift the elements after the new elements to the right
                T[] demo = new T[this.elements.Length];
                for (int i = 0; i < this.elements.Length; i++)
                {
                    demo[(i ) % demo.Length] = this.elements[i];
                }
                demo[position] = element;

                this.elements = demo;

                // put the element we stored back
                //elements[position + 1] = store;

               /* for (int i = position + 2; i < this.Capacity; i++)
                {
                    elements[i] = elements[i - 1];
                }
                */
               // this.elements[position] = element;
            }
        }

        public void Clear()
        {
            this.Count = 0;
            this.Capacity = DefaultCapacity;

            this.elements = new T[this.Capacity];
        }

        public override string ToString()
        {
            if (this.Count == 0)
            {
                return "Empty list!";
            }
                
            StringBuilder result = new StringBuilder();
            result.Append("Element(s): ");

            for (int i = 0; i < this.Count; i++)
            {
                result.AppendFormat("{0}", this.elements[i].ToString());

                if (i + 1 < this.Count)
                {
                    result.Append(",");
                }                   
            }

            return result.ToString();
        }

        private void Resize(int capacity)
        {
            if (capacity > this.Capacity)
            {
                this.Capacity *= 2;
                Array.Resize(ref this.elements, this.Capacity);
            }
        }
    }
}
