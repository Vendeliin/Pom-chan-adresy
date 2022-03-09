using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PomíchanéAdresy
{
    internal class App
    {
        public void Run()
        {
            var data = File.ReadAllLines("./adresy.txt");
            var array = data.ToArray();
            string[] string2;

            string string1;
            for(int k = 0; k < array.Length; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    string1 = array[k];
                    string2 = string1.Split('|');
                    Array.Reverse(string2);
                    Console.Write(string2[i] + "/");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
