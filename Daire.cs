using System;

namespace alan_hesaplama
{
    public class Daire : ISekil
    {
        public Daire()
        {
            PI = Math.Round(Math.PI, 2);
        }
        public double YariCap { get; set; }
        public double PI { get; set; }

        

        public void ParametreleriAyarla()
        {
            Console.Write("Dairenin yarı çapını girin: ");
            YariCap = Convert.ToDouble(Console.ReadLine());
        }

        public double CevreHesapla()
        {
            return 2 * PI * YariCap;
        }

        public double AlanHesapla()
        {
            return PI * YariCap * YariCap;
        }

        public void AlanHesaplaVeGoster()
        {
            Console.WriteLine($"Dairenin Alanı: {AlanHesapla()}");
        }

        public void CevreHesaplaVeGoster()
        {
            Console.WriteLine($"Dairenin Çevresi: {CevreHesapla()}");
        }
    }
}