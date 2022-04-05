using System;
using System.Collections.Generic;
using System.Text;

namespace IndexerTask.Models
{
    internal class StringArray
    {
        private static string[] _array;
        public string this[int index] { get {return _array[index];} 
            set {_array[index] = value;} }
        public int Length { get { return _array.Length; } }
        public StringArray()
        {
            _array = new string[0];
        }
        public void Add(string word)
        {
            string[] newArray = CustomResize(_array, _array.Length+1);
            newArray[^1] = word;
            _array = newArray;
        }
        public static void CustomRemove(string word)
        {
            Find(_array, word);
            for (int i = 0; i < _array.Length - 1; i++)
            {
                if (word == _array[i])
                {
                    _array[i] = _array[i+1];
                }
            }
            CustomResize(_array, _array.Length - 1);
        }
        private static string[] CustomResize (string[] anotherArray, int length)
        {
            int loopCount = 0;
            loopCount = length > anotherArray.Length ? anotherArray.Length: length;
            string[] newArray = new string[length];
            for (int i = 0; i < loopCount; i++)
            {
                newArray[i] = anotherArray[i];
            }
            return newArray;
        }
        private static string Find(string[] array, string wanted)
        {
            foreach (string item in array)
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
