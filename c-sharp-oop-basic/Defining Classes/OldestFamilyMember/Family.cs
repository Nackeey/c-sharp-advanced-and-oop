using System;
using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> members;

    public Family()
    {
        this.members = new List<Person>();
    }

    public void AddMember(Person person)
    {
        members.Add(person);
    }

    public Person GetTheOldestMember()
    {
        return this.members.OrderByDescending(m => m.Age).FirstOrDefault();
    }
}
