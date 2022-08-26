using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    public class Calisan
    {
        private int id { get; set; }
        private string isim { get; set; }
        private string soyisim { get; set; }

        public Calisan(int id, string isim, string soyisim)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
        }

        public int getId()
        {
            return this.id;
        }
        public void setId()
        {
            this.id = id;
        }

        public string getIsim()
        {
            return this.isim;
        }
        public void setIsim()
        {
            this.isim = isim;
        }

        public string getSoyisim()
        {
            return this.soyisim;
        }
        public void setSoyisim()
        {
            this.soyisim = soyisim;
        }

        public void BilgileriGoster()
        {
            Console.WriteLine("Çalışan ID: " + this.id);
            Console.WriteLine("Çalışan İsim: " + this.isim);
            Console.WriteLine("Çalışan Soyisim: " + this.soyisim);
        }
    }
}
