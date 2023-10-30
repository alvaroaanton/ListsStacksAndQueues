using System;
namespace Common
{
    public class GenericArrayList<T> : IGenericList<T>
    {
        T[] Values;
        private int NumElements;

        public GenericArrayList(int n)
        {
            //TODO #1: initialize Values with an array of size n
            Values = new T[n];
        }
        public string AsString()
        {
            string output = "[";

            for (int i = 0; i < Count(); i++)
                output += Values[i].ToString() + ",";
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        

        public void Add(T value)
        {
            //TODO #2: add a new element to the end of the list
            int i = 0;
            while (i < Count())
            {
                i++;
            }
            Values[i] = value;
        }

        public T Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
            for (int i = 0; i < Count(); i++)
            {
                if (i == index)
                {
                    return Values[i];
                }
            }
            return default(T);
        }

        public int Count()
        {
            //TODO #4: return the number of elements on the list
            NumElements = 0;
            for (int i = 0; i < Values.Length; i++)
            {
                NumElements++;
            }
            return NumElements;
        }

        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (index >= 0 && index < Count() - 1)
            {
                for (int i = index; i < Count() - 1; i++)
                {
                    Values[i] = Values[i + 1];
                }
            }
            return;
        }

        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            for (int i = 0; i < Count(); i++)
            {
                Values[i] = default (T);
            }
        }
    }
}