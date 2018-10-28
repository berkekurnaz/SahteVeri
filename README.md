# Sahte Veri
Sahte Veri C# Dili Ýle Hazýrlanmýþ Bir Kütüphanedir.</br>
Sahte Veri Ýle Rastgele Ýsim,Soyisim,Adres Gibi Birçok Bilgiyi Kolayca Üretebilirsiniz.</br>

## Kurulum

Nuget Paket Yöneticisi Kullanarak SahteVeri.dll Dosyasýný Ýndirebilirsiniz.</br>
Package Console Manager Aracýlýðýyla Yükleme Yapmak Ýsterseniz Komut</br>

```
Install-Package SahteVeri -Version 1.0.0
```

## Kullaným
Öncelikle Sahte Veri Kütüphanesini Ekleyelim</br>
```
using SahteVeri;
```
Ardýndan Sahte Veri Getir Sýnýfýndan Oluþturalým</br>
```
SahteVeriGetir veri = new SahteVeriGetir();
```
Örnek Bir Kullaným Yaparak Rastgele Ýsim Ve Soyisim Oluþturalým</br>
```
SahteVeriGetir veri = new SahteVeriGetir();
string isim = veri.getirTamIsim();
Console.WriteLine("Oluþturulan Ýsim: " + isim);
```

## Fonksiyonlar Listesi
Ýsimler</br>
```
getirIsim()
getirSoyisim()
getirTamIsim()
getirKisi()
```

Ýletiþim</br>
```
getirCepTelefon()
getirEvTelefon()
getirAdres()
getirSehir()
getirMail()
getirWebSite()
```
Tarihler</br>
```
getirTarihBugun()
getirTarihRastgele()
getirTarihGun()
getirTarihAy()
getirTarihYil()
```

Kullanýcý</br>
```
getirKullaniciAdi()
getirSifre()
getirMeslek()
getirSirket()
getirMaas()
getirYas()
getirBoy()
getirKilo()
getirKanGrubu()
getirMedeniDurum()
```

Sayýlar</br>
```
getirSayiRastgele()
getirSayiRastgele(int bitiþ)
getirSayiRastgele(int baþlangýç,int bitiþ)
```

Renkler</br>
```
getirRenk()
```

Finans</br>
```
getirKrediKartTipi()
getirKrediKartNumara()
getirKrediKartTarih()
getirKrediKartCvc2()
getirKrediKartBorc()
```

Ýnternet</br>
```
getirInternetIpAdres()
```

## Geliþtiriciler
* **Ahmetcan Aydemir** - [Github Profili](https://github.com/ahmetcanaydemir)</br>
* **Berke Kurnaz** - [Github Profili](https://github.com/berkekurnaz)</br>  	


