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
            Bind<IProductService>().To<ProductServis>().InSingletonScope();
            Bind<IProductDal>().To<ProductDal>().InSingletonScope();

           
        }
    }
}
