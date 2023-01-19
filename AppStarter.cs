using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDisplayApp
{
    internal class AppStarter
    {

        public string UserInputMethod()
        {
            Console.Write("\n  Enter properties to display (Use comma to seperate if many properties): \n\n  ");

            string input = Console.ReadLine();

            return input;
        }
    }
}
