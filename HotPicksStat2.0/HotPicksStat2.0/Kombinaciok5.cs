using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPicksStat2._0
{
    class Kombinaciok5
    {
        private int[] szamok;
        private List<DateTime> kisorsolasa;

        public Kombinaciok5(int[] szamok, DateTime datum)
        {
            this.szamok = szamok;
            kisorsolasa = new List<DateTime>();
            kisorsolasa.Add(datum);
        }

        public int[] Szamok { get => szamok; set => szamok = value; }
        public List<DateTime> Kisorsolasa { get => kisorsolasa; set => kisorsolasa = value; }

        public override string ToString()
        {
            string sz = "";
            foreach (var item in this.kisorsolasa)
            {
                sz += item.Year + "." + item.Month + "." + item.Day + ", ";
            }
            return string.Format("{0},{1},{2},{3},{4} - {5} x volt sorsolva: {6}",
                this.szamok[0], this.szamok[1], this.szamok[2], this.szamok[3], this.szamok[4],this.kisorsolasa.Count,sz);
        }
    }
}
