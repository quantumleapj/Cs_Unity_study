using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Hunger;
using Game;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.WriteLine(args);
            Hunger.Hungerclass.hunger();
            Game.MainGame.Play();
            //Console.WriteLine("really??");

        }
    }
}
