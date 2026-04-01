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

