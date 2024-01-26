using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPicksStat2._0
{
    class Feladatok
    {
        private List<Sorsolas> kisorsoltSzamok;
        List<Szelveny> szelvenyek;

        public Feladatok()
        {
            Kitoltes();
            OsszesFeltoltes();
            Console.WriteLine("4. kombináció lehetőségei: {0:N0}",szelvenyek.Count);
            //Console.WriteLine("Összevonás előtt: {0}",Megszamlalas());
            Osszevonas();
            //Console.WriteLine("Összevonás után: {0} = {1}", Megszamlalas(),kisorsoltSzamok.Count*15);
            //int i = 0;
            foreach (var item in szelvenyek)
            {
                if(item.SorIdo.Count > 1)
                {
                    //i++;
                    Console.WriteLine("{0} - {1}",item,item.SorIdo.Count);
                }
            }
            //Console.WriteLine("{0:N0} - {1:N0}",szelvenyek.Count,i);
        }

        private int Megszamlalas()
        {
            int szam = 0;
            foreach (var item in szelvenyek)
            {
                szam += item.SorIdo.Count;
            }
            return szam;
        }
        private void Kitoltes()
        {
            Console.WriteLine("A 4. kombinációk feltöltésének kezdete.");
            szelvenyek = new List<Szelveny>();
            for (int i = 1; i < 57; i++)
            {
                for (int j = i+1; j < 58; j++)
                {
                    for (int k = j+1; k < 59; k++)
                    {
                        for (int l = k+1; l < 60; l++)
                        {
                            int[] szamok = {i,j,k,l};
                            szelvenyek.Add(new Szelveny(szamok));
                        }           
                    }
                }
            }
            Console.WriteLine("A 4. kombinációk feltöltésének befejezése.");
        }

        private void Osszevonas()
        {
            Console.WriteLine("Összevonás kezdete.");
            foreach (var item in kisorsoltSzamok)
            {
                Egyeztet(item.Szamok, item.SorsolasIdeje);
            }
            Console.WriteLine("Összevonás befejezése.");
        }

        private void Egyeztet(int[] szamok, DateTime datum)
        {
            for (int i = 0; i < szamok.Length; i++)
            {
                for (int j = i+1; j < szamok.Length; j++)
                {
                    int[] sz = new int[4];
                    int szIndex = 0;
                    for (int k = 0; k < szamok.Length; k++)
                    {
                        if(k==i || k == j)
                        {
                            continue;
                        }
                        else
                        {
                            sz[szIndex++] = szamok[k];
                        }
                    }
                    /*foreach (var item in sz)
                    {
                        Console.Write(item + ", ");
                    }
                    Console.WriteLine();*/
                    int l = 0;
                    bool ertek = true;
                    while (ertek)
                    {
                        if(szelvenyek[l].Szam[0] == sz[0] && szelvenyek[l].Szam[1] == sz[1] && 
                            szelvenyek[l].Szam[2] == sz[2] && szelvenyek[l].Szam[3] == sz[3])
                        {
                            szelvenyek[l].SorIdo.Add(datum);
                            ertek = false;
                        }
                        l++;
                    }
                }
            }
        }

        private void OsszesFeltoltes()
        {
            Console.WriteLine("Adatok Feltöltésének kezdete.");
            kisorsoltSzamok = new List<Sorsolas>();
            Feltolt("Sorsolasok2017.txt");
            Feltolt("Sorsolasok2018.txt");
            Feltolt("Sorsolasok2019.txt");
            Feltolt("Sorsolasok2020.txt");
            Feltolt("Sorsolasok2021.txt");
            Feltolt("Sorsolasok2022.txt");
            Console.WriteLine("Adatok Feltöltésének befejezése.");
        } 

        private void Feltolt(string fajlNev)
        {
            StreamReader be = new StreamReader(fajlNev);
            while (!be.EndOfStream)
            {
                string sor = be.ReadLine();
                string[] reszek = sor.Split(',');
                int[] szamok = new int[6];
                for(int i =0;i< szamok.Length;i++)
                {
                    szamok[i] = Convert.ToInt32(reszek[i]);
                }
                kisorsoltSzamok.Add(new Sorsolas(szamok, Convert.ToDateTime(reszek[6])));
            }
            be.Close();
        }
    }
}
