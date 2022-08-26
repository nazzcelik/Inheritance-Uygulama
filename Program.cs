using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("ÇALIŞAN UYGULAMASINA HOŞ GELDİNİZ :)");
                Console.WriteLine("1- Yazılımcı İşlemleri:");
                Console.WriteLine("2- Yönetici İşlemleri:");
                Console.WriteLine("q- Çıkış Yap:");
                string yapilan_islem = Console.ReadLine();

                if (yapilan_islem == "q")
                {
                    Console.WriteLine("ÇIKIŞ YAPILIYOR...");
                    Console.ReadLine();
                   
                }
                else if (yapilan_islem == "1")
                {
                    Yazilimci Yazilimci1 = new Yazilimci(123456789, "Naz", "Çelik", "C#, Python, Java");
                    
                    while (true)
                    {
                        Console.WriteLine("Yazılımcı için işlem seçiniz:");
                        Console.WriteLine("1- Format At");
                        Console.WriteLine("2- Yazılımcının Bilgilerini Göster");
                        Console.WriteLine("Çıkış Yapmak İçin q'ya Basınız");
                        string secim = Console.ReadLine();

                        if (secim == "q")
                        {
                            Console.WriteLine("ÇIKIŞ YAPILIYOR...");
                            Console.ReadLine();
                            break;
                            
                        }
                        else if (secim == "1")
                        {
                            Console.Write("Lütfen Bir İşletim Sistemi Giriniz : ");
                            string isletim_sistemi = Console.ReadLine();
                            Yazilimci1.FormatAt(isletim_sistemi);
                            Console.ReadLine();
                            break;

                        }
                        else if (secim == "2")
                        {
                            Console.WriteLine("YAZILIMCININ BİLGİLERİ : ");
                            Yazilimci1.BilgileriGoster();
                            Console.ReadLine();
                            break;

                        }
                        else
                        {
                            Console.WriteLine("LÜTFEN YAZILIMCI UYGULAMASI İÇİN GEÇERLİ BİR İŞLEM SEÇİNİZ !");
                            Console.ReadLine();
                            break;

                        }
                    }
                    
                    

                }
                else if (yapilan_islem == "2")
                {
                    Yönetici yönetici1 = new Yönetici(1234, "Nazz", "ÇELİK", 4);


                    while (true)
                    {
                        Console.WriteLine("Yönetici İçin İşlem Seçiniz:");
                        Console.WriteLine("1- Zam Yap");
                        Console.WriteLine("2- Yönetici Bilgilerini Göster");
                        Console.WriteLine("Çıkış Yapmak İçin q'ya Basınız");
                        string secim2 = Console.ReadLine();

                        if (secim2 == "q")
                        {
                            Console.WriteLine("ÇIKIŞ YAPILIYOR...");
                            Console.ReadLine();
                            
                        }
                        else if (secim2 == "1")
                        {
                            Console.Write("Zam Miktarını Giriniz : ");
                            int zamMiktari = Convert.ToInt32(Console.ReadLine());
                            yönetici1.ZamYap(zamMiktari);
                            Console.ReadLine();
                            
                        }
                        else if (secim2 == "2")
                        {
                            yönetici1.BilgileriGoster();
                            Console.ReadLine();
                            
                        }
                        else
                        {
                            Console.WriteLine("LÜTFEN YÖNETİCİ UYGULAMASI İÇİN GEÇERLİ BİR İŞLEM SEÇİNİZ");
                            Console.ReadLine();
                            
                        }
                        break;
                    }
                    
                }
                else
                {
                    Console.WriteLine("LÜTFEN ÇALIŞAN UYGULAMASI İÇİN GEÇERLİ BİR İŞLEM YAPINIZ !");
                    Console.ReadLine();
                    
                }
            }
        }
    }
}
