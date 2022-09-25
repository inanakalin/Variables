internal class Program
{
    public Program()
    {
    }

    private static void Main(string[] args)
    {

        int sayi1 = 10; //değişkeni tanımlarken değer atayabiliriz

        int sayi2;
        sayi2 = 10;  //programın herhangi bir aşamasında da bu şekilde değer atayabiliriz

        int sayi3 = 10, sayi4 = 40;

        int n = 2;


        sayi1= 20;  //farklı aşamalarda da değeri değiştirebiliriz

        sayi1=sayi2;  // değerleri eşitleyebiliriz bu şekilde 1 2nin değerini alır

        string ad = "inan";
        string soyad = "akalin";

        string adsoyad = ad +  soyad;

        string sayi5 = "10" ;
        string sayi6= "20";

        string sonuc = sayi5 + sayi6; // 1020 sonucunu verir
for (int i = 1; i < 10; i++)
{
    
}
        int toplam = sayi3 + sayi4; // 50 sonucunu verir

        Console.WriteLine ( "Ad soyad: {0}", adsoyad);
        Console.WriteLine("ad: {0}  soyad: {1} {2}", ad ,soyad,sayi5   );
        System.Console.WriteLine(n );

        Console.ReadLine();


        
    }
}