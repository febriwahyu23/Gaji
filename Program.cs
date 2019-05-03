using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gajikaryawan
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan k1 = new Karyawan("12345", "Febri", 5000000);
            Karyawan k2 = new Karyawan("09876", "Wahyu", 5000000);

            Hasil(k1, k2);

            Console.ReadKey();
        }
        public static void Hasil(Karyawan k1, Karyawan k2)
        {
            Console.WriteLine("NIK           Nama          Gaji");
            Console.WriteLine("{0}        {1}           {2}", k1.nik, k1.nama, k1.gaji);
            Console.WriteLine("{0}        {1}           {2}", k2.nik, k2.nama, k2.gaji);

            Console.WriteLine("==================================");
            Console.WriteLine("selamat, dapat bonus 10%!!");
            Console.WriteLine("==================================");

            double bonus1 = (0.10 * k1.gaji) + k1.gaji;
            double bonus2 = (0.10 * k2.gaji) + k2.gaji;

            Console.WriteLine("NIK           Nama           Gaji");
            Console.WriteLine("{0}        {1}            {2}", k1.nik, k1.nama, bonus1);
            Console.WriteLine("{0}        {1}            {2}", k2.nik, k2.nama, bonus2);
        }
    }
}
