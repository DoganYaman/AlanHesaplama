using System;

namespace alan_hesaplama
{
    public class Dikdortgen : ISekil
    {
        public double KisaKenar { get; set; }
        public double UzunKenar { get; set; }

        public void ParametreleriAyarla()
        {
            Console.Write("Dikdörtgenin uzun kenarını girin: ");
            UzunKenar = Convert.ToDouble(Console.ReadLine());

            Console.Write("Dikdörtgenin kısa kenarını girin: ");
            KisaKenar = Convert.ToDouble(Console.ReadLine());
        }

        public double CevreHesapla()
        {
            return 2 * (KisaKenar + UzunKenar);
        }

        public double AlanHesapla()
        {
            return  KisaKenar * UzunKenar;
        }

        public void AlanHesaplaVeGoster()
        {
            Console.WriteLine($"Dikdortgenin Alanı: {AlanHesapla()}");
        }

        public void CevreHesaplaVeGoster()
        {
            Console.WriteLine($"Dikdortgenin Çevresi: {CevreHesapla()}");
        }
    }
}