using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace What.I.Have.Done
{
    public partial class Duzenle : Form
    {
        private readonly Mesaj _msj;

       
        public Duzenle(Mesaj mesaj)
        {
            _msj = mesaj;
            InitializeComponent();
            txtYapilan.Text = _msj.Metin;
            dtpZaman.Value = _msj.OlusturmaZamani.Value;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            Close();
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        AnaForm fr = new AnaForm();
            
            string metin = txtYapilan.Text;

            if (metin == "")
            {
                MessageBox.Show("Düzenlemek istediğiniz metini girin.");
                return;
            }

            if (_msj == null)
            {
                txtYapilan.Text = _msj.Metin;
                dtpZaman.Value = _msj.OlusturmaZamani.Value;
            }
            else
            {
               
                _msj.Metin = txtYapilan.Text;
                _msj.OlusturmaZamani = dtpZaman.Value;
            }

            fr.lstYapilanlar.SelectedItem = _msj;

            Close();

        }


    }
}
