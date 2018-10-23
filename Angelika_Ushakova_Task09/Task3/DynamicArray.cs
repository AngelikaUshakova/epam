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
            Capacity = 8;
        }

        public DynamicArray(byte N)
        {
            if (N < 0)
            {
                throw new ArgumentException("Рзмаер массива должен быть положителным");
            }
            array = new T[N];
            Capacity = N;
        }

        public  DynamicArray(T[] array)
        {
            Capacity = array.Length;
            this.array = (T[])array.Clone();
        }

        public int Capacity { get; private set; }

        public int Length
        {
            get
            {
                return array.Length;
            }
        }

        public void Add(T arrayElement)
        {
           if (Capacity == array.Length)
            {
                CapacityChange(2);
            }
                array[array.Length + 1] = arrayElement;
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
            if (Capacity < (this.array.Length + array.Length))
            {
                CapacityChange(2 * Count(array));
            }
        }

        private int Count(T[] array)
        {
            int count = 0;
            int capacity = Capacity;
            while(capacity < (this.array.Length + array.Length))
            {
                capacity *= 2;
                count++;
            }
            return count;
        }

        public bool Remove(T elementArray)
        {
            bool remove = false;
            for(int i = 0; i < array.Length; i++)
            {
                if (EqualityComparer<T>.Default.Equals(array[i],elementArray))
                {
                    for (int j = i; j < array.Length; j++)
                    {
                        array[j] = array[j + 1];
                    }
                    remove = true;
                }
            }
            return remove;
        }

        public void Insert(T elementArray, int index)
        {
           if ((index > array.Length) || (index < 0))
            {
                throw new ArgumentOutOfRangeException("Выход за границу массива");
            }

           if (array.Length == Capacity)
            {
                CapacityChange(2);
            }
            for (int i = array.Length + 1; i > index; i--) 
            {
                array[i] = array[i-1];
            }
            array[index] = elementArray;
        }

        public T this[int index]
        {
            get
            {
                Correctness(index);
                return array[index];
            }
            set
            {
                Correctness(index);
                array[index] = value;
            }
        }

        private void Correctness(int index)
        {
            if ((index < 0) && (index > array.Length))
            {
                throw new IndexOutOfRangeException("Некорректный индекс. Выход за границы массива");
            }
          
        }
    }
}
