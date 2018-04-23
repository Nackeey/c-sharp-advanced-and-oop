using System;
using System.Collections.Generic;
using System.Text;

public class Box<T>
{
    private T anyValue;

    public Box(T value)
    {
        this.anyValue = value;
    }

    public override string ToString()
    {
        return $"{anyValue.GetType().FullName}: {anyValue}";    
    }
}
