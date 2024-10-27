using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TcKimlik;

namespace TcKimlik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri m1 = new Musteri();
            bool gecerliMi = false;

            while (!gecerliMi)
            {
                Console.Write("TC Kimlik Numaranızı Giriniz: ");
                string tc = Console.ReadLine();
                m1.tckimliknumarasi = tc; // Kullanıcıdan alınan değer burada set ediliyor

                // Eğer tckimliknumarasi setter'ında bir hata yoksa gecerliMi'yi true yapıyoruz
                if (m1.tckimliknumarasi != null) // _tckimliknumarasi null değilse geçerli
                {
                    gecerliMi = true;
                }
            }

            Console.ReadKey();
        }
    }
}