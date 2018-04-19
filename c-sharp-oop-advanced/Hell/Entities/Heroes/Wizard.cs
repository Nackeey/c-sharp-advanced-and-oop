using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Wizard : AbstractHero
{
    public Wizard(string name)
        : base(name, 25, 25, 100, 100, 250)
    {
    }
}
