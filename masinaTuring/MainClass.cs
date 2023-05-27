using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masinaTuring
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            MasinaTuring M = new MasinaTuring("C:\\Users\\stfal\\Desktop\\masinaTuring\\masinaTuring\\MasinaTuring.txt");
            Console.WriteLine("Introduceti cuvantul : ");
            string? cuvant = Console.ReadLine();
            if(cuvant != null)
            {
                bool acceptat = M.analizeazaCuvant(cuvant);
                Console.WriteLine("Cuvantul este : " + (acceptat ? "Acceptat" : "Respins"));
            }
            Console.ReadLine();
        }
    }
}
