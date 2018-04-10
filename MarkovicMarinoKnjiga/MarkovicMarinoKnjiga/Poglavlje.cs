using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkovicMarinoKnjiga
{
    class Poglavlje
    {
        private string NazivPoglavlja;
        private int brojStranice, ukupanBrojStranica;
        public void setNazvPoglavlja(string imePoglavlja)
        {
            NazivPoglavlja = imePoglavlja;
        }
        public void setBrojStranice(int brojStranice2)
        {
            brojStranice = brojStranice2;
        }
        public void setUkupanBrojStranica(int zbrojStranica)
        {
            ukupanBrojStranica = zbrojStranica;
        }
        public string getNazivPoglavlja()
        {
            return NazivPoglavlja;
        }
        public int getBrojStranice()
        {
            return brojStranice;
        }
        public int getUkupanBrojStranica()
        {
            return ukupanBrojStranica;
        }

    }
}
