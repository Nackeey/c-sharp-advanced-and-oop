using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GenericDataStructure<T> : IEnumerable<T>
    where T : IComparable
{
    private List<T> customList;

    public GenericDataStructure()
        :this(new List<T>())
    {

    }

    public GenericDataStructure(List<T> list)
    {
        this.customList = list;
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

    public List<T> Element => this.customList;

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

    public IEnumerator<T> GetEnumerator()
    {
        return this.Element.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}

