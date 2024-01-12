using System;

namespace alan_hesaplama
{
    public static class Hesapla
    {
        public static ISekil SekilSec()
        {
            Console.Write("Hesaplamak istediğiniz geometrik şekli seçin --> (1) Daire, (2) Üçgen, (3) Kare, (4) Dikdörtgen : ");
            int sekilSecim = int.Parse(Console.ReadLine());

            ISekil sekil = null;

            switch (sekilSecim)
            {
                case (int)SekilTipi.Daire :
                    sekil = new Daire();
                    break;
                case (int)SekilTipi.Ucgen :
                    sekil = new Ucgen();
                    break;
                case (int)SekilTipi.Kare :
                    sekil = new Kare();
                    break;
                case (int)SekilTipi.Dikdortgen :
                    sekil = new Dikdortgen();
                    break;
                default:
                    Console.WriteLine("Geçersiz geometrik şekil secimi.");
                    break;
            }

            return sekil;
        }

        public static void HesaplaVeGoster(ISekil sekil)
        {
            sekil.ParametreleriAyarla();

            Console.Write("Hesaplamak istediğiniz boyutu seçin --> (1) Çevre, (2) Alan : ");
            int boyutSecim = int.Parse(Console.ReadLine());

            switch (boyutSecim)
            {
                case (int)Boyut.Cevre :
                    sekil.CevreHesaplaVeGoster();
                    break;
                case (int)Boyut.Alan:
                    sekil.AlanHesaplaVeGoster();
                    break;
                default:
                    Console.WriteLine("Geçersiz boyut seçimi.");
                    break;
            }
        }
    }
}