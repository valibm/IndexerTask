using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerTask.Models
{
    internal class IntArray
    {
        private static int[] _array;
        public int this[int index]
        {
            get { return _array[index]; }
            set { _array[index] = value; }
        }
        public int Length { get { return _array.Length; } }
        public IntArray()
        {
            _array = new int[0];
        }
        public void Add(int number)
        {
            int[] newArray = CustomResize(_array, _array.Length + 1);
            newArray[^1] = number;
            _array = newArray;
        }
        public static int[] CustomReverse()
        {
            int temp = 0;
            int[] newArray = new int[_array.Length];
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                _array[i] = newArray[temp];
                ++temp;
            }
            return newArray;
        }
        public static int[] CustomSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int v = i + 1; v < array.Length; v++)
                {
                    if (array[i] > array[v])
                    {
                        temp = array[i];
                        array[i] = array[v];
                        array[v] = temp;
                    }
                }
            }
            return array;
        }
        public static void CustomRemove(int number)
        {
            Find(_array, number);
            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (number == _array[i])
                {
                    _array[i] = _array[i + 1];
                }
            }
            CustomResize(_array, _array.Length - 1);
        }

        private static int[] CustomResize(int[] anotherArray, int length)
        {
            int loopCount = 0;
            loopCount = length > anotherArray.Length ? anotherArray.Length : length;
            int[] newArray = new int[length];
            for (int i = 0; i < loopCount; i++)
            {
                newArray[i] = anotherArray[i];
            }
            return newArray;
        }
        private static int? Find(int[] array, int wanted)
        {
            foreach (int item in array)
            {
                if (item == wanted)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
