using MeclisDao.Utils.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.Utils
{
   public class OpenFileSvc
    {
        public static EntYoklamaExcel OpenFileToExcel(string fileName) {
            OpenFileDialog f = new OpenFileDialog();

            EntYoklamaExcel yoklama = new EntYoklamaExcel
            {
                Title= "Excel Dosyası Seçiniz",
                FileName=fileName,
                Filter= "Excel Sheet (*.xls)|*.xls|Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*",
                FilterIndex=1,
                RestoreDirectory=true,
                
            };
            f.Title = "Excel Dosyası Seçiniz";
            f.FileName = fileName;
            f.Filter = "Excel Sheet (*.xls)|*.xls|Excel Sheet(*.xlsx)|*.xlsx|All Files(*.*)|*.*";
            f.FilterIndex = 1;
            f.RestoreDirectory = true;
            if (f.ShowDialog() == DialogResult.OK)
                yoklama.FileName = f.FileName;
                return yoklama;
        }
    }
}
