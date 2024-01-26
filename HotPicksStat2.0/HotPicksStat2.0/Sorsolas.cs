using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotPicksStat2._0
{
    class Sorsolas
    {
        private int[] szamok;
        private DateTime sorsolasIdeje;

        public Sorsolas(int[] szamok, DateTime sorsolasIdeje)
        {
            this.szamok = szamok;
            this.sorsolasIdeje = sorsolasIdeje;
        }

        public int[] Szamok { get => szamok; set => szamok = value; }
        public DateTime SorsolasIdeje { get => sorsolasIdeje; set => sorsolasIdeje = value; }

        public override string ToString()
        {
            return string.Format("{0},{1},{2},{3},{4},{5} - {6},{7},{8}",
                this.szamok[0], this.szamok[1], this.szamok[2], this.szamok[3], this.szamok[4], this.szamok[5],
                this.sorsolasIdeje.Year,this.sorsolasIdeje.Month,this.sorsolasIdeje.Day);
        }
    }
}
