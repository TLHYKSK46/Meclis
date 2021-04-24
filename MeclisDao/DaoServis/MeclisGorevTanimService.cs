using MeclisDal.BaseDb;
using MeclisDal.IDal;
using MeclisDao.Exceptions;
using MeclisDao.IDaoServis;
using MeclisEntities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.DaoServis
{
    public class MeclisGorevTanimService : IMeclisGorevTanimService
    {
        IMeclisGorevTanimDal _meclisGorevTanimDal;
        MeclisContext _meclisContext;
        public MeclisGorevTanimService(IMeclisGorevTanimDal meclisGorevTanimDal, MeclisContext meclisContext)
        {
            _meclisGorevTanimDal = meclisGorevTanimDal;
            _meclisContext = meclisContext;
        }

        public List<MeclisGorevTanim> AdGoreGetir(string data)
        {
            return _meclisGorevTanimDal.GetAll(p=>p.MeclisGorevAdi.ToLower().Contains(data.ToLower()) && p.Silindi==0);

        }

        public void Ekle(MeclisGorevTanim meclisGorevTanim)
        {
            try
            {
                var aData = _meclisContext.MeclisGorevTanims.FirstOrDefault(p => p.MeclisGorevAdi==meclisGorevTanim.MeclisGorevAdi && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException("Zaten " + meclisGorevTanim.MeclisGorevAdi+ " Adın da  Tanımlama Yapılmıştır! ,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

                _meclisGorevTanimDal.Add(meclisGorevTanim);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message.ToString());
            }
  
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
                throw new DaoException("Excel Aktarım Sırasında Hata Oluştu.Lütfen Kontrol Ederek Tekrar Deneyiniz!" + "Hata:" + ex.Message.ToString());

            }

        }

        public MeclisGorevTanim Getir(int id)
        {
         return   _meclisGorevTanimDal.Get(p=>p.Id==id);
        }

        public void Guncelle(MeclisGorevTanim meclisGorevTanim)
        {
            try
            {
                var data = _meclisContext.GrupPersonelTanims.FirstOrDefault(p => p.Id == meclisGorevTanim.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

                meclisGorevTanim.EklenmeTarihi = data.EklenmeTarihi;
                meclisGorevTanim.Id = data.Id;
                _meclisGorevTanimDal.Update(meclisGorevTanim);

            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
        }

        public List<MeclisGorevTanim> ListeGetir()
        {
            return _meclisGorevTanimDal.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _meclisContext.MeclisGorevTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _meclisGorevTanimDal.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _meclisGorevTanimDal.Delete(new MeclisGorevTanim {Id=id });
        }
    }
}
