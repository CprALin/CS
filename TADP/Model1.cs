using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TADP
{
    internal class Model1
    {
        public static void Config(bool v, DataGridView dg , Button[] l)
        {
            dg.AllowUserToAddRows = !v;
            dg.AllowUserToDeleteRows = !v;
            dg.ReadOnly = v;
            l[0].Enabled = v;
            l[1].Enabled = !v;
            l[2].Enabled = !v;
        }

        public static void TrateazaEroarea(Exception e)
        {
            string s = e.Message;
            if(s.IndexOf("duplicate values") > 0)
            {
                MessageBox.Show("Inregistrare deja existenta !");
            }else if(s.IndexOf("cannot be deleted") > 0)
            {
                MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
            else 
            {
                MessageBox.Show("Completeaza campurile libere !");
            }
        }

        public static bool Confirmare()
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            DialogResult rezultat = MessageBox.Show(mesaj , titlu , MessageBoxButtons.YesNo , MessageBoxIcon.Warning );
            if(rezultat == DialogResult.No)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
