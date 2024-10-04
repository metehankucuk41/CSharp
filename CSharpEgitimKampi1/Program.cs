namespace CSharpEgitimKampi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma Komutları
            Console.WriteLine("Merhaba Dünya");
            Console.Write("Selam");

            Console.WriteLine("**** Yemek Kategorileri ****");
            Console.WriteLine();
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk Başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5)Tatlılar");
            Console.WriteLine();
            Console.WriteLine("***** Yemek Kategorileri *****");
            #endregion

            #region Değişkenler
            string name;
            name = "murat";
            Console.WriteLine(name);
            string customerName, customerSurname, customerEmail, customerPhone, customerCity, customerDistrict;

            customerName = "Ali";
            customerSurname = "Çınar";
            customerEmail = "deneme@gmail.com";
            customerPhone = "+90 500 400 30 20";
            customerCity = "İstanbul";
            customerDistrict = "Kadıköy";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Müşteri + " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email adresi: " + customerEmail);
            Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            Console.WriteLine("------------------------------");

            Console.WriteLine();

            customerName = "Ayşe";
            customerSurname = "Kaya";
            customerEmail = "test@gmail.com";
            customerPhone = "+90 400 300 80 70";
            customerCity = "Sakarya";
            customerDistrict = "Sapanca";

            Console.WriteLine("***** Rezervasyon Kartı *****");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Müşteri + " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim: " + customerPhone);
            Console.WriteLine("Email adresi: " + customerEmail);
            Console.WriteLine("Adres: " + customerDistrict + "/" + customerCity);
            Console.WriteLine("------------------------------");

            #endregion

            #region int Değişkenler

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı: " + hamburgerPrice + " TL");
            Console.WriteLine("-----Kola Fiyatı: " + cokePrice + " TL");
            Console.WriteLine("-----Su Fiyatı: " + waterPrice + " TL");
            Console.WriteLine("-----Kızartma Fiyatı: " + friesPrice + " TL");
            Console.WriteLine("-----Limonata Fiyatı: " + lemonadePrice + " TL");
            Console.WriteLine("-----Pizza Fiyatı: " + pizzaPrice + " TL");
            Console.WriteLine();
            Console.WriteLine("**** Restoran Menü Fiyatı ****");

            Console.WriteLine();

            int hamburgerCount = 3;
            int cokeCount = 3;
            int waterCount = 3;
            int friesCount = 1;
            int pizzaCount = 0;
            int lemonadeCount = 0;
            
            int totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            int totalCokePrice = cokeCount * cokePrice;
            int totalWaterPrice = waterCount * waterPrice;
            int totalFriesPrice = friesCount * friesPrice;
            int totalLemonadePrice = lemonadeCount * lemonadePrice;
            int totalPizzaPrice = pizzaCount * pizzaPrice;

            int totalPrice = totalCokePrice + totalWaterPrice + totalFriesPrice + totalLemonadePrice + totalPizzaPrice + totalHamburgerPrice;


            Console.WriteLine("----------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice);
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice);
            Console.WriteLine("Su Tutarı: " + totalWaterPrice);
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice);
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice);
            Console.WriteLine("Kola Tutarı: " + totalCokePrice);

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice);


            #endregion

            Console.Read();
        }
    }
}
