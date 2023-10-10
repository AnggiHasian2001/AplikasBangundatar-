using System;

namespace Aplikasi_Switch
{
    /// <summary>
    /// Class Persegi Panjang 
    /// </summary>
    class PersegiPanjang
    {
        /// <summary>
        /// Deklarasi variabel global panjang dan lebar 
        /// </summary>
        public double panjang, lebar;

       
        /// <summary>
        /// Method input variabvel sisi persegi panjang 
        /// </summary>
        public void sisiPP()

        {
            Console.Write("Masukkan Panjang =");
            panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Lebar   =");
            lebar = Convert.ToDouble(Console.ReadLine());
        }

       
        /// <summary>
        /// Method menghitung Luas Persegi Panjang 
        /// </summary>
        /// <param name="p">Nilai input panjang</param>
        /// <param name="l">Nilai Input Lebar </param>
        /// <returns></returns>
        public double LuasPP(double p,double l)
        {
            return p * l;
        }

       
        /// <summary>
        /// Method Menampilkan data luas persegi panjang
        /// </summary>
        public void tampilPP()
        {
            Console.WriteLine("Luas Persegi Panjang =" + this.LuasPP(panjang, lebar));
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Class Lingkaran 
    /// </summary>
    class Lingkaran
    {
        /// <summary>
        /// Deklarasi variabel Global Jari - Jari
        /// </summary>

        public double jejari;
        /// <summary>
        /// Method Input Jari lingkaran 
        /// </summary>
        public void jariLingkaran()
        {
            Console.Write("Masukkan jari-jari   =");
            jejari = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Method menghitung luas lingkaran 
        /// </summary>
        /// <param name="r">Nilai Inputan Jari - jari Lingkaran </param>
        /// <returns></returns>
        public double LuasLing(double r)
        {
            return 3.14 * r * r;
        }
        /// <summary>
        /// Method Menampilkan Luas Lingkaran 
        /// </summary>
        public void tampilLing()
        {
            Console.WriteLine("Luas Lingkaran   =" + this.LuasLing(jejari));
            Console.ReadKey();
        }
    }
    /// <summary>
    /// Class Segitiga 
    /// </summary>
    class Segitiga
    {
        /// <summary>
        /// Deklarasi Variabel Global alas dan Tinggi
        /// </summary>
        public double alas, tinggi;
        public void sisiS3()
        {
            Console.Write("Masukkan Alas    =");
            alas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan Tinggi  =");
            tinggi = Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Method menghitung luas segitigas
        /// </summary>
        /// <param name="a"> Nilai Inputan Alas Segitiga</param>
        /// <param name="t">Nilai Inputan Tinggi Segitiga </param>
        /// <returns></returns>
        public double LuasS3(double a, double t)
        {
            return 0.5 * a * t;
        }
        /// <summary>
        /// Method Menampilkan Luas Segi Tiga 
        /// </summary>
        public void tampilS3()
        {
            Console.WriteLine("Luas Segitiga    =" + this.LuasS3(alas, tinggi));
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Membuat instance untuk Class PersegiPanjang, Lingkaran, dan Segitiga
            PersegiPanjang pp = new PersegiPanjang();
            Lingkaran lk = new Lingkaran();
            Segitiga s3 = new Segitiga();

            // Deklarasi Variabel untuk ekspresi SWITCH
            int pilih;

            // Membuat Tampilan MENU
            Console.WriteLine("MENU");
            Console.WriteLine("----------");
            Console.WriteLine("1. Luas Persegi Panjang");
            Console.WriteLine("2. Luas Lingkaran");
            Console.WriteLine("3. Luas Segitiga");
            Console.WriteLine("4. Keluar");
            Console.Write("Pilihan (1/2/3/4) : ");

            pilih = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            switch(pilih)
            {
                case 1:
                    pp.sisiPP();
                    pp.tampilPP();
                    break;
                case 2:
                    lk.jariLingkaran();
                    lk.tampilLing();
                    break;
                case 3:
                    s3.sisiS3();
                    s3.tampilS3();
                    break;
                case 4:
                    break;

                default:
                    Console.WriteLine("Pilihan Salah !");
                    Console.ReadKey();
                    while (ConsoleKey.Enter.ToString() == "Enter") ;
                    break;
            }
        }
    }
}
