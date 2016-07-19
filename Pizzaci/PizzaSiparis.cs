using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Pizzaci.Repository;
using Pizzaci.Models;
using MetroFramework.Controls;

namespace Pizzaci
{

    public partial class PizzaSiparis : MetroForm
    {

        private readonly EbatRepository _ebatRepo = new EbatRepository();
        private readonly MalzemeRepository _malzemeRepo = new MalzemeRepository();
        private readonly PizzaTurRepository _pizzaTurRepository = new PizzaTurRepository();
        private readonly KenarTurRepository _kenarTurRepository = new KenarTurRepository();
        private readonly SepetRepository _sepetRepository = new SepetRepository();
        Sepet _sepet;
        public PizzaSiparis()
        {
            _sepet = new Sepet();
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ebatlar> ebat = _ebatRepo.GetAll();
            foreach (var item in ebat)
                cmbEbatlar.Items.Add(item);
            cmbEbatlar.SelectedItem = cmbEbatlar.Items[0];

            List<PizzaTur> pizzaTur = _pizzaTurRepository.GetAll();
            foreach (var item in pizzaTur)
                cmbPizzalar.Items.Add(item);
            cmbPizzalar.SelectedItem = cmbPizzalar.Items[0];
            List<KenarTur> kenar = _kenarTurRepository.GetAll();

            rdInceKenar.Tag = kenar[0];
            rdInceKenar.Text = kenar[0].KenarTurAdi;
            rdInceKenar.Select();
            rdKalinKenar.Tag = kenar[1];
            rdKalinKenar.Text = kenar[1].KenarTurAdi;

            var malzeme = _malzemeRepo.GetAll();
            var pnt = new Point(20, 20);
            int count = 0;
            foreach (var item in malzeme)
            {
                var tg = new MetroCheckBox
                {
                    Theme = MetroThemeStyle.Dark,
                    Style = MetroColorStyle.Orange,
                    Location = pnt
                };

                pnt.Y = pnt.Y + 25;
                tg.Name = "chk_" + item.MalzemeId;
                tg.Text = item.Malzeme_Adi;
                tg.Tag = item;
                groupBox1.Controls.Add(tg);
                if (count == 4)
                {
                    pnt.Y = 20;
                    pnt.X += 150;
                }
                count++;
            }






            //cmbEbatlar.DisplayMember = "Text";
            //cmbEbatlar.ValueMember = "Value";
            //cmbPizzalar.DisplayMember = "Text";
            //cmbPizzalar.ValueMember = "Value";

            //List<Ebatlar> ebat = repo.GetDimensions();           
            //foreach (var item in ebat)       
            //    cmbEbatlar.Items.Add(new { Text = item.Ebat, Value = item.EbatId });

            //List<Malzemeler> malz = repo.GetIngredients();
            //foreach (var item in malz)
            //    cmbPizzalar.Items.Add(new { Text = item.Malzeme_Adi, Value = item.MalzemeId });

            //#region chkPizzas


            //#endregion


        }

        Siparis siparis;
        private void btnHesapla_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAdet.Text))
            {
                MetroMessageBox.Show(this, "Lütfen kaç  adet istediğinizi girin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            siparis = SiparisHesapla();
            txtTutar.Text = siparis.Fiyat.ToString("C");
            btnSepeteEkle.Enabled = true;
            btnSiparisiOnayla.Enabled = true;
        }

        Siparis SiparisHesapla()
        {
            Siparis siparis = new Siparis();

            siparis.Adet = Convert.ToInt32(txtAdet.Text);
            Pizza p = new Pizza();
            p.PizzaEbat = (Ebatlar)cmbEbatlar.SelectedItem;
            p.PizzaTur = (PizzaTur)cmbPizzalar.SelectedItem;
            p.PizzaKenar = (rdInceKenar.Checked) ? (KenarTur)rdInceKenar.Tag : (KenarTur)rdKalinKenar.Tag;

            foreach (MetroCheckBox item in groupBox1.Controls)
            {
                if (item.Checked)
                {
                    p.PizzaMalzeme.Add((Malzemeler)item.Tag);
                }
            }
            siparis.Pizza = p;
            return siparis;

        }

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            _sepet.Siparisler.Add(siparis);
            lstSiparis.Items.Add(siparis);
        }

        private void btnSiparisiOnayla_Click(object sender, EventArgs e)
        {
            lblTutar.Text = "Toplam Tutar :  " + _sepet.GenelToplam.ToString("C");
            string siparisler = "";

            foreach (var item in _sepet.Siparisler)
            {
                siparisler += "#" + item.Pizza.ToString() + "\n";
            }
            _sepet.durum = true;
            _sepet.tarih = DateTime.Now;
            _sepetRepository.Add(_sepet);

            MetroMessageBox.Show(this, $"{"Sipariş(ler) : \n" + siparisler + "\n Genel Toplam : " + _sepet.GenelToplam.ToString("C")}", "Sipariş Onaylandı", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            _sepet = new Sepet();
            lstSiparis.Items.Clear();
            btnSepeteEkle.Enabled = false;
            btnSiparisiOnayla.Enabled = false;
            txtAdet.Text = "";
            txtTutar.Text = "";
        }
    }
}
