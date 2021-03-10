using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeclisDao.IDaoServis
{
    public interface IMazeretKodService
    {
        List<MazeretKod> ListeGetir();
        MazeretKod Getir(int id);
        //List<CinsiyetTanim> AdGoreGetir(string productName);
        void Ekle(MazeretKod mazeretKod);
        void Guncelle(MazeretKod mazeretKod);
        void Sil(MazeretKod mazeretKod);
    }
}
