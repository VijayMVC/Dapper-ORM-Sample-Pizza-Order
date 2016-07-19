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
        GeneralRepository repo = new GeneralRepository();
        public PizzaSiparis()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            List<Ebatlar> ebat = repo.GetDimensions();
            foreach (var item in ebat)
                cmbEbatlar.Items.Add(item);

            List<PizzaTur> pizzaTur = repo.GetPizzas();
            foreach (var item in pizzaTur)
                cmbPizzalar.Items.Add(item);
            List<KenarTur> kenar = repo.GetPizzaEdges();

            rdInceKenar.Tag = kenar[0];
            rdInceKenar.Text = kenar[0].KenarTurAdi;
            rdKalinKenar.Tag = kenar[1];
            rdKalinKenar.Text = kenar[1].KenarTurAdi;

            List<Malzemeler> malzeme = repo.GetIngredients();

           
            Point pnt = new Point(20, 20);
            int count = 0;
            foreach (var item in malzeme)
            {
                MetroCheckBox tg = new MetroCheckBox();
                tg.Theme = MetroThemeStyle.Dark;
                tg.Style= MetroColorStyle.Orange;
                tg.Location=pnt;
             
                pnt.Y = pnt.Y + 25;
                tg.Name = "chk_"+item.MalzemeId;
                tg.Text = item.Malzeme_Adi;
                groupBox1.Controls.Add(tg);
                if (count==4)
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

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            Siparis siparis = SiparisHesapla();
            txtTutar.Text = siparis.Fiyat.ToString("C");

        }


        Siparis SiparisHesapla()
        {
            Siparis siparis = new Siparis();

            siparis.Adet = Convert.ToInt32(txtAdet.Text);
            Pizza p = new Pizza();
            p.PizzaEbat = (Ebatlar)cmbEbatlar.SelectedItem;
            p.PizzaTur =  (PizzaTur)cmbPizzalar.SelectedItem;
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
    }
}
