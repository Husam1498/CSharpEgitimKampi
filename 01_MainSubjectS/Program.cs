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

            Console.WriteLine("*****Yemek Kategorileri************");
            Console.WriteLine("");
            Console.WriteLine("1-Çorbalar");
            Console.WriteLine("2-Ana Yemekler");
            Console.WriteLine("3-Soğuk başlangıçlar");
            Console.WriteLine("4-Salatalar");
            Console.WriteLine("5-tatlılar");
            Console.WriteLine("6-İçecekler");
            Console.WriteLine("---------------------------------------");

            #endregion

            #region Değişkneller
            string name;
            name = "dfks";
            Console.WriteLine(name);
            string customerName, district, city;

            customerName = "HUam";
            Console.WriteLine("********Rezervasyon***********")
            Console.WriteLine("Müşteri:"+customerName);
            #endregion

            Console.Read();

        }
    }
}
