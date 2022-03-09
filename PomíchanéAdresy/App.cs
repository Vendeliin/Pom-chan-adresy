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
            string[] array2;

            string string1;

            for(int k = 0; k < array.Length; k++)
            {
                for (int i = 0; i < 3; i++)
                {
                    string1 = array[k];
                    array2 = string1.Split('|');
                    Array.Reverse(array2);
                    Console.Write(array2[i] + "/");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
