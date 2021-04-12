using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MeclisDal.IDal;
using MeclisDal.BaseDb;

namespace MeclisDao.DaoServis
{
    public class VekilDetayService : IVekilDetayService
    {
        IVekilDetayDal _DetayDal;
        MeclisContext _meclisContext;
        IVekilTanimDal _vekilTanimDal;
        ICinsiyetTanimDal _cinsiyetTanimDal;
        IDanismanTanimDal _danismanTanimDal;
        IGenelMerkezGorevDal _genelMerkezGorevDal;
        IKomisyonDurumDal _komisyonDurumDal;
        IIlTanimDal _ilTanimDal;
        IPartiTanimDal _partiTanimDal;
        IMazeretTanimDal _mazeretTanimDal;
        IDilTanimDal _dilTanimDal;
        //buraya dil seviyedal gelecek
        IDonemTanimDal _donemTanimDal;
        IHatirlatmaTanimDal _hatirlatmaTanimDal;
        IDostlukGrupTanimDal _dostlukGrupTanimDal;
        IMeclisGorevTanimDal _meclisGorevTanimDal;
        IVekilDanismanDal _vekilDanismanDal;
        IGrupPesonelTanimDal _grupPesonelTanimDal;
        IMeslekTanimDal _meslekTanimDal;
        IKomisyonTanimDal _komisyonTanim;
        IPartiGrupTanimDal _partiGrup;




        public VekilDetayService(IVekilDetayDal detayDal, MeclisContext meclisContext,
            IVekilTanimDal vekilTanimDal, ICinsiyetTanimDal cinsiyetTanimDal, IDanismanTanimDal danismanTanimDal,
            IMeslekTanimDal meslekTanimDal, IGrupPesonelTanimDal grupPesonelTanimDal, IVekilDanismanDal vekilDanismanDal
, IMeclisGorevTanimDal meclisGorevTanimDal, IDostlukGrupTanimDal dostlukGrupTanimDal, IHatirlatmaTanimDal hatirlatmaTanimDal,
            IDonemTanimDal donemTanimDal, IDilTanimDal dilTanimDal, IMazeretTanimDal mazeretTanimDal, IPartiTanimDal partiTanimDal,
            IIlTanimDal ilTanimDal, IKomisyonDurumDal komisyonDurumDal, IGenelMerkezGorevDal genelMerkezGorevDal, IKomisyonTanimDal komisyonTanim, IPartiGrupTanimDal partiGrup)
        {
            _DetayDal = detayDal;
            _meclisContext = meclisContext;
            _vekilTanimDal = vekilTanimDal;
            _cinsiyetTanimDal = cinsiyetTanimDal;
            _danismanTanimDal = danismanTanimDal;
            _meslekTanimDal = meslekTanimDal;
            _grupPesonelTanimDal = grupPesonelTanimDal;
            _vekilDanismanDal = vekilDanismanDal;
            _meclisGorevTanimDal = meclisGorevTanimDal;
            _dostlukGrupTanimDal = dostlukGrupTanimDal;
            _hatirlatmaTanimDal = hatirlatmaTanimDal;
            _donemTanimDal = donemTanimDal;
            _dilTanimDal = dilTanimDal;
            _mazeretTanimDal = mazeretTanimDal;
            _partiTanimDal = partiTanimDal;
            _ilTanimDal = ilTanimDal;
            _komisyonDurumDal = komisyonDurumDal;
            _genelMerkezGorevDal = genelMerkezGorevDal;
            _komisyonTanim = komisyonTanim;
            _partiGrup = partiGrup;
        }

        public List<VekilDetay> AdGoreGetir(string vekilAdi)
        {
            throw new NotImplementedException();
        }

        public void Ekle(VekilDetay vekilDetay)
        {
            _DetayDal.Add(vekilDetay);
        }

        public VekilDetay Getir(int id)
        {
            return _DetayDal.Get(p => p.Id == id);
        }

        public void Guncelle(VekilDetay vekilDetay)
        {
            _DetayDal.Update(vekilDetay);
        }

