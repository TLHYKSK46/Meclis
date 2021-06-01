using MeclisDal.Dal;
using MeclisDal.IDal;
using MeclisDao.DaoServis;
using MeclisDao.IDaoServis;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.Instances
{
  public  class DaoModul:NinjectModule
    {
        public override void Load()
        {
            //Classların İnstance larını oluşturmak için yazmak zorundasın...
    


            Bind<IDanismanTanimService>().To<DanismanTanimService>().InSingletonScope();
            Bind<IDanismanTanimDal>().To<DanismanTanimDal>().InSingletonScope();

            Bind<IDilTanimService>().To<DilTanimService>().InSingletonScope();
            Bind<IDilTanimDal>().To<DilTanimDal>().InSingletonScope();

            Bind<IDilSeviyeTanimService>().To<DilSeviyeTanimService>().InSingletonScope();
            Bind<IDilSeviyeTanimDal>().To<DilSeviyeTanimDal>().InSingletonScope();

            Bind<IDonemTanimService>().To<DonemTanimService>().InSingletonScope();
            Bind<IDonemTanimDal>().To<DonemTanimDal>().InSingletonScope();

            Bind<IDostlukGrupTanimService>().To<DostlukGrupTanimService>().InSingletonScope();
            Bind<IDostlukGrupTanimDal>().To<DostlukGrupTanimDal>().InSingletonScope();

            Bind<IGenelMerkezGorevService>().To<GenelMerkezGorevService>().InSingletonScope();
            Bind<IGenelMerkezGorevDal>().To<GenelMerkezGorevDal>().InSingletonScope();

            Bind<IGrupPersonelTanimService>().To<GrupPersonelTanimService>().InSingletonScope();
            Bind<IGrupPesonelTanimDal>().To<GrupPersonelTanimDal>().InSingletonScope();

            Bind<IHatirlatmaTanimService>().To<HatirlatmaTanimService>().InSingletonScope();
            Bind<IHatirlatmaTanimDal>().To<HatirlatmaTanimDal>().InSingletonScope();

            Bind<IIlTanimService>().To<IlTanimService>().InSingletonScope();
            Bind<IIlTanimDal>().To<IlTanimDal>().InSingletonScope();

            Bind<IKomisyonDurumService>().To<KomisyonDurumService>().InSingletonScope();
            Bind<IKomisyonDurumDal>().To<KomisyonDurumDal>().InSingletonScope();

            Bind<IKomisyonTanimService>().To<KomisyonTanimService>().InSingletonScope();
            Bind<IKomisyonTanimDal>().To<KomisyonTanimDal>().InSingletonScope();

            Bind<IKomisyonUyeService>().To<KomisyonUyeService>().InSingletonScope();
            Bind<IKomisyonUyeDal>().To<KomisyonUyeDal>().InSingletonScope();

            Bind<IMazeretKodService>().To<MazeretKodService>().InSingletonScope();
            Bind<IMazeretKodDal>().To<MazeretKodDal>().InSingletonScope();

            Bind<IMazeretTanimService>().To<MazeretTanimService>().InSingletonScope();
            Bind<IMazeretTanimDal>().To<MazeretTanimDal>().InSingletonScope();

            Bind<IMeclisGorevTanimService>().To<MeclisGorevTanimService>().InSingletonScope();
            Bind<IMeclisGorevTanimDal>().To<MeclisGorevTanimDal>().InSingletonScope();

            Bind<IPartiTanimService>().To<PartiTanimService>().InSingletonScope();
            Bind<IPartiTanimDal>().To<PartiTanimDal>().InSingletonScope();

            Bind<IPartiGrupTanimService>().To<PartiGrupTanimService>().InSingletonScope();
            Bind<IPartiGrupTanimDal>().To<PartiGrupTanimDal>().InSingletonScope();

            Bind<IVekilTanimService>().To<VekilTanimService>().InSingletonScope();
            Bind<IVekilTanimDal>().To<VekilTanimDal>().InSingletonScope();

            Bind<IVekilDanismanService>().To<VekilDanismanService>().InSingletonScope();
            Bind<IVekilDanismanDal>().To<VekilDanismanDal>().InSingletonScope();

            Bind<IVekilDetayService>().To<VekilDetayService>().InSingletonScope();
            Bind<IVekilDetayDal>().To<VekilDetayDal>().InSingletonScope();


            Bind<IMeslekTanimService>().To<MeslekTanimService>().InSingletonScope();
            Bind<IMeslekTanimDal>().To<MeslekTanimDal>().InSingletonScope();

            Bind<IVekilDilTanimService>().To<VekilDilTanimService>().InSingletonScope();
            Bind<IVekilDilTanimDal>().To<VekilDilTanimDal>().InSingletonScope();


            Bind<IGrupBaskanTanimService>().To<GrupBaskanTanimService>().InSingletonScope();
            Bind<IGrupBaskanTanimDal>().To<GrupBaskanTanimDal>().InSingletonScope();

            Bind<IGrupBaskanVekilTanimService>().To<GrupBaskanVekilTanimService>().InSingletonScope();
            Bind<IGrupBaskanVekilTanimDal>().To<GrupBaskanVekilTanimDal>().InSingletonScope();

            Bind<IGrupYonetimKurulUyesiService>().To<GrupYonetimKurulUyesiDal>().InSingletonScope();
            Bind<IGrupYonetimKurulUyesiDal>().To<GrupYonetimKuruluUyesiDal>().InSingletonScope();

        }
    }
}
