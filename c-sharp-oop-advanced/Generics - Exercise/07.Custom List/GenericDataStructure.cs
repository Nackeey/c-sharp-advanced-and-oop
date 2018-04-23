using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GenericDataStructure<T>
    where T : IComparable
{
    private List<T> customList;

    public GenericDataStructure()
    {
        this.customList = new List<T>();
    }

    public void Add(T item)
    {
        customList.Add(item);
    }

    public void Remove(int index)
    {
        customList.RemoveAt(index);
    }

    public bool Contains(T item)
    {
        return customList.Contains(item);
    }

    public void Swap(int index1, int index2)
    {
        var rem = customList[index1];
        customList[index1] = customList[index2];
        customList[index2] = rem;
    }

    public int Greater(T item)
    {
        int counter = 0;
        foreach (var element in customList)
        {
            if (element.CompareTo(item) > 0)
            {
                counter++;
            }
        }

        return counter;
    }

    public T Max()
    {
        return customList.Max();
    }

    public T Min()
    {
        return customList.Min();
    }

    public void Print()
    {
        foreach (var item in customList)
        {
            Console.WriteLine(item);
        }
    }

    public void END()
    {
        
    }
}

