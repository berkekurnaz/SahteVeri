# Sahte Veri
Sahte Veri C# Dili �le Haz�rlanm�� Bir K�t�phanedir.</br>
Sahte Veri �le Rastgele �sim,Soyisim,Adres Gibi Bir�ok Bilgiyi Kolayca �retebilirsiniz.</br>

## Kurulum

Nuget Paket Y�neticisi Kullanarak SahteVeri.dll Dosyas�n� �ndirebilirsiniz.</br>
Package Console Manager Arac�l���yla Y�kleme Yapmak �sterseniz Komut</br>

```
Install-Package SahteVeri -Version 1.0.0
```

## Kullan�m
�ncelikle Sahte Veri K�t�phanesini Ekleyelim</br>
```
using SahteVeri;
```
Ard�ndan Sahte Veri Getir S�n�f�ndan Olu�tural�m</br>
```
SahteVeriGetir veri = new SahteVeriGetir();
```
�rnek Bir Kullan�m Yaparak Rastgele �sim Ve Soyisim Olu�tural�m</br>
```
SahteVeriGetir veri = new SahteVeriGetir();
string isim = veri.getirTamIsim();
Console.WriteLine("Olu�turulan �sim: " + isim);
```

## Fonksiyonlar Listesi
�simler</br>
```
getirIsim()
getirSoyisim()
getirTamIsim()
getirKisi()
```

�leti�im</br>
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

Kullan�c�</br>
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

Say�lar</br>
```
getirSayiRastgele()
getirSayiRastgele(int biti�)
getirSayiRastgele(int ba�lang��,int biti�)
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

�nternet</br>
```
getirInternetIpAdres()
```

## Geli�tiriciler
* **Ahmetcan Aydemir** - [Github Profili](https://github.com/ahmetcanaydemir)</br>
* **Berke Kurnaz** - [Github Profili](https://github.com/berkekurnaz)</br>  	


