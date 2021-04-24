using MeclisDal.BaseDb;
using MeclisDal.BaseDb.Interfaces;
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
    public class DilTanimService : IDilTanimService
    {
        IDilTanimDal _dilTanimDal;
        MeclisContext _context;
        IVekilTanimDal _vekilTanimDal;
        IVekilDetayDal _vekilDetayDal;
        public DilTanimService(IDilTanimDal dilTanimDal, MeclisContext context, IVekilTanimDal vekilTanimDal, IVekilDetayDal vekilDetayDal)
        {
            _dilTanimDal = dilTanimDal;
            _context = context;
            _vekilTanimDal = vekilTanimDal;
            _vekilDetayDal = vekilDetayDal;
        }

        public List<DilTanim> AdGoreGetir(string data)
        {
            return _dilTanimDal.GetAll(p=>p.DilAdi.ToLower().Contains(data.ToLower())&& p.Silindi==0);
        }

        public void Ekle(DilTanim dilTanim)
        {
            var aData = _context.DilTanims.FirstOrDefault(p=>p.Id==dilTanim.Id);
            if(aData!=null)
              throw new DaoException(dilTanim.DilAdi+"Dil Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");

            _dilTanimDal.Add(dilTanim);
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
    

        public DilTanim Getir(int id)
        {
            var data= _dilTanimDal.Get(p => p.Id == id && p.Silindi == 0);
            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            return data;
        }

        public void Guncelle(DilTanim dilTanim)
        {
            var data  = _context.DilTanims.SingleOrDefault(p => p.Id == dilTanim.Id);
            if (data!=null)
            _dilTanimDal.Update(dilTanim);

            if (data == null)
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");

        }

        public List<DilTanim> ListeGetir()
        {
            //var vekildetay = _vekilDetayDal.GetAll();
            //(from dt in _dilTanimDal.GetAll()
            // join vd in vekildetay on dt.Id equals vd.DilTanimId
            // join vt in _vekilTanimDal.GetAll() on vd.DilTanimId equals vt.Id
            // select new 
            // {
            //     vt.TcKimlikNo,
            //    AdSoyad=vt.Ad+""+vt.Soyad,
            //    dt.DilAdi,
            // }

            // ).ToList();

            return _dilTanimDal.GetAll();
        }

        public void Sil(int id)
        {
            var data =  _context.DilTanims.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                Guncelle(data);

            }
            else { 
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }


            //_dilTanimDal.Delete(new DilTanim {Id=id });
        }
    }
}
