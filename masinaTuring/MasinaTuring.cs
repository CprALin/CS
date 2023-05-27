using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace masinaTuring
{
    public class MasinaTuring
    {
        private string? st_curenta;
        private string[] stari_finale;
        private List<Char> banda;
        private int pointerBanda;
        private ListaTranzitie lt = new ListaTranzitie();

        //contructorul primeste numele fisierului si initializeaza starile
        public MasinaTuring(string nume_fis) {
           using(StreamReader buf =  new StreamReader(nume_fis))
            {
                this.st_curenta = buf.ReadLine();
                string? stari_finale_str = buf.ReadLine() ?? string.Empty;
                this.stari_finale = stari_finale_str.Split(' ');

                while (true)
                {
                    string? tmp = buf.ReadLine();

                    if(tmp == null)
                    {
                        break;
                    }
                    else
                    {
                        string[] tbl = tmp.Split('_');
                        Tranzitie tr = new Tranzitie(tbl[0], tbl[1][0], tbl[1][1], tbl[1][2], tbl[2]);
                        this.lt.adaugaTranzitie(tr);
                    }
                }
            }
            this.banda = new List<char>();
        }

        //muta capul de citire la stanga
        private void stanga()
        {
            if(pointerBanda == 0)
            {
                banda.Insert(0, ' ');
            }
            pointerBanda--;
        }

        //muta capul de citire la dreapta
        private void dreapta()
        {
            pointerBanda++;
            if(pointerBanda == banda.Count)
            {
                banda.Add(' ');
            }
        }

        //scrie un simbol la pozitia curenta a capului de citire 
        private void scrie(char c)
        {
            banda[pointerBanda] = c;
        }

        //executa tranzitia specificata
        private void executaTranzitie(Tranzitie tranzitie)
        {
            st_curenta = tranzitie.spuneStSfarsit();
            scrie(tranzitie.spuneSimbol_Scris());
            if(tranzitie.spuneDirectie() == 'L')
            {
                stanga();
            }else if(tranzitie.spuneDirectie() == 'R')
            {
                dreapta();
            }
        }

        //verifica daca este starea finala a masinii
        private bool esteStareFinala(string stare)
        {
            return Array.Exists(stari_finale, sf => sf.Equals(stare));
        }

        //  primeste sirul de intrare, parcurge banda si executa tranzitiile
        // corespunzatoare in funtie de starea curenta si simbolul citit
        public bool analizeazaCuvant(string sir_intrare)
        {
            sir_intrare = sir_intrare.TrimStart();

            this.banda.Clear();
            this.banda.Add(' ');
            this.banda.AddRange(sir_intrare.ToCharArray());
            this.banda.Add(' ');
            this.pointerBanda = 0;

            bool acceptat = false;

            while (!acceptat)
            {
                if (st_curenta != null && esteStareFinala(st_curenta))
                {
                    acceptat = true;
                }
                else
                {
                    try
                    {
                        if (st_curenta != null)
                        {
                            Tranzitie tranzitie = lt.gasesteTranzitie(st_curenta, banda[pointerBanda]);
                            if (tranzitie != null)
                            {
                                executaTranzitie(tranzitie);
                                Console.WriteLine("Banda: " + string.Join("", banda));
                            }
                            else
                            {
                                acceptat = false;
                                break;
                            }
                        }
                    }catch(ArgumentOutOfRangeException)
                    { 
                        Console.WriteLine("Capul de citire a depasit banda.");
                        acceptat = false;
                        break;
                    }
                }
            }
            return acceptat;
        }




    }
}
