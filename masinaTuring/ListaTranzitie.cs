using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masinaTuring
{
    public class ListaTranzitie
    {
        private List<Tranzitie> lista = new List<Tranzitie>();

        //primeste obiectul tranzitie si il adauga la lista de tranzitii a masinii
        public void adaugaTranzitie(Tranzitie tranzitie)
        {
            lista.Add(tranzitie);
        }

        //metoda primeste o stare si un simbol si cauta in lista tranzitia corespunzatoare
        public Tranzitie gasesteTranzitie(string stare, char simbol_Citit)
        {
            foreach(var tranzitie in lista)
            {
                if(tranzitie.spuneStInceput().Equals(stare) && tranzitie.spuneSimbol_Citit().Equals(simbol_Citit))
                {
                    return tranzitie;
                }
            }

            return null!;
        }
    }
}
