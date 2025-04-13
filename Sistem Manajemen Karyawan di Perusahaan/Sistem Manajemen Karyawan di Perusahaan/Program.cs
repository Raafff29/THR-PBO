
class Karyawan
{
    private string nama;
    private string id;
    private double gajiPokok;

    public string Nama
    {
        get { return nama; }
        set { nama = value; }
    }

    public string ID
    {
        get { return id; }
        set { id = value; }
    }

    public double GajiPokok
    {
        get { return gajiPokok; }
        set { gajiPokok = value; }
    }

   
    public virtual double HitungGaji()
    {
        return gajiPokok;
    }
}


class KaryawanTetap : Karyawan
{
    public override double HitungGaji()
    {
        return GajiPokok + 500000;
    }
}


class KaryawanKontrak : Karyawan
{
    public override double HitungGaji()
    {
        return GajiPokok - 200000;
    }
}


class KaryawanMagang : Karyawan
{
    public override double HitungGaji()
    {
        return GajiPokok;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Sistem Manajemen Karyawan ===");
        Console.WriteLine("Pilih jenis karyawan:");
        Console.WriteLine("1. Karyawan Tetap");
        Console.WriteLine("2. Karyawan Kontrak");
        Console.WriteLine("3. Karyawan Magang");
        Console.Write("Masukkan pilihan (1/2/3): ");
        string pilihan = Console.ReadLine();

        Console.Write("Masukkan Nama: ");
        string nama = Console.ReadLine();

        Console.Write("Masukkan ID: ");
        string id = Console.ReadLine();

        Console.Write("Masukkan Gaji Pokok: ");
        double gajiPokok = Convert.ToDouble(Console.ReadLine());

        Karyawan karyawan;

      
        if (pilihan == "1")
        {
            karyawan = new KaryawanTetap();
        }
        else if (pilihan == "2")
        {
            karyawan = new KaryawanKontrak();
        }
        else if (pilihan == "3")
        {
            karyawan = new KaryawanMagang();
        }
        else
        {
            Console.WriteLine("Pilihan tidak valid.");
            return;
        }

     
        karyawan.Nama = nama;
        karyawan.ID = id;
        karyawan.GajiPokok = gajiPokok;

     
        Console.WriteLine("\n=== Detail Karyawan ===");
        Console.WriteLine("Nama: " + karyawan.Nama);
        Console.WriteLine("ID: " + karyawan.ID);
        Console.WriteLine("Gaji Pokok: " + karyawan.GajiPokok);
        Console.WriteLine("Gaji Akhir: " + karyawan.HitungGaji());
    }
}
