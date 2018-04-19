using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Barbarian : AbstractHero
{
    public Barbarian(string name)
        : base(name, 90, 25, 10, 350, 150)
    {
    }
}
