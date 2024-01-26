using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPicksStat2._0
{
    class Szelveny
    {
        private int[] szam;
        private List<DateTime> sorIdo;

        public Szelveny(int[] szam)
        {
            this.szam = szam;
            sorIdo = new List<DateTime>();
        }

        public int[] Szam { get => szam; set => szam = value; }
        public List<DateTime> SorIdo { get => sorIdo; set => sorIdo = value; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3}",this.szam[0], this.szam[1], this.szam[2], this.szam[3]);
        }
    }
}
