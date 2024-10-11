using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace napszaki
{
        internal class Program
        {
            static void Main(string[] args)
            {
                DateTime now = DateTime.Now;

                if (now.Hour < 12)
                    Console.WriteLine("Jó reggelt!");
                else if (now.Hour < 18)
                    Console.WriteLine("Jó napot!");
                else
                    Console.WriteLine("Jó estét!");
            }
        }
    }

