
using System.Runtime.ExceptionServices;

namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        GenericList<int> list= new GenericList<int>();
        GenericListNode<int> First = null;
        private int numElementos;
        
        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            GenericListNode<T> node = First;
            string output = "[";

            while (node != null)
            {
                output += node.ToString() + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }
        
        public int Count()
        {
            //TODO #3: Return the number of objects
            GenericListNode<T> node = First;
            numElementos = 0;

            while (node != null)
            {
                numElementos++;
                node = node.Next;
            }

            return numElementos;
        }

        public void Clear()
        {
            GenericListNode<T> node = First;

            if (node != null)
            {
                node.Next = null;
            }
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            GenericListNode<T> node = First;
            if (node != null)
            {
                while (node.Next != null)
                {
                    node = node.Next;

                }
                node.Next.Value = value;
            }
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it
            GenericListNode<T> node = First;
            if (First != null)
            {
                First = First.Next;
            }
            return First;
        }
    }
}