
using System;


namespace ResponsiPemrograman2651
{
    class Karyawan
    {
        
        public int Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }
        public Karyawan(int nik, string nama, int gajibulanan)
        {
	   
            Nik = nik;
            Nama = nama;
            if (gajibulanan < 0)
            {
                GajiBulanan = 0;
            }
            else
            {
                GajiBulanan = gajibulanan;
            }
        }

        public void DataKaryawan()
        {
            Console.WriteLine(" {0} {1} {2} ", Nik, Nama, GajiBulanan);
        }
        public void gajinaik()
        {
            Console.WriteLine(" {0} {1} {2} ", Nik, Nama, (GajiBulanan * 110 / 100));
        }
    }
}