using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.Utils
{
   public class ExcelImport
    {
        public static DataGridView ExcelYukle(string dosyaYolu) {
            OleDbConnection theConnection;
            var extension= Path.GetExtension(dosyaYolu);
            switch (extension)
            {
                case ".xls":
                    theConnection = new OleDbConnection(@"provider=Microsoft.Jet.OLEDB.4.0;data source='" + dosyaYolu + "';Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                    break;
                case ".xlsx":
                    theConnection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dosyaYolu + ";Extended Properties='Excel 12.0 XML;HDR=YES;';");
                    break;
                default:
                    throw new Exception("Desteklenmeyen Format");
            }
            //versiyona göre değişiklik oluyor..            
           // OleDbConnection 
            theConnection.Open();
            OleDbDataAdapter thDataAdapter = new OleDbDataAdapter("Select * from [Sayfa1$]", theConnection);
            DataSet thSd = new DataSet();
            DataTable dt = new DataTable();
            thDataAdapter.Fill(dt);
            DataGridView dg= new DataGridView() ;
            dg.DataSource=dt.DefaultView;
            theConnection.Close();
            return dg;
        }

    }
}
