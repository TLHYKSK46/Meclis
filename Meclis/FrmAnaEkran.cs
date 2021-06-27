using Meclis.Listeler;
using Meclis.SabitTanimlar;
using Meclis.Yoklama;
using MeclisDao.IDaoServis;
using MeclisDao.Instances;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meclis
{
    public partial class FrmAnaEkran : Form
    {
        
        private IVekilTanimService _vekilTanimService;
        private IDanismanTanimService _danismanTanimService;
       
        private IKomisyonDurumService _komisyonDurumService;
        private IKomisyonTanimService _komisyonTanimService;
        private IIlTanimService _ilTanimService;
        private IPartiTanimService _partiTanimService;
        private IPartiGrupTanimService _partiGrupTanimService;
        private IMazeretTanimService _mazeretTanim;
        private IVekilDilTanimService _vekilDilTanim;
        private IDilTanimService _dilTanimService;
        private IDonemTanimService _donemTanimService;
        private IHatirlatmaTanimService _hatirlatmaTanimService;
        private IDostlukGrupTanimService _dostlukGrupTanimService;
        private IMeclisGorevTanimService _meclisGorevTanimService;
        private IVekilDanismanService _vekilDanismanService;
        private IGrupPersonelTanimService _grupPersonelTanimService;
        private IMeslekTanimService _meslekTanimService;
        private IGenelMerkezGorevService _genelMerkezGorevService;
        public FrmAnaEkran()
        {
            InitializeComponent();

         
            _vekilTanimService = InstanceFactory.GetInstance<IVekilTanimService>();
            _danismanTanimService = InstanceFactory.GetInstance<IDanismanTanimService>();
     
            _komisyonDurumService = InstanceFactory.GetInstance<IKomisyonDurumService>();
            _ilTanimService = InstanceFactory.GetInstance<IIlTanimService>();
            _partiTanimService = InstanceFactory.GetInstance<IPartiTanimService>();
            _partiGrupTanimService = InstanceFactory.GetInstance<IPartiGrupTanimService>();
            _mazeretTanim = InstanceFactory.GetInstance<IMazeretTanimService>();
            _vekilDilTanim = InstanceFactory.GetInstance<IVekilDilTanimService>();
            _dilTanimService = InstanceFactory.GetInstance<IDilTanimService>();
            _donemTanimService = InstanceFactory.GetInstance<IDonemTanimService>();
            _hatirlatmaTanimService = InstanceFactory.GetInstance<IHatirlatmaTanimService>();
            _dostlukGrupTanimService = InstanceFactory.GetInstance<IDostlukGrupTanimService>();
            _meclisGorevTanimService = InstanceFactory.GetInstance<IMeclisGorevTanimService>();
            _vekilDanismanService = InstanceFactory.GetInstance<IVekilDanismanService>();
            _grupPersonelTanimService = InstanceFactory.GetInstance<IGrupPersonelTanimService>();
            _meslekTanimService = InstanceFactory.GetInstance<IMeslekTanimService>();
            _genelMerkezGorevService = InstanceFactory.GetInstance<IGenelMerkezGorevService>();
            _komisyonTanimService = InstanceFactory.GetInstance<IKomisyonTanimService>();


        }

        private void FrmAnaEkran_Load(object sender, EventArgs e)
        {
        
            
            //dgwVekilDetay.DataSource = (from vd in _vekilDetayService.ListeGetir()
            //                            join vt in _vekilTanimService.ListeGetir() on vd.VekilTanimId equals vt.Id
            //                            join ct in _cinsiyetTanimService.ListeGetir() on vd.CinsiyetTanimId equals ct.Id
            //                            join kdt in _komisyonDurumService.ListeGetir() on vd.KomisyonDurumId equals kdt.Id
            //                            join kt in _komisyonTanimService.ListeGetir() on kdt.KomisyonTanimId equals kt.Id
            //                            join pt in _partiTanimService.ListeGetir() on vd.PartiTanimId equals pt.Id
            //                            join pgt in _partiGrupTanimService.ListeGetir() on vd.PartiGrupTanimId equals pgt.Id
            //                            join it in _ilTanimService.ListeGetir() on vd.IlTanimId equals it.Id
            //                            join mt in _mazeretTanim.ListeGetir() on vd.MazeretTanimId equals mt.Id
            //                            join vdta in _vekilDilTanim.ListeGetir() on vd.DilTanimId equals vdta.Id
            //                            join dt in _dilTanimService.ListeGetir() on vdta.DilTanimId equals dt.Id
            //                            join dont in _donemTanimService.ListeGetir() on vd.DonemTanimId equals dont.Id
            //                            join ht in _hatirlatmaTanimService.ListeGetir() on vd.HatirlatmaTanimId equals ht.Id
            //                            join dgt in _dostlukGrupTanimService.ListeGetir() on vd.DostlukGrupTanimId equals dgt.Id
            //                            join mgt in _meclisGorevTanimService.ListeGetir() on vd.MeclisGorevTanimId equals mgt.Id
            //                            join dant in _danismanTanimService.ListeGetir() on vd.DanismanTanimId equals dant.Id
            //                            join dantt in _danismanTanimService.ListeGetir() on ct.Id equals dantt.IlTanimId
            //                            join vdt in _vekilDanismanService.ListeGetir() on  vd.VekilDanismanId equals vdt.Id
            //                            join gpt in _grupPersonelTanimService.ListeGetir() on vd.GrupPersonelTanimId equals gpt.Id
            //                            join mest in _meslekTanimService.ListeGetir() on vd.MeslekTanimId equals mest.Id
            //                            select new 
            //                            {
            //                                vd.Id,
            //                                vt.TcKimlikNo,
            //                                vt.Ad,
            //                                vt.Soyad,
            //                                ct.CinsiyetAdi,
            //                                kt.IhtisasAdi,
            //                                it.IlAdi,
            //                                mt.MazeretNedeni,
            //                                mgt.MeclisGorevAdi,
            //                             mest.MeslekAdi,
            //                                pt.PartiAdi,
            //                                pgt.PartiGrupAdi,
            //                                hatirlatmabaşlık =ht.Baslik,
            //                                hatirlatmaDetay=ht.Aciklama,
            //                                dgt.DostlukGrupAdi,
            //                                dont.DonemAdi,
            //                                grupPerTC=gpt.TcKimlikNo,
            //                               GrupAdSoayd=gpt.Ad+""+gpt.Soyad,
            //                                DanismanTC = dant.TcKimlikNo,
            //                                DanismanAdSoayad = dant.Ad+""+dant.Soyad,
            //                                dt.DilAdi,
                                          
            //                            }).ToList();


        }

        private void dilTanimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDilTanim = new FrmVekilDilTanim();
            frmDilTanim.Show();
        }

        private   void vekilTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmVekilTanim = new FrmVekilTanim();
            frmVekilTanim.Show();
        }

        private void dönemTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDonemTanim = new FrmDonemTanim();
            frmDonemTanim.Show();
        }

        private void dostlukGrupTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDoslukGrupTanim = new FrmDostlukGrupTanim();
            frmDoslukGrupTanim.Show();

        }

        private void genelMerkezGörevTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGenelMerkezGorev = new FrmGenelMerkezGorev();
            frmGenelMerkezGorev.Show();
        }

        private void grupPersonelTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmGrupPersonelTanim = new FrmGrupPersonelTanim();
            frmGrupPersonelTanim.Show();
        }

        private void hatırlatmaTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmHatirlatmaTanim = new FrmHatirlatmaTanim();
            frmHatirlatmaTanim.Show();
        }

     

        private void komisyonTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmKomisyonTanim = new FrmKomisyonTanim();
            frmKomisyonTanim.Show();

        }

        private void mazeretTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmMazeretTanim = new FrmMazeretTanim();
            frmMazeretTanim.Show();
        }

        private void meclisGörevTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmMeclisGorevTanim = new FrmMeclisGorevTanim();
            frmMeclisGorevTanim.Show();
        }

        private void meslekTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmMeslekTanim = new FrmMeslekTanim();
            frmMeslekTanim.Show();
        }

        private void partiTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmPartiTanim = new FrmPartiTanim();
            frmPartiTanim.Show();
        }

        private void vekilDanışmanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmVekilDanisman = new FrmVekilDanisman();
            frmVekilDanisman.Show();
        }

        private void danismanTanimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDanismanTanim = new FrmDanismanTanim();
            frmDanismanTanim.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void meslekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmMeslekList = new FrmMeslekListe();
            frmMeslekList.Show();
        }

        private void danismanListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FrmDanismanListe();
            frm.Show();
        }

        private void dilListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmDilListe();
            frm.Show();
        }

        private void genelMerkezGörevListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmGenelMerkezGorevListe();
            frm.Show();
        }

        private void grupPersonelListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmGrupPersonelListe();
            frm.Show();
        }

        private void komisyonListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmKomisyonListe();
            frm.Show();
        }

        private void meclisGörevListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMeclisGorevListe();
            frm.Show();
        }

        private void mazeretListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMazeretListe();
            frm.Show();
        }

        private void grupBaşkanTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmGrupBaskanTanim();
            frm.Show();
        }

        private void yoklamaİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmYoklama();
            frm.Show();
        }

        private void masaTanımToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMasaTanim();
            frm.Show();
        }

        private void masaOturmaDüzeniListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FrmMasaOturmaDuzen();
            frm.Show();
        }
    }
}
