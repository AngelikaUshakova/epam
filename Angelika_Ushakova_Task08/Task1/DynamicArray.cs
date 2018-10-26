using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DynamicArray<T> where T : new()
    {
        private T[] array;

        public DynamicArray()
        {
            array = new T[8];
            Length = 8;
        }

        public DynamicArray(byte N)
        {
            if (N < 0)
            {
                throw new ArgumentException("Рзмаер массива должен быть положителным");
            }
            array = new T[N];
            Length = N;
        }

        public  DynamicArray(T[] array)
        {
            Length = array.Length;
            this.array = (T[])array.Clone();
        }

        public int Length { get; private set; }

        public int Capacity
        {
            get
            {
                return array.Length;
            }
           private set
            {
                Capacity = value;
            }
        }

        public void Add(T arrayElement)
        {
            Insert(arrayElement, 1);
        }

        private void CapacityChange(int N)
        {
            Capacity *= N;
            T[] newArray = new T[Capacity];

            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public void AddRange(T[] array)
        {
            if (Capacity < (Length + array.Length))
            {
                CapacityChange(2 * Count(array));
            }
        }

        private int Count(T[] array)
        {
            int count = 0;
            int capacity = Capacity;
            while(capacity < (Length + array.Length))
            {
                capacity *= 2;
                count++;
            }
            return count;
        }

        public bool Remove(T elementArray)
        {
            bool remove = false;
            for(int i = 0; i < Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i],elementArray))
                {
                    for (int j = i; j < Length; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    remove = true;
                }
            }
            Length--;
            return remove;
        }

        public void Insert(T elementArray, int index)
        {
            CheckCorrectness(index);

            if (Length == Capacity)
            {
                CapacityChange(2);
            }
            for (int i = Length + 1; i > index; i--) 
            {
                array[i] = array[i-1];
            }

            Length++;
            array[index] = elementArray;
        }

        public T this[int index]
        {
            get
            {
                CheckCorrectness(index);
                return array[index];
            }
            set
            {
                CheckCorrectness(index);
                array[index] = value;
            }
        }

        private void CheckCorrectness(int index)
        {
            if ((index < 0) && (index > Length))
            {
                throw new IndexOutOfRangeException("Некорректный индекс. Выход за границы массива");
            }
          
        }
    }
}
