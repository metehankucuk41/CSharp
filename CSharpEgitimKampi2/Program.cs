namespace CSharpEgitimKampi2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Double Değişkenler
            double number;
            number = 4.85;
            Console.WriteLine(number);

            Console.WriteLine("***** FİYAT LİSTESİ *****");
            Console.WriteLine();

            double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            applePrice = 14.85;
            orangePrice = 20.95;
            strawberryPrice = 45;
            potatoPrice = 9.74;
            tomatoPrice = 6.88;

            Console.WriteLine("----Elma Birim Fiyatı: " + applePrice + " TL");
            Console.WriteLine("----Portakal Birim Fiyatı: " + orangePrice + " TL");
            Console.WriteLine("----Çilek Birim Fiyatı: " + strawberryPrice + " TL");
            Console.WriteLine("----Patates Birim Fiyatı: " + potatoPrice + " TL");
            Console.WriteLine("----Domates Birim Fiyatı: " + tomatoPrice + " TL");

            double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            appleGram = 1.245;
            orangeGram = 2.650;
            strawberryGram = 0.750;
            potatoGram = 4.859;
            tomatoGram = 3.745;

            double appleTotalPrice = appleGram * applePrice;
            double orangeTotalPrice = orangeGram * orangePrice;
            double strawberryTotalPrice = strawberryGram * strawberryPrice;
            double potatoTotalPrice = potatoGram * potatoGram;
            double tomatoTotalPrice = tomatoGram * tomatoGram;

            Console.WriteLine("Alınan ürün: Elma - " + "Birim Fiyatı: " + applePrice + "Gramaj: " + appleGram + " -Toplam Tutar: " + appleTotalPrice);
            Console.WriteLine("Alınan ürün: Portakal - " + "Birim Fiyatı: " + orangePrice + "Gramaj: " + orangeGram + " -Toplam Tutar: " + orangeTotalPrice);
            Console.WriteLine("Alınan ürün: Çilek - " + "Birim Fiyatı: " + strawberryPrice + "Gramaj: " + strawberryGram + " -Toplam Tutar: " + strawberryTotalPrice);
            Console.WriteLine("Alınan ürün: Patates - " + "Birim Fiyatı: " + potatoPrice + "Gramaj: " + potatoGram + " -Toplam Tutar: " + potatoTotalPrice);
            Console.WriteLine("Alınan ürün: Domates - " + "Birim Fiyatı: " + tomatoPrice + "Gramaj: " + tomatoGram + " -Toplam Tutar: " + tomatoTotalPrice);

            double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine();

            Console.WriteLine("Alışveriş Toplam Tutarı: " + shoppingTotalPrice + "TL");


            #endregion

            #region Char Değişkenler
            char symbol;
            symbol = 'a';
            #endregion

            #region Klavyeden Veri Girişleri
            Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            Console.WriteLine();

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber = "";
            Console.Write("Yolcu adı: ");
            passengerName = Console.ReadLine();
            Console.Write("Yolcu Soyadı: ");
            passengerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi: ");
            passengerDistrict = Console.ReadLine();
            Console.Write("Şehir Bilgisi: ");
            passengerCity = Console.ReadLine();
            Console.Write("Yolcu Yaş: ");
            passengerAge = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("TC Kimlik No: " + passengerIdentityNumber + "Yolcu Adı ve Soyadı: " + passengerName + " "
                + passengerSurname + " " + passengerDistrict + " " + passengerCity + " " + passengerAge);
            passengerIdentityNumber = Console.ReadLine();
            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler
            int shoesPrice, computerPrice, chairPrice, tvPrice;

            shoesPrice = 1000;
            computerPrice = 20000;
            chairPrice = 5000;
            tvPrice = 12000;

            int shoesCount, computerCount, chairCount, tvCount;
            Console.Write("Lütfen aldığınız ayakkabı sayısı giriniz: ");
            shoesCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız bilgisayar sayısı giriniz: ");
            computerCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız sandalye sayısı giriniz: ");
            chairCount = int.Parse(Console.ReadLine());
            Console.Write("Lütfen aldığınız televizyon sayısı giriniz: ");
            tvCount = int.Parse(Console.ReadLine());

            int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            Console.WriteLine();
            Console.WriteLine("Toplam ödemeniz gereken tutar: " + totalPrice);

            #endregion

            #region Ondalıklı Sayı İşlemleri
            double exam1, exam2, exam3, result;
            Console.WriteLine("Lütfen 1.sınav notunu giriniz: ");
            exam1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 2.sınav notunu giriniz: ");
            exam2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Lütfen 3.sınav notunu giriniz: ");
            exam3 = double.Parse(Console.ReadLine());
            result = (exam1 + exam2 + exam3) / 3;
            Console.WriteLine("Sınav ortalamanız: " + result);
            #endregion

            #region Klavyeden Karakter Girişleri
            char gender;
            Console.Write("Lütfen cinsiyet giriniz: ");
            gender = char.Parse(Console.ReadLine());
            Console.WriteLine("Seçtiğiniz cinsiyet: " + gender);
            #endregion


            Console.Read();
        }
    }
}
