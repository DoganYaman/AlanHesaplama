using System;

namespace alan_hesaplama
{
    public class Kare : ISekil
    {
        public double Kenar { get; set; }
        public void ParametreleriAyarla()
        {
            Console.Write("Karenin bir kenarını girin: ");
            Kenar = Convert.ToDouble(Console.ReadLine());
        }

        public double CevreHesapla()
        {
            return 4 * Kenar;
        }

        public double AlanHesapla()
        {
            return Kenar * Kenar;
        }

        public void AlanHesaplaVeGoster()
        {
            Console.WriteLine($"Karenin Alanı: {AlanHesapla()}");
        }

        public void CevreHesaplaVeGoster()
        {
            Console.WriteLine($"Karenin Çevresi: {CevreHesapla()}");
        }
    }
}