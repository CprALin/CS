using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TADP
{
    public partial class Form1 : Form
    {
        private Button[] lb = new Button[3]; 
        public Form1()
        {
            InitializeComponent();

            lb[0] = btnActualizare;
            lb[1] = btnSalvare;
            lb[2] = btnRenuntare;
        }

        private void refresh()
        {
            this.judeteTableAdapter.Fill(this.dataSet1.Judete);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Model1.Config(true, dataGridView1, lb);
            refresh();
        }

        private void BtnActualizare_Click(object sender, EventArgs e)
        {
            Model1.Config(false , dataGridView1, lb);
        }

        private void BtnSalvare_Click(object sender, EventArgs e)
        {
            try
            {
                judeteTableAdapter.Update(this.dataSet1.Judete);
                Model1.Config(true, dataGridView1, lb);
                refresh();
            }catch (Exception ex)
            {
                Model1.TrateazaEroarea(ex);
            }
        }

        private void BtnRenuntare_Click(object sender, EventArgs e)
        {
            Model1.Config(true, dataGridView1, lb);
            refresh();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if(!Model1.Confirmare()) e.Cancel = true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }
    }
}
