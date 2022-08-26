using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class Yazilimci:Calisan
    {
        private string diller;

        public Yazilimci(int id, string isim, string soyisim, string diller) : base(id, isim, soyisim) // Miras alınan sınıfın yapıcı metodu.
        {
            this.diller = diller;
        }

        public void FormatAt(string isletim_sistemi)
        {
            Console.WriteLine(getIsim() + " " + "şu anda " +isletim_sistemi + " İşletim sistemine format atıyor... ");
        }
    }
}
