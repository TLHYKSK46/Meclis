using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibReport
{
    public class FastReport
    {
        SqlDataAdapter da = new SqlDataAdapter("SELECT ID,adi,soyadi,telefon,adres2,firmaAdi,tcKimlikNo,faks,aciklama,grup from kayit where grup=2 AND status=1", baglanti);//Bu kod satırı veri tabanına bağlanıyor ve istediğimiz dataları çekmemizi sağlıyor.
        DataSet dataset = new DataSet();
        da.Fill(dataset, "dataset");//gelen verileri dataset'e dataset veritabanı adıyla yüklüyor. 
            rapor.RegisterData(dataset, "dataset");//dataları FastReporta gönderiyor. 
           rapor.Design();//FastReport design sayfasını açar.
    }
}
