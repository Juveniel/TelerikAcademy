using System;
using System.Collections;

namespace _12.StackImplementation
{
    public class CustomStack<T> : IEnumerable
    {    
        private const int DefSize = 4;
        private T[] innerArray;
        private int maxSize = 4;

        public CustomStack()
        {
            this.innerArray = new T[DefSize];
        }

        public CustomStack(int size)
        {
            this.innerArray = new T[size];
        }

        public int Count { get; private set; } = 0;

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public IEnumerator GetEnumerator()
        {
            foreach (T item in this.innerArray)
            {
                if (item == null)
                {
                    break;
                }

                yield return item;
            }
        }

        public void Push(T element)
        {
            if (this.Count == this.maxSize)
            {
                this.innerArray = this.ResizeStack(this.innerArray);
            }

            this.innerArray[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            T popedElement = this.innerArray[this.Count - 1];
            this.innerArray[this.Count] = default(T);
            this.Count--;

            return popedElement;
        }

        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty!");
            }

            T topElement = this.innerArray[this.Count - 1];
            return topElement;
        }

        public bool Contains(T element)
        {
            bool isContained = false;

            for (int i = 0; i < this.Count; i++)
            {
                if (this.innerArray[i].Equals(element))
                {
                    isContained = true;
                    break;
                }
            }

            return isContained;
        }

        public T[] ToArray()
        {
            var copiedArray = new T[this.Count];
            Array.Copy(this.innerArray, copiedArray, this.Count);
            return copiedArray;
        }

        private T[] ResizeStack(T[] innerArray)
        {
            T[] newInnerArray = new T[this.maxSize * 2];
            this.maxSize = this.maxSize * 2;

            for (int i = 0; i < innerArray.Length; i++)
            {
                newInnerArray[i] = this.innerArray[i];
            }

            return newInnerArray;
        }        
    }
}
