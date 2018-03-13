using System;
using System.Collections.Generic;
using System.Text;

class Trainer
{
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Badges
    {
        get { return this.badges; }
        set { this.badges = value; }
    }

    public List<Pokemon> Pokemons
    {
        get { return this.pokemons; }
        set { this.pokemons = value; }
    }
     

    public Trainer(string name)
    {
        this.name = name;
        this.badges = 0;
        this.pokemons = new List<Pokemon>();
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Badges} {this.Pokemons.Count}";
    }
}

