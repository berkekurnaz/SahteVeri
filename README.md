# Sahte Veri
Sahte Veri C# dili ile hazırlanmış bir kütüphanedir.</br>
Sahte Veri ile rastgele ve Türkçe isim, soyisim, adres gibi birçok veriyi kolayca üretebilirsiniz.</br>

## Kurulum

Nuget Paket Yöneticisi kullanarak SahteVeri.dll dosyasını indirebilirsiniz.</br>
Package Console Manager aracılığıyla yükleme yapmak isterseniz aşağıdaki komutu kullanın:</br>

```
Install-Package SahteVeri -Version 1.0.0
```

## Kullanım
Öncelikle Sahte Veri kütüphanesini ekleyelim</br>
```
using SahteVeri;
```
Ardından Sahte Veri getir sınıfından oluşturalım</br>
```
SahteVeriGetir veri = new SahteVeriGetir();
```
Örneğin getirTamIsim() fonksiyonunu kullanıp isim ve soyisim çağırabilirsiniz.</br>
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


