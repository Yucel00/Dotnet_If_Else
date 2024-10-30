//1-Kullaniciya sunulan bir menu icinden secilecek olan 4 islem tipine gore hesaplama yapiniz

using System.Security.Cryptography.X509Certificates;

Console.WriteLine("Toplama Icin: +");
Console.WriteLine("Toplama Icin: -");
Console.WriteLine("Toplama Icin: *");
Console.WriteLine("Toplama Icin: /");
Console.Write("Seciniz>>");
var secim =Console.ReadLine();

Console.Write("Sayi1>>");
var sayi1 =Convert.ToInt32(Console.ReadLine());
Console.Write("Sayi2>>");
var sayi2 =Convert.ToInt32(Console.ReadLine());
bool ok=true;
double sonuc=0;

if (secim=="+"){
     sonuc=sayi1+sayi2;
    Console.WriteLine(sonuc);
}
else if (secim=="-"){
     sonuc=sayi1 - sayi2;
    Console.WriteLine(sonuc);
}
else if (secim=="*"){
     sonuc=sayi1 * sayi2;
    Console.WriteLine(sonuc);
}
else if (secim=="/") {
    if (sayi2==0){
        ok =false;
        Console.WriteLine("Bir Sayi 0 A bolunemez");
    }
    else{
         sonuc=sayi1/sayi2;

    Console.WriteLine(sonuc);
    }
}
else{
    ok =false;
    Console.WriteLine("Yanlis Secim");
}
if (ok){
    Console.WriteLine($"Islem Sonucu:{sayi1} {secim} {sayi2} = {sonuc}");
}
//2-Bir Ogrencinin 2 yazili 1 sozlu notunu alip hesaplanman ortalamaya gore not araligina karsilik gelen not bilgisini yazdiriniz
    //0-24 =>0
    //25-44 =>1
    //45-54 =>2
    //55-69 =>3
    //70-84 =>4
    //85-100 =>5
int [] yazililar={50,60,80};
int [] sozluler ={40,50,70};

int toplam=yazililar[0]+yazililar[1]+sozluler[0];
int ortalama=toplam/3;
if (ortalama>=0 && ortalama<=24){
    Console.WriteLine("0");
}
else if (ortalama>=25 && ortalama<=44){
    Console.WriteLine("1");
}
else if (ortalama>=45 && ortalama<=54){
    Console.WriteLine("2");
}
else if (ortalama>=55 && ortalama<=69){
    Console.WriteLine("3");
}
else if (ortalama>=70 && ortalama<=84){
    Console.WriteLine("4");
}
else{
    Console.WriteLine("5");
}


//3-Girilen 2 sayidan en buyugunu bulunuz

Console.Write("Sayi1>>");
var sayix=Convert.ToInt32(Console.ReadLine());
Console.Write("Sayi2>>");
var sayiy=Convert.ToInt32(Console.ReadLine());

if (sayix>sayiy){
    Console.WriteLine($"{sayix}>{sayiy}");
}
else if (sayix==sayiy){
    Console.WriteLine($"{sayiy}={sayix}");
}
else{
    Console.WriteLine($"{sayiy}>{sayix}");
}