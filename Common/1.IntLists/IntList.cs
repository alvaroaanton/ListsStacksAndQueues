using System;
using System.Xml.Linq;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;
        private int numElementos;
        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            IntListNode node = First;
            if (node != null)
            {
                while (node.Next != null)
                {
                    node = node.Next;

                }
                node.Next.Value = value;
            }
        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            int currentPos = 0;
            IntListNode node = First;
            while (node != null)
            {
                if (index == currentPos)
                {
                    return node;
                }
                currentPos++;
                node = node.Next;
            }
          
            return null;
        }

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
            int currentPos = 0;
            IntListNode node = First;
            
            while (node != null)
            {
                if (index == currentPos)
                {
                    return node.Value;
                }
                currentPos++;
                node = node.Next;
            }

            return 0;
        }

        public int Count()
        {
            //TODO #4: return the number of elements on the list
            numElementos = 0;
            IntListNode node = First;

            while (node != null)
            {
                numElementos++;
                node = node.Next;
            }

            return numElementos;
        }
        
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            int currentPos = 0;
            IntListNode node = First;
            if(index == 0)
            {
                First = First.Next;
                return;
            }
            while (node != null)
            {
                if (index == currentPos)
                {
                    GetNode(index - 1).Next = GetNode(index + 1);
                }
                currentPos++;
                node = node.Next;
            }

            return;
        }

        
        public void Clear()
        {
            //TODO #6: remove all the elements on the list
            IntListNode node = First;
            if (node != null)
            {
                node.Next = null;
            }
        }
    }
}