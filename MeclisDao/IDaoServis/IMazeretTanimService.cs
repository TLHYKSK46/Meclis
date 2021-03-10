using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
   public interface IMazeretTanimService
    {
        List<MazeretTanim> ListeGetir();
       MazeretTanim Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(MazeretTanim mazeretTanim);
        void Guncelle(MazeretTanim mazeretTanim);
        void Sil(int id);
    }
}
