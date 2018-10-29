# Sahte Veri
Sahte Veri C# Dili İle Hazırlanmış Bir Kütüphanedir.</br>
Sahte Veri İle Rastgele İsim,Soyisim,Adres Gibi Birçok Bilgiyi Kolayca Üretebilirsiniz.</br>

## Kurulum

Nuget Paket Yöneticisi Kullanarak SahteVeri.dll Dosyasını İndirebilirsiniz.</br>
Package Console Manager Aracılığıyla Yükleme Yapmak İsterseniz Komut</br>

```
Install-Package SahteVeri -Version 1.0.0
```

## Kullanım
Öncelikle Sahte Veri Kütüphanesini Ekleyelim</br>
```
using SahteVeri;
```
Ardından Sahte Veri Getir Sınıfından Oluşturalım</br>
```
SahteVeriGetir veri = new SahteVeriGetir();
```
Örnek Bir Kullanım Yaparak Rastgele İsim Ve Soyisim Oluşturalım</br>
```
SahteVeriGetir veri = new SahteVeriGetir();
string isim = veri.getirTamIsim();
Console.WriteLine("Oluşturulan İsim: " + isim);
```

## Fonksiyonlar Listesi
İsimler</br>
```
getirIsim()
getirSoyisim()
getirTamIsim()
getirKisi()
```

İletişim</br>
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

Kullanıcı</br>
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

Sayılar</br>
```
getirSayiRastgele()
getirSayiRastgele(int bitiş)
getirSayiRastgele(int başlangıç,int bitiş)
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

İnternet</br>
```
getirInternetIpAdres()
```

## Geliştiriciler
* **Ahmet Can Aydemir** - [Github Profili](https://github.com/ahmetcanaydemir)</br>
* **Berke Kurnaz** - [Github Profili](https://github.com/berkekurnaz)</br>  	


