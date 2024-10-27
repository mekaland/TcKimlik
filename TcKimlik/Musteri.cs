using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcKimlik
{
    internal class Musteri
    {
        private string _tckimliknumarasi;

        public string tckimliknumarasi
        {
            get { return _tckimliknumarasi; }
            set
            {
                if (value.Length == 11)
                {
                    bool bayrak = false;
                    for (int i = 0; i < value.Length; i++)
                    {
                        bool karakterKontrol = char.IsNumber(value[i]);
                        if (!karakterKontrol)
                        {
                            bayrak = true;
                            break;
                        }
                    }

                    if (bayrak)
                    {
                        Console.WriteLine("TC kimlik numarasındaki değerler sayısal olmalıdır.");
                    }
                    else
                    {
                        _tckimliknumarasi = value; // Değişiklik burada
                        Console.WriteLine("Tebrikler, işte TC kimlik numaranız: " + _tckimliknumarasi);
                    }
                }
                else
                {
                    Console.WriteLine("TC kimlik numarası 11 haneli olmalıdır.");
                }
            }
        }
    }
}
