using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPicksStat2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Feladatok feladat = new Feladatok();
            int[] szamok = { 12, 16, 17, 43, 53, 57 };
            for (int i = 0; i < szamok.Length; i++)
            {
                for (int j = i+1; j < szamok.Length; j++)
                {
                    for (int k = 0; k < szamok.Length; k++)
                    {
                        if(k==i || k == j)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(szamok[k] + ", ");
                        }
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
    }
}
