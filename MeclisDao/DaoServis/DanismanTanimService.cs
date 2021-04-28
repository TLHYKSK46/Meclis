using MeclisDal.BaseDb;
using MeclisDal.IDal;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MeclisDao.DaoServis
{
    public class DanismanTanimService : IDanismanTanimService
    {
        IDanismanTanimDal _danismanTanimDal;
        MeclisContext _meclisContext;

        public DanismanTanimService(IDanismanTanimDal danismanTanimDal, MeclisContext meclisContext)
        {
            _danismanTanimDal = danismanTanimDal;
            _meclisContext = meclisContext;
        }

        public List<DanismanTanim> FiltreleGetir(string tur,string value)
        {
            var data = new List<DanismanTanim>();
            switch (tur)
            {
                case "Tümü":  data= _danismanTanimDal.GetAll(p => p.Silindi == 0);
                            break;
                case "Ad Soyad":
                    data = _danismanTanimDal.GetAll(p => p.Ad.ToLower().Contains(value.ToLower()) || p.Soyad.ToLower().Contains(value.ToLower()) && p.Silindi == 0);
                    break;
                case "TC Kimlik No":
                    data = _danismanTanimDal.GetAll(p => p.TcKimlikNo== value && p.Silindi == 0);
                    break; 
            } 
            return data; 
        }

        public void Ekle(DanismanTanim danismanTanim)
        {
            try
            {
                var data = _meclisContext.DanismanTanims.FirstOrDefault(p=>p.TcKimlikNo==danismanTanim.TcKimlikNo && p.Silindi==0);
                if (data != null)
                    throw new DaoException("Danışman Zaten Sistem de Kayıtlı!,Lütfen Kontrol Ederek Tekarar Deneyiniz.");

                _danismanTanimDal.Add(danismanTanim);

            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message); ;
            }
        }

     

        public DanismanTanim Getir(int id)
        {
            return _danismanTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(DanismanTanim danismanTanim)
        {
            try
            {
                var data = _meclisContext.DanismanTanims.FirstOrDefault(p => p.Id == danismanTanim.Id && p.Silindi == 0);
                if (data == null)
                    throw new DaoException("Danışman Sistem de Bulunamadı Değiştirilmiş Yada Silinmiş Olabilir!,Lütfen Kontrol Ederek Tekarar Deneyiniz.");
                
                danismanTanim.EklenmeTarihi = data.EklenmeTarihi;
                danismanTanim.Id = data.Id;
                _danismanTanimDal.Update(danismanTanim);

            }
            catch (DaoException ex)
            {
                throw new DaoException(ex.Message); 
            }
        }

        public List<DanismanTanim> ListeGetir()
        {
            return _danismanTanimDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.DanismanTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _danismanTanimDal.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _danismanTanimDal.Delete(new DanismanTanim {Id=id });
        }
        public void ExceleAktar(DataGridView dataGridView)
        {
            try
            {
                SaveFileDialog save = new SaveFileDialog();
                save.OverwritePrompt = false;
                save.Title = "Excel Dosyaları";
                save.DefaultExt = "xlsx";
                save.Filter = "xlsx Dosyaları (*.xlsx)|*.xlsx|Tüm Dosyalar(*.*)|*.*";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                    Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                    Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                    app.Visible = true;
                    worksheet = workbook.Sheets["Sayfa1"];
                    worksheet = workbook.ActiveSheet;
                    worksheet.Name = "Excel Dışa Aktarım";
                    for (int i = 1; i < dataGridView.Columns.Count + 1; i++)
                    {
                        worksheet.Cells[1, i] = dataGridView.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView.Columns.Count; j++)
                        {
                            worksheet.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    workbook.SaveAs(save.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                    app.Quit();
                }
            }
            catch (DaoException ex)
            {
                throw new DaoException("Excel Aktarım Sırasında Hata Oluştu.Lütfen Kontrol Ederek Tekrar Deneyiniz!"+"Hata:"+ex.Message.ToString());

            }

        }
    }
}
