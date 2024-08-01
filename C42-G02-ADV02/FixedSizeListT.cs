using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C42_G02_ADV02
{
    public class FixedSizeList<T>
    {
        private T[] items;
        private int count;

        public int Capacity { get; private set; }
        public int Count { get { return count; } }

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }

            Capacity = capacity;
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= Capacity)
            {
                throw new InvalidOperationException("Cannot add more elements, the list is full.");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return items[index];
        }
    }
}
