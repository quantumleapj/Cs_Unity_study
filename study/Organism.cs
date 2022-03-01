using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Organism
    {
    public string Name;
    public string Species;
    public int Health;

    public Organism()
    {
        Name = "jane";
        Species = "human";
        Health = 100;
    }
    public Organism(string name, string species) //생성자 매개변수 앞에 꼭 자료형 써줘야함 
    {
        Name = name;
        Species = species;
    }
    public Organism(string name, string species, int health) //생성자 매개변수 앞에 꼭 자료형 써줘야함 
    {
        Name = name;
        Species = species;
        Health = health;
    }

}