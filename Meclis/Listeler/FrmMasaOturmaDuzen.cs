using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using MeclisDao.MessageDialogs;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meclis.Listeler
{
    public partial class FrmMasaOturmaDuzen : Form
    {
        private IVekilTanimService _vekilTanimService;
        private IMasaTanimService _masaTanimService;
        private IMasaOturumDuzenService _masaOturumDuzenService;
        private IIlTanimService _ilTanimService;
        public FrmMasaOturmaDuzen()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _masaOturumDuzenService = InstanceFactory.GetInstance<IMasaOturumDuzenService>();
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            _masaTanimService = InstanceFactory.GetInstance<IMasaTanimService>();
            _ilTanimService = InstanceFactory.GetInstance<IIlTanimService>();


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            vekilListele();

        }

        private void FrmMasaOturmaDuzen_Load(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }

        private void vekilListele()
        {

            var liste = new List<VekilTanim>();
            foreach (var item in _vekilTanimService.ListeGetir().ToList())
            {
                //if (item.Foto!=null)
                //{
                //    var foto = ConvertByteArrayImage(item.Foto);
                //    chkListVekil.Items.Add(item.Id + "" + foto + " " + item.Ad + " " + item.Soyad);

                //}
                var il = _ilTanimService.Getir(item.IlTanimId);
                chkListVekil.Items.Add($"{item.Id}-{item.Ad} {item.Soyad} {item.KisiselTelNo}-{il.IlAdi}");
            }
        }
        public Image ConvertByteArrayImage(byte[] data)
        {

            using (MemoryStream ms = new MemoryStream(data))
            {
                return Image.FromStream(ms);
            }

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var list = new List<MasaOturmaDuzen>();
            var masa = _masaTanimService.ListeGetir().Where(x => x.Tarih.Date == dtTarih.Value.Date).FirstOrDefault();
            int vekilId= 0;
            for (int i = 0; i < listMasaOturanlar.Items.Count; i++)
            {
                var item = listMasaOturanlar.Items[i].ToString();
                string[] metin = item.ToString().Split('-');
                for (int j = 0; j < metin.Length; j++)
                {
                    vekilId=Convert.ToInt32(metin[j]);
                    break;
                }
                list.Add(new MasaOturmaDuzen { MasaTanimId =masa.Id, VekilTanimId =vekilId ,Tarih=masa.Tarih});
            }
            var kontrol = list.Count>masa.KacKisilik ? MesajGoster.Uyari($"Bu Masa {masa.KacKisilik} kişilik olarak tanımlandı! ") :true;
            if (kontrol!=true)
            {
                foreach (var item in list)
                {
                    _masaOturumDuzenService.Ekle(new MasaOturmaDuzen { Tarih = item.Tarih.Date, MasaTanimId = item.MasaTanimId, VekilTanimId = item.VekilTanimId });
                }
                MesajGoster.Basarili("Oturma Düzeni Başarıyla Oluşturuldu");
            }
          
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            listMasaOturanlar.Items.Clear();
            for (int i = 0; i < chkListVekil.CheckedItems.Count; i++)
            {
                listMasaOturanlar.Items.Add((string)chkListVekil.CheckedItems[i]);
            }
        }

        private void chkListVekil_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kackisilik = 0;
            var masa = _masaTanimService.ListeGetir().Where(x => x.Tarih.Date == dtTarih.Value.Date).FirstOrDefault();
            if (masa!=null)
            {
                kackisilik = masa.KacKisilik;
            }
            label1.Text = chkListVekil.CheckedItems.Count + " eleman seçildi. " + kackisilik + " Kişi Seçilmelidir.";
        }

        private void chkListVekil_MouseClick(object sender, MouseEventArgs e)
        {
            //int toplam = chkListVekil.Items.Count;
            //for (int i = 0; i < toplam; i++)
            //{
            //    chkListVekil.SetItemChecked(i, true);
            //}
            //label1.Text = toplam + " adet eleman seçildi.";
        }


    }
}
