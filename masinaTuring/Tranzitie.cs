using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masinaTuring
{
    public class Tranzitie
    {
        private string st_inceput;
        private char simbol_citit;
        private char simbol_scris;
        private char directie;
        private string st_sfarsit;

        public Tranzitie(string st_inceput, char simbol_citit, char simbol_scris, char directie, string st_sfarsit)
        {
            this.st_inceput = st_inceput;
            this.simbol_citit = simbol_citit;
            this.simbol_scris = simbol_scris;
            this.directie = directie;
            this.st_sfarsit = st_sfarsit;
        }

        public string spuneStInceput()
        {
            return this.st_inceput;
        }

        public char spuneSimbol_Citit()
        {
            return this.simbol_citit;
        }

        public char spuneSimbol_Scris()
        {
            return this.simbol_scris;
        }

        public char spuneDirectie()
        {
            return this.directie;
        }

        public string spuneStSfarsit()
        {
            return this.st_sfarsit;
        }
    }
}
