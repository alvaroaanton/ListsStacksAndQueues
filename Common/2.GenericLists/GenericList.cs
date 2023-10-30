using Common;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;

    public string AsString()
    {
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

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        GenericListNode<T> node = First;
        while (node != null)
        {
            node = node.Next;
        }
        node.Value = value;
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'
        int currentPos = 0;
        GenericListNode<T> node = First;
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

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        int currentPos = 0;
        GenericListNode<T> node = First;

        while (node != null)
        {
            if (index == currentPos)
            {
                return node.Value;
            }
            currentPos++;
            node = node.Next;
        }
        return default(T);
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list
        GenericListNode<T> node = First;
        int numElementos = 0;

        while (node != null)
        {
            numElementos++;
            node = node.Next;
        }

        return numElementos;
    }


    public void Remove(int index)
    {
        GenericListNode<T> node = First;
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        int currentPos = 0;
        if (index == 0)
        {
            First = First.Next;
            return;
        }
        while (node != null)
        {
            if (index == currentPos)
            {
                FindNode(index - 1).Next = FindNode(index + 1);
            }
            currentPos++;
            node = node.Next;
        }
        return;
    }

    public void Clear()
    {
        GenericListNode<T> node = First;
        //TODO #6: remove all the elements on the list
        
        if (node != null)
        {
            node.Next = null;
        }
    }
}