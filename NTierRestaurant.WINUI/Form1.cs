using NTierRestaurant.BLL.DesignPatterns.GenericRepositoryPattern.ConcRep;
using NTierRestaurant.MODEL.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTierRestaurant.WINUI
{
    public partial class Form1 : Form
    {
        CategoryRepository _cRep;
        public Form1()
        {
            InitializeComponent();
            _cRep = new CategoryRepository();
        }

        private void KategorileriListele()
        {
            dgvKategoriler.DataSource = _cRep.GetAll();
            dgvKategoriler.ClearSelection();
            txtAciklama.Text = txtIsim.Text = string.Empty;
        }
        public bool TextControl()
        {
            if (txtIsim.Text.Trim() == string.Empty || txtAciklama.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Lütfen alanları boş bırakmayınız");
                return false;
            }
            return true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KategorileriListele();
        }
        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            KategorileriListele();
        }

        private void bnKategoriEkle_Click(object sender, EventArgs e)
        {
            if (!TextControl()) return;

            _cRep.Add(new Category(txtIsim.Text, txtAciklama.Text));

            KategorileriListele();
        }

        private void btnAktifler_Click(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = _cRep.GetActives();
        }

        private void btnModified_Click(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = _cRep.GetModifieds();

        }

        private void btnSilinenler_Click(object sender, EventArgs e)
        {
            dgvKategoriler.DataSource = _cRep.GetPassives();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYokEt_Click(object sender, EventArgs e)
        {
            if (modify is null)
            {
                MessageBox.Show("Silinecek veriyi seçmemizsiniz");
                return;
            }
            _cRep.Destroy(modify);
            modify = null;
            KategorileriListele();
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (modify == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz veriyi seçiniz.");
                return;
            }

            _cRep.Delete(modify);
            modify = null;

            KategorileriListele();
        }

        Category modify;
        private void dgvKategoriler_Click(object sender, EventArgs e)
        {
            if (dgvKategoriler.SelectedRows.Count > 0)
            {
                //Alt tarafta DataGridView'in seçili satırlarının ID isimli hücresinin değerine ulaşıp, o değer object tipinde olduğu için onu int tipine çevirdik.
                int id = Convert.ToInt32(dgvKategoriler.SelectedRows[0].Cells["ID"].Value);
                modify = _cRep.Find(id);//burada modifiye etmek istediğimiz veriyi id'sinden yakalayarak Repository sınınıfımız intance'inin Find methodu sayesinde bulduk ve modify değişkenine atadık.

                txtAciklama.Text = modify.Description;
                txtIsim.Text = modify.Name;

            }
        }
    }
}
