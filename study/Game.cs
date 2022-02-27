using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    case "hello":
                    case "1":
                        Console.WriteLine();
                        Console.WriteLine("1");
                        break;
                    case "exit":
                        Console.WriteLine("exit");
                        exitcode= false;
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
