using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Organism;

namespace Game
{
    internal class MainGame
    {
        public static void Play()
        {
            bool exitcode = true;
            do
            {
                string s = Console.ReadLine();

                switch (s) {
                    case "hello": //hello가 출력됨
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("1");
                        break;
                    case "exit":
                        Console.WriteLine("exit");
                        exitcode= false;
                        break;
                    case "jane":
                        Organism jane = new Organism();
                        Console.WriteLine(jane.Name);
                        break;
                    case "mary":
                        Organism mary = new Organism("mary", "human");
                        Console.WriteLine(mary.Name);
                        break;
                    default:
                        Console.WriteLine("hello");
                        break;
                }


            }
            while(exitcode);
        }
    }
}
