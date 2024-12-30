using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace akaryakıt
{
    class Program
    {
        static void Main(string[] args)
        {
            double motorin = 45.41, benzin = 44.42, lpg = 35.71;
            double motorintank = 1000, benzintank = 1000, lpgtank = 1000;
            double satismiktari = 0;
            char anamenusecım = '0', altmenusecim = '0', akaryakitfiyatguncelle = '0', akaryakitsatistipi = '0';
        MENU:
            Console.WriteLine("Akaryakıt Otomasyonu");
            Console.WriteLine(".....................");
            Console.WriteLine("1-Fiyat Listesi");
            Console.WriteLine("2- Fiyatı Güncelle");
            Console.WriteLine("3- Satış Yap");
            Console.WriteLine("4-Kalan Akaryakıt Miktarı");
            Console.WriteLine("5-Toplam Satış Miktarı");
            Console.WriteLine("6-Çıkış");

            Console.Write("Seçiminizi Yapınız [1,2,3,4,5,6]:");
            anamenusecım = Convert.ToChar(Console.ReadLine());
            if (anamenusecım == '1')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:1");
                Console.WriteLine("--- Fiyat Listesi---");
                Console.WriteLine("Motorin(M) :{0} TL/Litre", motorin);
                Console.WriteLine("Benzin(B) :{0} TL/Litre", benzin);
                Console.WriteLine("LPG(L) :{0} TL/Litre", lpg);
            ALTMENU:
                Console.Write("Seçiminizi Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Yanlış Seçim Yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecım == '2')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:2");
                Console.WriteLine("--- Fiyat Güncelleme---");
            AKARYAKITTURU:
                Console.WriteLine("Akaryakıt Tipini Seçiniz [M,B,L]:");
                akaryakitfiyatguncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitfiyatguncelle == 'M' || akaryakitfiyatguncelle == 'd')
                {
                    Console.WriteLine("Motorin(M):{0} TL/Litre", motorin);
                    Console.Write("Motorin Yakıt İçin Yeni Fiyat Giriniz:");
                    motorin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Motorin(M):{0} TL/Litre", motorin);
                }
                else if (akaryakitfiyatguncelle == 'B' || akaryakitfiyatguncelle == 'b')
                {
                    Console.WriteLine("Benzin(B):{0} TL/Litre", benzin);
                    Console.Write("Benzin Yakıt İçin Yeni Fiyat Giriniz:");
                    motorin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("Benzin(B):{0} TL/Litre", benzin);
                }
                else if (akaryakitfiyatguncelle == 'D' || akaryakitfiyatguncelle == 'd')
                {
                    Console.WriteLine("LPG(L):{0} TL/Litre", lpg);
                    Console.Write("LPG Yakıt İçin Yeni Fiyat Giriniz:");
                    motorin = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Değişiklik Yapılmıştır.");
                    Console.WriteLine("LPG(L):{0} TL/Litre", lpg);
                }
                else
                {
                    Console.WriteLine();
                    goto AKARYAKITTURU;
                }
            ALTMENU:
                Console.Write("Seçimini Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 seçenekleri dışında yanlış seçim yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecım == '3')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:3");
                Console.WriteLine("---Akaryakıt Satış İşlemleri---");
            AKARYAKITSATISI:
                Console.WriteLine("Akaryakıt Tipini Seçiniz [M,B,L]:");
                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitsatistipi == 'M' || akaryakitsatistipi == 'd')
                {
                    if (motorintank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç motorin kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Kaç Litre motorin alacaksınız:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (motorintank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} motorin vardır!İşlem yapılamadı!", motorintank);
                            goto MENU;
                        }
                        else if (satismiktari <= motorintank)
                        {
                            motorintank = motorintank - satismiktari;
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} litre motorin kaldı.", motorintank);
                        }
                    }
                }
                if (akaryakitsatistipi == 'B' || akaryakitsatistipi == 'b')
                {
                    if (benzintank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç benzin kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Kaç Litre benzin alacaksınız:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre benzin vardır!İşlem yapılamadı!", benzintank);
                            goto MENU;
                        }
                        else if (satismiktari <= benzintank)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} litre benzin kaldı.", benzintank);
                        }
                    }
                }
                if (akaryakitsatistipi == 'L' || akaryakitsatistipi == 'l')
                {
                    if (lpgtank == 0)
                    {
                        Console.WriteLine("Yakıt tankında hiç LPG kalmamıştır.");
                        goto MENU;
                    }
                    else
                    {
                        Console.Write("Kaç Litre LPG alacaksınız:");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (lpgtank < satismiktari)
                        {
                            Console.WriteLine("Yakıt tankında {0} litre LPG vardır!İşlem yapılamadı!", lpgtank);
                            goto MENU;
                        }
                        else if (satismiktari <= lpgtank)
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.WriteLine("Yakıt Dolumu Tamamlanmıştır.");
                            Console.WriteLine("Yakıt tankında {0} litre LPG kaldı.", lpgtank);
                        }
                    }
                }
                else
                {
                    Console.WriteLine();
                    goto AKARYAKITSATISI;
                }
            ALTMENU:
                Console.Write("Seçimini Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 seçenekleri dışında yanlış seçim yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecım == '4')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:4");
                Console.WriteLine("---Depo Durumu---");
                Console.WriteLine("Motorin Tankı %{0} doludur.", (motorintank / 10));
                Console.WriteLine("Benzin Tankı %{0} doludur.", (benzintank / 10));
                Console.WriteLine("LPG Tankı %{0} doludur.", (lpgtank / 10));
            ALTMENU:
                Console.Write("Seçimini Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 seçenekleri dışında yanlış seçim yaptınız!");
                    goto ALTMENU;
                }
            }
            else if (anamenusecım == '5')
            {
                Console.Clear();
                Console.WriteLine(">> Seçiminiz:5");
                Console.WriteLine("---Toplam Satış Durumu---");
                Console.WriteLine("Satılan Toplam Motorin :{0}", 1000 - motorintank);
                Console.WriteLine("Motorin Tutarı:{0}", (1000 - motorintank) * motorin);
                Console.WriteLine("Satılan Toplam Benzin :{0}", 1000 - benzintank);
                Console.WriteLine("Benzin Tutarı:{0}", (1000 - benzintank) * benzin);
                Console.WriteLine("Satılan Toplam LPG:{0}", 1000 - lpgtank);
                Console.WriteLine("LPG Tutarı:{0}", (1000 - lpgtank) * lpg);
                Console.WriteLine("________________________________");
                Console.WriteLine("Toplam Tutar:{0}", ((1000 - motorintank) * motorin) + ((1000 - benzintank) * benzin) + ((1000 - lpgtank) * lpg));
            ALTMENU:
                Console.Write("Seçimini Yapınız [1:Ana Menüye Dön 2:Programı Kapat]:");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto MENU;
                }
                else if (altmenusecim == '2')
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("1,2 seçenekleri dışında yanlış seçim yaptınız!");
                    goto ALTMENU;
                }
            }
            Console.ReadKey();





        }
    }
}