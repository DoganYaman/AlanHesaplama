using System;

namespace alan_hesaplama
{
    public class Ucgen : ISekil
    {
        public double KenarA { get; set; }
        public double KenarB { get; set; }
        public double KenarC { get; set; }
        public void ParametreleriAyarla()
        {
            Console.Write("Üçgenin A kenarını girin: ");
            KenarA = Convert.ToDouble(Console.ReadLine());
    
            Console.Write("Üçgenin B kenarını girin: ");
            KenarB = Convert.ToDouble(Console.ReadLine());
    
            Console.Write("Üçgenin C kenarını girin: ");
            KenarC = Convert.ToDouble(Console.ReadLine());
        }

        public double CevreHesapla()
        {
            return KenarA + KenarB + KenarC;
        }

        public double AlanHesapla()
        {
            double s = CevreHesapla() / 2;
            return Math.Sqrt(s * (s - KenarA) * (s - KenarB) * (s - KenarC));
        }

        public void AlanHesaplaVeGoster()
        {
            Console.WriteLine($"Üçgenin Alanı: {AlanHesapla()}");
        }

        public void CevreHesaplaVeGoster()
        {
            Console.WriteLine($"Üçgenin Çevresi: {CevreHesapla()}");
        }
    }
}