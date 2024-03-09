using System;

class Program
{
    static Tuple<int, int> sum_(int[] x)
    {
        int toplam = 0;

        foreach (var item in x)
        {
            toplam += item;
        }

        return Tuple.Create(toplam, x.Length);
    }

    static double Ortalama(Tuple<int, int> x)
    {
        int toplam = x.Item1;
        int count = x.Item2;

        double Ortalama = (double)toplam / count;

        return Ortalama;
    }

    static void Main()
    {
        Console.Write("Başlama değeri: ");
        int ilk = Convert.ToInt32(Console.ReadLine());

        Console.Write("Son değer: ");
        int son = Convert.ToInt32(Console.ReadLine());

        int[] list = new int[son - ilk + 1];

        for (int i = 0; i < list.Length; ++i)
        {
            list[i] = ilk + i;
        }

        var resultSum = sum_(list);
        var OrtalamaSonucu = Ortalama(resultSum);

        Console.WriteLine("Ortalama: " + OrtalamaSonucu);
    }
}
