using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace What.I.Have.Done
{
    public partial class AnaForm : Form
    {

        List<Mesaj> mesajlar = new List<Mesaj>();
        Mesaj msj;
        public AnaForm()
        {
            VerileriOku();
            InitializeComponent();
            Listele();
        }

        private void VerileriOku()
        {
            try
            {
            // verileri oku ve deserialize et
                string json = File.ReadAllText("veri.json");
                mesajlar = JsonSerializer.Deserialize<List<Mesaj>>(json);

            }
            catch (Exception)
            {

                mesajlar = new List<Mesaj>();
                
            }
        }

        private void Listele()
        {
            lstYapilanlar.Items.Clear();

            mesajlar.Sort();

            foreach (var item in mesajlar)
            {
                lstYapilanlar.Items.Add(item);
            }
        }
        public void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMesaj.TextLength == 0)
            {
                MessageBox.Show("Herhangi bir mesaj girmediniz, mesaj girmeden yapılanlar listesine ekleme işlemi yapamazsınız. ");
                return;
            }
            Mesaj msj = new Mesaj();
            msj.Metin = txtMesaj.Text.ToString();

            if (dtpAnaForm.Visible == true)
            {
                msj.OlusturmaZamani = dtpAnaForm.Value;
            }
            else
            {
                msj.OlusturmaZamani = DateTime.Now;
            }
            mesajlar.Add(msj);

            Listele();
            txtMesaj.Clear();
        }
        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (lstYapilanlar.SelectedItem == null)
            {
                MessageBox.Show("Satır seçmeden düzenleme yapamazsınız, lütfen önce bir satır seçiniz.");
                return;
            }

            new Duzenle((Mesaj)lstYapilanlar.SelectedItem).ShowDialog();

            Listele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstYapilanlar.SelectedItem == null)
            {
                MessageBox.Show("Herhangi bir satır seçmediniz, satır seçilmeden silme işlemi yapamazsınız. ");
                return;
            }
            else
            {
                DialogResult dr = MessageBox.Show(
                   "Seçili satır silinecektir,Onaylıyor Musunuz?",
                   "Satır Silme Onayı",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Exclamation,
                   MessageBoxDefaultButton.Button2
                   );
                if (dr == DialogResult.Yes)
                {
                    mesajlar.Remove((Mesaj)lstYapilanlar.SelectedItem);
                    Listele();
                }
            }
        }
        private void btnYildizla_Click(object sender, EventArgs e)
        {
            if (lstYapilanlar.SelectedIndex > -1)
            {
                Mesaj m = (Mesaj)lstYapilanlar.SelectedItem;
                m.YildizliMi = !m.YildizliMi;
                Listele();
            }

        }

        private void btnTarihSec_Click(object sender, EventArgs e)
        {
            dtpAnaForm.Visible = true;
        }

        private void checkBYildizliGoster_CheckedChanged(object sender, EventArgs e)
        {
            lstYapilanlar.Items.Clear();

            foreach (var item in mesajlar)
            {
                if (item.ToString().Contains("★"))
                {
                    lstYapilanlar.Items.Add(item);
                }
            }
            if (checkBYildizliGoster.Checked == false)
            {
                Listele();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string aranan = txtMesaj.Text;

            string zaman = dtpAnaForm.Value.ToString();

            lstYapilanlar.Items.Clear();

            foreach (var item in mesajlar)
            {
                if (item.ToString().ToLower().Contains(aranan.ToLower()) || item.ToString().ToLower().Contains(zaman.ToLower()))
                {
                    lstYapilanlar.Items.Add(item);
                }
            }

        }

        private void checkBYenile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBYenile.Checked == true)
            {
                Listele();
            }
            checkBYenile.Checked = false;
        }

        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VerileriKaydet();
        }

        private void VerileriKaydet()
        {
            var options = new JsonSerializerOptions() { WriteIndented = true }; // json'ı okunaklı (indentation ile) oluştur
            string json = JsonSerializer.Serialize(mesajlar, options);
            File.WriteAllText("veri.json", json);
        }
    }
}
