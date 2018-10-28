using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace SahteVeri
{
    public class SahteVeriGetir
    {
        static Random rnd = new Random();

        static private string[] isimler = Properties.Resources.isimler.Replace("\r", "").Split('\n');
        static private string[] soyisimler = Properties.Resources.soyisimler.Replace("\r", "").Split('\n');
        static private string[] sehirler = Properties.Resources.sehirler.Replace("\r", "").Split('\n');
        static private string[] adresler = Properties.Resources.adresler.Replace("\r", "").Split('\n');
        static private string[] meslekler = Properties.Resources.meslekler.Replace("\r", "").Split('\n');
        static private string[] sirketler = Properties.Resources.sirketler.Replace("\r", "").Split('\n');

        string isim;
        string soyisim;
        string evtelefon;
        string ceptelefon;
        string sehir;
        string adres; 
        string mail; 
        string website; 
        string kullaniciadi;
        string sifre;
        string meslek;
        string sirket;
        int maas;
        int yas;
        int boy;
        int kilo;
        string kangrubu;
        string medeniDurum;
        string gun;
        string ay;
        string yil; 
        string renk;
        string kredikarttipi;
        string kredikartnumara;
        string kredikarttarih;
        string kredikartcvc2;
        float kredikartborc;
        string ipadres;

        public SahteVeriGetir()
        {
            this.isim = isimler[rnd.Next(isimler.Length)];
            this.soyisim = soyisimler[rnd.Next(soyisimler.Length)];
            this.sehir = sehirler[rnd.Next(sehirler.Length)];
            this.adres = adresler[rnd.Next(adresler.Length)];
            this.meslek = meslekler[rnd.Next(meslekler.Length)];
            this.sirket = sirketler[rnd.Next(sirketler.Length)];
        }

        /// <summary>
        /// Rastgele Isim Getirir Ornek : Berke
        /// </summary>
        /// <returns></returns>
        public string getirIsim()
        {
            return this.isim;
        }

        /// <summary>
        /// Rastgele Soyisim Getirir Ornek : Kurnaz
        /// </summary>
        /// <returns></returns>
        public string getirSoyisim()
        {
            return this.soyisim;
        }

        /// <summary>
        /// Rastgele İsim Ve Soyisim Getirir Ornek : Berke Kurnaz
        /// </summary>
        /// <returns></returns>
        public string getirTamIsim()
        {
            return this.isim + " " + this.soyisim;
        }

        /// <summary>
        /// Rastgele İsim Ve Soyisim Getirir Ornek : Berke Kurnaz
        /// </summary>
        /// <returns></returns>
        public string getirKisi()
        {
            return this.isim + " " + this.soyisim;
        }

        /// <summary>
        /// Rastgele Cep Telefon Numarasi Getirir Ornek : 0 (542) 111 11 11
        /// </summary>
        /// <returns></returns>
        public string getirCepTelefon()
        {
            string a, b, c, d;
            int i, z, x, y;
            a = "0 (500) ";
            i = rnd.Next(0, 5);
            if (i == 0) { a = "0 (540) "; }
            else if (i == 1) { a = "0 (541) "; }
            else if (i == 2) { a = "0 (542) "; }
            else if (i == 3) { a = "0 (543) "; }
            else if (i == 4) { a = "0 (544) "; }
            z = rnd.Next(0, 1000);
            b = z.ToString();
            x = rnd.Next(0, 100);
            c = x.ToString();
            y = rnd.Next(0, 100);
            d = y.ToString();
            this.ceptelefon = a + b + " " + c + " " + d;
            return this.ceptelefon;
        }

        /// <summary>
        /// Rastgele Ev Telefon Numarasi Getirir Ornek : 0 (266) 111 11 11
        /// </summary>
        /// <returns></returns>
        public string getirEvTelefon()
        {
            string a, b, c, d;
            int i, z, x, y;
            i = rnd.Next(100, 1000);
            a = i.ToString();
            z = rnd.Next(0, 1000);
            b = z.ToString();
            x = rnd.Next(0, 100);
            c = x.ToString();
            y = rnd.Next(0, 100);
            d = y.ToString();
            this.evtelefon = "0 (" + a + ") " + b + " " + c + " " + d;
            return this.evtelefon;
        }

        /// <summary>
        /// Rastgele Sehir Ismi Getirir Ornek : Bursa
        /// </summary>
        /// <returns></returns>
        public string getirSehir()
        {
            return this.sehir;
        }

        /// <summary>
        /// Rastgele Adres Getirir Ornek : Ada Sokak Numara 54 Ankara
        /// </summary>
        /// <returns></returns>
        public string getirAdres()
        {
            return this.adres + " " + this.sehir;
        }

        /// <summary>
        /// Rastgele Mail Adres Getirir Ornek : berke.kurnaz@hotmail.com
        /// </summary>
        /// <returns></returns>
        public string getirMail()
        {
            int i = rnd.Next(0,10);
            this.isim = this.isim.Replace(" ", "");
            this.soyisim = this.soyisim.Replace(" ", "");
            if (i == 0) { this.mail = this.isim + "_" + this.soyisim + "@hotmail.com"; }
            else if (i == 1) { this.mail = this.isim + "_" + this.soyisim + "@hotmail.com"; }
            else if (i == 2) { this.mail = this.isim + "-" + this.soyisim + "@hotmail.com"; }
            else if (i == 3) { this.mail = this.isim + "-" + this.soyisim + "@hotmail.com"; }
            else if (i == 4) { this.mail = this.isim + "_" + this.soyisim + "@gmail.com"; }
            else if (i == 5) { this.mail = this.isim + "_" + this.soyisim + "@gmail.com"; }
            else if (i == 6) { this.mail = this.isim + "-" + this.soyisim + "@gmail.com"; }
            else if (i == 7) { this.mail = this.isim + "-" + this.soyisim + "@gmail.com"; }
            else if (i == 8) { this.mail = this.isim + "_" + this.soyisim + "@yandex.com"; }
            else if (i == 9) { this.mail = this.isim + "_" + this.soyisim + "@yandex.com"; }
            return this.mail.ToLower();
        }

        /// <summary>
        /// Rastgele Mail Adres Getirir Ornek : www.berkekurnaz.com
        /// </summary>
        /// <returns></returns>
        public string getirWebsite()
        {
            string uzanti = "null";
            string govde = "";
            int i = rnd.Next(0,6);
            if (i == 0) { uzanti = ".com"; }
            else if (i == 1) { uzanti = ".net"; }
            else if (i == 2) { uzanti = ".com.tr"; }
            else if (i == 3) { uzanti = ".org"; }
            else if (i == 4) { uzanti = ".istanbul"; }
            else if (i == 5) { uzanti = ".tr"; }
            int j = rnd.Next(2);
            if (j == 0) { govde = this.isim + this.soyisim; }
            else if (j == 1) { govde = this.soyisim + this.isim; }
            this.website = "www." + govde + uzanti;
            return this.website.ToLower();
        }

        /// <summary>
        /// Bugunun Tarihini Getirir Ornek : 28.10.2018
        /// </summary>
        /// <returns></returns>
        public string getirTarihBugun()
        {
            return DateTime.Now.ToShortDateString();
        }

        /// <summary>
        /// Rastgele Tarih Getirir Ornek : 30.4.1999
        /// </summary>
        /// <returns></returns>
        public string getirTarihRastgele()
        {
            string gun, ay, yil;
            int i, j, k;
            i = rnd.Next(31);
            j = rnd.Next(13);
            k = rnd.Next(1923, 2024);
            gun = i.ToString();
            ay = j.ToString();
            yil = k.ToString();
            return gun + "." + ay + "." + yil;
        }

        /// <summary>
        /// Rastgele Gun Getirir Ornek : Pazartesi
        /// </summary>
        /// <returns></returns>
        public string getirTarihGun()
        {
            this.gun = "null";
            int i = rnd.Next(0,7);
            if (i == 0) { gun = "Pazartesi"; }
            else if (i == 1) { gun = "Salı"; }
            else if (i == 2) { gun = "Çarşamba"; }
            else if (i == 3) { gun = "Perşembe"; }
            else if (i == 4) { gun = "Cuma"; }
            else if (i == 5) { gun = "Cumartesi"; }
            else if (i == 6) { gun = "Pazar"; };
            return this.gun;
        }

        /// <summary>
        /// Rastgele Yil Getirir Ornek : 1999
        /// </summary>
        /// <returns></returns>
        public string getirTarihYil()
        {
            int yil = rnd.Next(1923, 2024);
            return yil.ToString();
        }

        /// <summary>
        /// Rastgele Ay Getirir Ornek : Ocak
        /// </summary>
        /// <returns></returns>
        public string getirTarihAy()
        {
            this.ay = "null";
            int i = rnd.Next(0,12);
            if (i == 0) { ay = "Ocak"; }
            else if (i == 1) { ay = "Şubat"; }
            else if (i == 2) { ay = "Mart"; }
            else if (i == 3) { ay = "Nisan"; }
            else if (i == 4) { ay = "Mayıs"; }
            else if (i == 5) { ay = "Haziran"; }
            else if (i == 6) { ay = "Temmuz"; }
            else if (i == 7) { ay = "Ağustos"; }
            else if (i == 8) { ay = "Eylül"; }
            else if (i == 9) { ay = "Ekim"; }
            else if (i == 10) { ay = "Kasım"; }
            else if (i == 11) { ay = "Aralık"; }
            return this.ay;
        }

        /// <summary>
        /// Rastgele Kullanici Adi Getirir Ornek : berke10
        /// </summary>
        /// <returns></returns>
        public string getirKullaniciAdi()
        {
            this.kullaniciadi = "nulll";
            int sayi = rnd.Next(100);
            int i = rnd.Next(0,11);
            if (i == 0) { kullaniciadi = this.isim + sayi.ToString(); }
            else if (i == 1) { kullaniciadi = this.soyisim + sayi.ToString(); }
            else if (i == 2) { kullaniciadi = this.isim + this.soyisim + sayi.ToString(); }
            else if (i == 3) { kullaniciadi = this.isim + "_" + this.soyisim + sayi.ToString(); }
            else if (i == 4) { kullaniciadi = this.isim + "." + this.soyisim + sayi.ToString(); }
            else if (i == 5) { kullaniciadi = this.isim + "-" + this.soyisim + sayi.ToString(); }
            else if (i == 6) { kullaniciadi = this.isim + this.soyisim + sayi.ToString(); }
            else if (i == 7) { kullaniciadi = this.soyisim + "_" + this.isim + sayi.ToString(); }
            else if (i == 8) { kullaniciadi = this.soyisim + "." + this.isim + sayi.ToString(); }
            else if (i == 9) { kullaniciadi = this.soyisim + "-" + this.isim + sayi.ToString(); }
            else if (i == 10) { kullaniciadi = sayi.ToString() + this.soyisim; }
            else if (i == 11) { kullaniciadi = sayi.ToString() + this.isim; }
            kullaniciadi = kullaniciadi.Replace(" ", "");
            return this.kullaniciadi;
        }

        /// <summary>
        /// Rastgele Sifre Getirir Ornek : e4545dw
        /// </summary>
        /// <returns></returns>
        public string getirSifre()
        {
            char[] cr = "0123456789abcdefghijklmnopqrstuvwxyz".ToCharArray();
            sifre = string.Empty;
            int boyut = rnd.Next(4, 10);
            for (int i = 0; i < boyut; i++)
            {
                sifre += cr[rnd.Next(0, cr.Length - 1)].ToString();
            }
            return sifre;
        }

        /// <summary>
        /// Rastgele Meslek Getirir Ornek : Avukat
        /// </summary>
        /// <returns></returns>
        public string getirMeslek()
        {
            return this.meslek;
        }

        /// <summary>
        /// Rastgele Sirket Getirir Ornek : Deneme
        /// </summary>
        /// <returns></returns>
        public string getirSirket()
        {
            return this.sirket;
        }

        /// <summary>
        /// Rastgele Tam Sayi Tipinde Maas Getirir Ornek : 3500
        /// </summary>
        /// <returns></returns>
        public int getirMaas()
        {
            int i = rnd.Next(0, 6);
            if (i == 0 || i == 1 || i==2) { maas = rnd.Next(940, 3000); }
            else if (i == 3 || i==4) { maas = rnd.Next(3000, 6000); }
            else if (i == 5) { maas = rnd.Next(6000, 12000); }
            return maas;
        }

        /// <summary>
        /// Rastgele Tam Sayi Tipinde Yas Getirir Ornek : 22
        /// </summary>
        /// <returns></returns>
        public int getirYas()
        {
            this.yas = rnd.Next(20, 65);
            return this.yas;
        }

        /// <summary>
        /// Rastgele Tam Sayi Tipinde Boy Getirir Ornek : 191
        /// </summary>
        /// <returns></returns>
        public int getirBoy()
        {
            this.boy = rnd.Next(150, 196);
            return this.boy;
        }

        /// <summary>
        /// Rastgele Tam Sayi Tipinde Kilo Getirir Ornek : 85
        /// </summary>
        /// <returns></returns>
        public int getirKilo()
        {
            this.kilo = rnd.Next(55, 110);
            return this.kilo;
        }

        /// <summary>
        /// Rastgele Kan Grubu Getirir Ornek : A+
        /// </summary>
        /// <returns></returns>
        public string getirKanGrubu()
        {
            int i = rnd.Next(0, 8);
            if (i == 0) { kangrubu = "A+"; }
            else if (i == 1) { kangrubu = "B+"; }
            else if (i == 2) { kangrubu = "AB+"; }
            else if (i == 3) { kangrubu = "0+"; }
            else if (i == 4) { kangrubu = "A-"; }
            else if (i == 5) { kangrubu = "B-"; }
            else if (i == 6) { kangrubu = "AB-"; }
            else if (i == 7) { kangrubu = "0-"; }
            return kangrubu;
        }

        /// <summary>
        /// Rastgele Medeni Durum Getirir Ornek : Evli
        /// </summary>
        /// <returns></returns>
        public string getirMedeniDurum()
        {
            int i = rnd.Next(0, 3);
            if (i == 0) { medeniDurum = "Bekar"; }
            else if (i == 1) { medeniDurum = "Evli"; }
            else if (i == 2) { medeniDurum = "Evli"; }
            return medeniDurum;
        }

        /// <summary>
        /// Rastgele Sayi Getirir Ornek : 1251248
        /// </summary>
        /// <returns></returns>
        public int getirRastgeleSayi()
        {
            return rnd.Next(0, 100000);
        }

        /// <summary>
        /// Parametreli Rastgele Sayi Getirir Ornek : 125
        /// </summary>
        /// <returns></returns>
        public int getirRastgeleSayi(int bitis)
        {
            return rnd.Next(0, bitis+1);
        }

        /// <summary>
        /// Parametreli Rastgele Sayi Getirir Ornek : 246
        /// </summary>
        /// <returns></returns>
        public int getirRastgeleSayi(int baslangic,int bitis)
        {
            return rnd.Next(baslangic, bitis+1);
        }

        /// <summary>
        /// Rastgele Renk Getirir Ornek : Beyaz
        /// </summary>
        /// <returns></returns>
        public string getirRenk()
        {
            int i = rnd.Next(0, 11);
            if (i == 0) { renk = "Beyaz"; }
            else if (i == 1) { renk = "Siyah"; }
            else if (i == 2) { renk = "Sarı"; }
            else if (i == 3) { renk = "Mavi"; }
            else if (i == 4) { renk = "Kırmızı"; }
            else if (i == 5) { renk = "Yeşil"; }
            else if (i == 6) { renk = "Gri"; }
            else if (i == 7) { renk = "Lacivert"; }
            else if (i == 8) { renk = "Turuncu"; }
            else if (i == 9) { renk = "Siyah"; }
            else if (i == 10) { renk = "Mor"; }
            return renk;
        }

        /// <summary>
        /// Rastgele Kredi Karti Tipi Getirir Ornek : Mastercard
        /// </summary>
        /// <returns></returns>
        public string getirKrediKartTipi()
        {
            int i = rnd.Next(0, 2);
            if (i == 0) { kredikarttipi = "Mastercard"; }
            else if (i == 1) { kredikarttipi = "Visa"; }
            return kredikarttipi;
        }

        /// <summary>
        /// Rastgele Kredi Karti Numarasi Getirir Ornek : 2456142378586351
        /// </summary>
        /// <returns></returns>
        public string getirKrediKartNumara()
        {
            for (int i = 0; i < 16; i++)
            {
                int sayi = rnd.Next(0, 10);
                kredikartnumara += sayi.ToString();
            }
            return kredikartnumara;
        }

        /// <summary>
        /// Rastgele Kredi Karti Tarihi Getirir Ornek : 10/2022
        /// </summary>
        /// <returns></returns>
        public string getirKrediKartTarih()
        {
            int ay = rnd.Next(1, 13);
            int yil = rnd.Next(2020, 2026);
            kredikarttarih = ay.ToString() + "/" + yil.ToString();
            return kredikarttarih;
        }
        
        /// <summary>
        /// Rastgele Kredi Karti Cvc2 Getirir Ornek : 266
        /// </summary>
        /// <returns></returns>
        public string getirKrediKartCvc2()
        {
            int i = rnd.Next(100, 1000);
            kredikartcvc2 = i.ToString();
            return kredikartcvc2;
        }

        /// <summary>
        /// Rastgele Ip Adresi Getirir Ornek : 71.124.164.95
        /// </summary>
        /// <returns></returns>
        public string getirInternetIpAdres()
        {
            ipadres = $"{rnd.Next(1, 255)}.{rnd.Next(0, 255)}.{rnd.Next(0, 255)}.{rnd.Next(0, 255)}";
            return ipadres;
        }

        /* Rastgele Kredi Karti Borc Getirir Ornek Cikti ---> 2200 */
        /// <summary>
        /// Rastgele Kredi Karti Borc Getirir Ornek : 2200
        /// </summary>
        /// <returns></returns>
        public float getirKrediKartiBorc()
        {
            int i = rnd.Next(0, 2);
            if (i == 0) { kredikartborc = 0; }
            else if (i == 1) { kredikartborc = rnd.Next(100,5000); }
            return kredikartborc;
        }

    }
}
