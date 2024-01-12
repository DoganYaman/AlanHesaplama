using System;

namespace alan_hesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            ISekil sekil = Hesapla.SekilSec();

            if(sekil != null)
            {
                Hesapla.HesaplaVeGoster(sekil);
            }
        }
    }
}
