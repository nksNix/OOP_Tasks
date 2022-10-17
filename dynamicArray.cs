using System;
using System.Collections.Generic;

namespace DynamicArray
{
    class DynamicArray
    {
        private List<int> array = new List<int>();

        public int this[int index]
        {
            get => array[index]; 
            set => array[index] = value;
        }

        public int Length
        {
            get => array.Count;
        }


        public void Print()
        {
            for (int i = 0; i < array.Count; i++)
                Console.WriteLine(array[i]);
        }

        public void Add(int elem)
        {
            array.Add(elem);
        }

        public void Remove(int index)
        {
            array.RemoveAt(index);
        }

        public static DynamicArray operator ++(DynamicArray dynamicArray)
        {
            List<int> newArray = new List<int>();
            for (int i = 0; i < dynamicArray.array.Count; i++)
                newArray.Add(dynamicArray.array[i] + 1);

            return new DynamicArray() { array = newArray };
        }

        public static DynamicArray operator +(DynamicArray dynamicArray1, DynamicArray dynamicArray2)
        {
            List<int> newArray = dynamicArray1.array;

            dynamicArray2.array.ForEach(elem => newArray.Add(elem));

            return new DynamicArray() { array = newArray };
        }

        public static DynamicArray operator -(DynamicArray dynamicArray1, DynamicArray dynamicArray2)
        {
            DynamicArray newDynamicArray = dynamicArray1 + dynamicArray2;

            for (int i = 0; i < dynamicArray2.array.Count; i++)
            {
                for (int j = 0; j < newDynamicArray.array.Count - 1;)
                {
                    if (dynamicArray2[i] == newDynamicArray[j])
                    {
                        newDynamicArray.array.RemoveAt(j);
                        j = 0;
                    }
                    else
                        j++;
                }
            }

            return newDynamicArray;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new DynamicArray();
            var array2 = new DynamicArray();
            array1.Add(1);
            array1.Add(10);
            array1.Add(57);

            array2.Add(1);
            array2.Add(10);
            array2.Add(53);

            var finalArrray = array1 - array2;
            finalArrray.Print();

        }
    }
}