using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Organism
    {
    public string name;
    public string species;
    public int health;
    public int hunger;

    public Organism()
    {
        name = "jane";
        species = "human";
        health = 100;
        hunger=100;
    }
    public Organism(string name, string species) //생성자 매개변수 앞에 꼭 자료형 써줘야함 
    {
        name = name;
        species = species;
        health = 100;
        hunger=100;
    }
    public Organism(string name, string species, int health) 
    {
        name = name;
        species = species;
        health = health;
        hunger=100;
    }

}