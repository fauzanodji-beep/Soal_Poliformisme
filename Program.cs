using System;

// =======================
// OVERLOADING
// =======================
class ImageProcessor
{
    // Resize berdasarkan persen
    public void Resize(int persen)
    {
        if (persen < 100)
            Console.WriteLine("Gambar diperkecil menjadi " + persen + "%");
        else
            Console.WriteLine("Gambar diperbesar menjadi " + persen + "%");
    }

    // Resize berdasarkan lebar & tinggi
    public void Resize(int lebar, int tinggi)
    {
        Console.WriteLine($"Gambar diubah ke ukuran {lebar} x {tinggi}");
    }

    // Resize berdasarkan ukuran kertas
    public void Resize(string ukuranKertas)
    {
        Console.WriteLine("Gambar disesuaikan dengan ukuran kertas: " + ukuranKertas);
    }
}

// =======================
// OVERRIDING
// =======================
class MetodePembayaran
{
    public virtual void Bayar(int jumlah)
    {
        Console.WriteLine("Melakukan pembayaran sebesar " + jumlah);
    }
}

class BankTransfer : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine("Pembayaran via Bank Transfer: " + jumlah);
    }
}

class EWallet : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine("Pembayaran via E-Wallet: " + jumlah);
    }
}

class KartuKredit : MetodePembayaran
{
    public override void Bayar(int jumlah)
    {
        Console.WriteLine("Pembayaran via Kartu Kredit: " + jumlah);
    }
}

// =======================
// MAIN PROGRAM
// =======================
class Program
{
    static void Main()
    {
        Console.WriteLine("=== OVERLOADING ===");
        ImageProcessor img = new ImageProcessor();

        img.Resize(50);
        img.Resize(150);
        img.Resize(1920, 1080);
        img.Resize("A4");

        Console.WriteLine("\n=== OVERRIDING ===");

        MetodePembayaran metode;

        metode = new BankTransfer();
        metode.Bayar(100000);

        metode = new EWallet();
        metode.Bayar(50000);

        metode = new KartuKredit();
        metode.Bayar(200000);
    }
}