        public List<VekilDetay> ListeGetir()
        {
            var vekidetayList = _DetayDal.GetAll();
            var vekiltanimList = _vekilTanimDal.GetAll();
            var cinsiyetList = _cinsiyetTanimDal.GetAll();
            var komisyonDurumList = _komisyonDurumDal.GetAll();
            var komisyonTanimList = _komisyonTanim.GetAll();
            var partiList = _partiTanimDal.GetAll();
            var partiGrupList = _partiGrup.GetAll();
            var ilList = _ilTanimDal.GetAll();
            var mazeretList = _mazeretTanimDal.GetAll();
            var dilList = _dilTanimDal.GetAll();
            var donemList = _donemTanimDal.GetAll();
            var hatirlatmaList = _hatirlatmaTanimDal.GetAll();
            var dostlukList = _dostlukGrupTanimDal.GetAll();
            var meclisGorevList = _meclisGorevTanimDal.GetAll();
            var danismanList = _danismanTanimDal.GetAll();
            var vekilDanismaLİst = _vekilDanismanDal.GetAll();
            var grupPersonelList = _grupPesonelTanimDal.GetAll();
            var meslekList = _meslekTanimDal.GetAll();


            var liste = (from vd in vekidetayList
                         join vt in _meclisContext.VekilTanims on vd.VekilTanimId equals vt.Id
                         //join ct in cinsiyetList on vd.CinsiyetTanimId equals ct.Id
                         //join kdt in komisyonDurumList on vd.KomisyonDurumId equals kdt.Id
                         //join kt in komisyonTanimList on kdt.KomisyonTanimId equals kt.Id
                         //join pt in partiList on vd.PartiTanimId equals pt.Id
                         //join pgt in partiGrupList on vd.PartiGrupTanimId equals pgt.Id
                         //join it in ilList on vd.IlTanimId equals it.Id
                         //join mt in mazeretList on vd.MazeretTanimId equals mt.Id
                         //join dt in dilList on vd.DilTanimId equals dt.Id
                         //join dont in donemList on vd.DonemTanimId equals dont.Id
                         //join ht in hatirlatmaList on vd.HatirlatmaTanimId equals ht.Id
                         //join dgt in dostlukList on vd.DostlukGrupTanimId equals dgt.Id
                         //join mgt in meclisGorevList on vd.MeclisGorevTanimId equals mgt.Id
                         //join dant in danismanList on vd.DanismanTanimId equals dant.Id
                         //join dantt in danismanList on ct.Id equals dantt.IlTanimId
                         //join vdt in vekidetayList on vd.VekilDanismanId equals vdt.Id
                         //join gpt in grupPersonelList on vd.GrupPersonelTanimId equals gpt.Id
                         //join mest in meslekList on vd.MeslekTanimId equals mest.Id
                         select new VekilDetay
                         {
                             VekilTanimId = vt.Id,
                             //CinsiyetTanimId = ct.Id,
                             //KomisyonDurumId = kt.Id,
                             //IlTanimId = it.Id,
                             //MazeretTanimId = mt.Id,
                             //MeclisGorevTanimId = mgt.Id,
                             //MeslekTanimId = mest.Id,
                             //PartiTanimId = pt.Id,
                             //HatirlatmaTanimId = ht.Id,
                             //DostlukGrupTanimId = dgt.Id,
                             //DonemTanimId = dont.Id,
                             //GrupPersonelTanimId = gpt.Id,
                             //VekilDanismanId = vdt.Id,
                             //DanismanTanimId = dant.Id,
                             //DilTanimId = dt.Id,
                             //PartiGrupTanimId = pgt.Id,
                         }).ToList();
         

            return _DetayDal.GetAll();

        }



        public void Sil(int id)
        {
            _DetayDal.Delete(new VekilDetay { Id = id });
        }

        public List<VekilDetay> TcNoyeGöreGetir(int tcNo)
        {
            //    return _DetayDal.GetAll(p=>p.tc);    
            return _DetayDal.GetAll();
        }
    }
}
