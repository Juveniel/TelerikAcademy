using System;

namespace _11.LinkedListImplementation
{
    public class CustomLinkedList<T>
    {
        private ListItem<T> firstElement;

        public int Count { get; private set; } = 0;

        public void AddFirst(T value)
        {
            if (this.firstElement == null)
            {
                this.firstElement = new ListItem<T>(value);
                this.Count++;
            }
            else
            {
                var newElement = new ListItem<T>(value)
                {
                    NextItem = this.firstElement
                };
                this.firstElement = newElement;
                this.Count++;
            }
        }

        public void AddLast(T value)
        {
            if (this.firstElement == null)
            {
                this.firstElement = new ListItem<T>(value);
                this.Count++;
            }
            else
            {
                var last = this.firstElement;

                while (last.NextItem != null)
                {
                    last = last.NextItem;
                }

                last.NextItem = new ListItem<T>(value);
                this.Count++;
            }
        }

        public void RemoveFirst()
        {
            if (this.firstElement == null)
            {
                throw new InvalidOperationException("Linked list is empty!");
            }

            this.firstElement = this.firstElement.NextItem;
            this.Count--;
        }

        public void RemoveLast()
        {
            var last = this.firstElement;

            while (last.NextItem != null)
            {
                last = last.NextItem;
            }

            var valueToRemove = this.firstElement;
            while (valueToRemove.NextItem != last)
            {
                valueToRemove = valueToRemove.NextItem;
            }

            valueToRemove.NextItem = null;
            this.Count--;
        }

        public void Clear()
        {
            while (this.firstElement != null)
            {
                this.firstElement = this.firstElement.NextItem;
                this.Count--;
            }
        }
    }
}
