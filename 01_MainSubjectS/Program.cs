using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjectS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Yazdırma komutları
            //Console.WriteLine("HELOO WORLD");

            //Console.WriteLine("*****Yemek Kategorileri************");
            //Console.WriteLine("");
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk başlangıçlar");
            //Console.WriteLine("4-Salatalar");
            //Console.WriteLine("5-tatlılar");
            //Console.WriteLine("6-İçecekler");
            //Console.WriteLine("---------------------------------------");

            #endregion

            #region StringDeğişkneller
            //string name;
            //name = "dfks";
            //Console.WriteLine(name);
            //string customerName, district, city;

            //customerName = "HUam";
            //Console.WriteLine("********Rezervasyon***********");
            //Console.WriteLine("Müşteri:"+customerName);
            #endregion

            #region IntDeğişkenler

            int number = 24;

            int hamburgerPrice = 330;
            int cokePrice = 35;
            int pizzaPrice = 450;
            int waterPrice = 10;
            Console.WriteLine("------------Restoran menusu-----------------");
            Console.WriteLine($"-----Hamburger: {hamburgerPrice}");
            Console.WriteLine($"-----Coke: {cokePrice}");
            Console.WriteLine($"-----Pizza: {pizzaPrice}");
            Console.WriteLine($"-----Water: {waterPrice}");

            int hamburgerCount = 3;
            int cokeCount = 3;

            int totalHamburger = hamburgerCount * hamburgerPrice;
            int totalCoke = cokePrice * cokeCount;
            Console.WriteLine("Tutarlar:/");
            Console.WriteLine($"-{hamburgerCount} hamburger toplam fiyatı: {totalHamburger}");
            Console.WriteLine($"-{cokeCount} kola toplam fiyatı: {totalCoke}");




            #endregion

            Console.Read();

        }
    }
}
