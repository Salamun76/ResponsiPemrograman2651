using System;


namespace ResponsiPemrograman2651
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(190302123, "Paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "Jono", 2000000);

            Console.WriteLine("NIK/Nama          Gaji Bulanan");
            Console.WriteLine("---------------------------------");
            karyawan1.DataKaryawan();
            karyawan2.DataKaryawan();
            Console.WriteLine();
            Console.WriteLine("Asyiiiiik kenaikan gaji 10%!");
            Console.WriteLine("---------------------------------");
            karyawan1.gajinaik();
            karyawan2.gajinaik();

            Console.ReadKey();
        }
    }
}