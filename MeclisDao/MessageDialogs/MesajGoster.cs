using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeclisDao.MessageDialogs
{
   
   public static class MesajGoster
    {
        public static DialogResult Hata(string mesaj,string hataMetni) {
           DialogResult msg = MessageBox.Show(mesaj, "Program", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return msg;
        }
        public static DialogResult Bilgi(string mesaj)
        {
            DialogResult msg = MessageBox.Show(mesaj, "Program", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return msg;
        }
        public static bool Uyari(string mesaj)
        {
            DialogResult msg = MessageBox.Show(mesaj, "Program", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg==DialogResult.Yes)
            {
                return true;
            }
            return false;
        }
        public static DialogResult Basarili(string mesaj)
        {
            DialogResult msg = MessageBox.Show(mesaj, "Program", MessageBoxButtons.OK, MessageBoxIcon.Question);
            return msg;
        }
        
    }
}
