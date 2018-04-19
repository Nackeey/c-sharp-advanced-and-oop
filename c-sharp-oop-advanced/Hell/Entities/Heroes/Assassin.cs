using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Assassin : AbstractHero
{
    public Assassin(string name)
        : base(name, 25, 100, 15, 150, 300)
    {
    }
}
