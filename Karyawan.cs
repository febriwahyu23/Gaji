using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gajikaryawan
{
    class Karyawan
    {
        public string nik { get; set; }
        public string nama { get; set; }
        public int gaji { get; set; }

        public Karyawan(string nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;
            this.gaji = gaji;

            if (gaji < 0) { this.gaji = 0; }
        }
        public void kenaikanGaji()
        {
            if (gaji < 0) { gaji = 0; }
            Console.WriteLine("selamat, dapat bonus 10%!!");
            Console.WriteLine();
        }
    }
}
