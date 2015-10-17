using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            Interface gameInterface = new Interface();
            gameInterface.KeyHandler();
        }
    }
}

