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
    public class GenelMerkezGorevService : IGenelMerkezGorevService
    {
        IGenelMerkezGorevDal _genelMerkez;
        MeclisContext _context;
        public GenelMerkezGorevService(IGenelMerkezGorevDal genelMerkez, MeclisContext context)
        {
            _genelMerkez = genelMerkez;
            _context = context;
        }

        public List<GenelMerkezGorev> AdGoreGetir(string data)
        {
            return _genelMerkez.GetAll(p=>p.GenelMerkezGorevAdi.ToLower().Contains(data.ToLower()) && p.Silindi==0);
        }

        public void Ekle(GenelMerkezGorev genelMerkezGorev)
        {
            try
            {
                var aData = _context.GenelMerkezGorevs.FirstOrDefault(p => p.GenelMerkezGorevAdi == genelMerkezGorev.GenelMerkezGorevAdi && p.Silindi == 0);
                if (aData != null)
                    throw new DaoException(genelMerkezGorev.GenelMerkezGorevAdi + "Bu Görev Sistemde Kayıtlıdır,Lütfen Kontrol Ederek Tekrar Deneyiniz..");
                _genelMerkez.Add(genelMerkezGorev);
            }
            catch (Exception ex)
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

        public GenelMerkezGorev Getir(int id)
        {
            return _genelMerkez.Get(p=>p.Id==id);
        }

        public void Guncelle(GenelMerkezGorev genelMerkezGorev)
        {
            try
            {
                var data = _context.VekilDilTanims.FirstOrDefault(p => p.Id == genelMerkezGorev.Id);
                if (data == null)
                    throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");


                genelMerkezGorev.EklenmeTarihi = data.EklenmeTarihi;
                genelMerkezGorev.Id = data.Id;

                _genelMerkez.Update(genelMerkezGorev);
            }
            catch (DaoException ex)
            {

                throw new DaoException(ex.Message);
            }
          
        }

        public List<GenelMerkezGorev> ListeGetir()
        {
            return _genelMerkez.GetAll(p=>p.Silindi==0);
        }

        public void Sil(int id)
        {
            var data = _context.GenelMerkezGorevs.SingleOrDefault(p => p.Id == id);
            if (data != null && data.Silindi != 1)
            {
                data.Silindi = 1;
                _genelMerkez.Delete(data);


            }
            else
            {
                throw new DaoException("Bu Kayıt Silinmiş Yada Değiştirilmiş Olabilir.Lütfen Kontrol Ederek Tekrar Deneyiniz!");
            }
           // _genelMerkez.Delete(new GenelMerkezGorev { Id=id});
        }
    }
}
