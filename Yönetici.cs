using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class Yönetici:Calisan
    {
        private int sorumluKisiSayisi;
        public Yönetici(int id, string isim, string soyisim, int sorumluKisiSayisi) : base(id, isim, soyisim)
        {
            this.sorumluKisiSayisi = sorumluKisiSayisi;
        }

        public void ZamYap(int zamMiktari)
        {
            Console.WriteLine(getIsim()+ " Çalışanlara " + zamMiktari + " TL tutarında zam yapıyor...");
        }
    }
}
