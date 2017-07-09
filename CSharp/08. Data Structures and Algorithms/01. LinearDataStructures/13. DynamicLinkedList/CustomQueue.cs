using System;
using System.Collections;
using System.Collections.Generic;

namespace _13.DynamicLinkedList
{
    public class CustomQueue<T> : IEnumerable
    {
        private readonly LinkedList<T> innerLinkList;

        public CustomQueue()
        {
            this.innerLinkList = new LinkedList<T>();
        }

        public int Count => this.innerLinkList.Count;

        public IEnumerator GetEnumerator()
        {
            return this.innerLinkList.GetEnumerator();
        }

        public void Enqueue(T element)
        {
            this.innerLinkList.AddLast(element);
        }

        public T Dequeue()
        {
            if (this.innerLinkList.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }

            T dequeuedElement = this.innerLinkList.First.Value;
            this.innerLinkList.RemoveFirst();

            return dequeuedElement;
        }

        public T[] ToArray()
        {
            var copiedArray = new T[this.Count];
            this.innerLinkList.CopyTo(copiedArray, 0);
            return copiedArray;
        }

        public bool Contains(T element)
        {
            return this.innerLinkList.Contains(element);
        }

        public void Clear()
        {
            this.innerLinkList.Clear();
        }
    }
}
