using System;
using System.Collections.Generic;
using System.Text;

namespace belimakanan
{
    public class menu
    {
        int totalmak { get; set; }
        public static int PesanMa()
        {
            int totalma = 0;
            int total = 0;
            int aa = 0;
            int bb = 0;
            int ii = 0;
            int ta = 0;
            int tb = 0;
            int ti = 0;
            int temp = 0;
            Console.WriteLine("1 Ayam");
            Console.WriteLine("2 Bebek");
            Console.WriteLine("3 Ikan");
            Console.WriteLine("Pilih makanan");

            int pilih = Convert.ToInt32(Console.ReadLine());
            while (pilih > 0)
            {
                if (pilih == 1)
                {
                    Console.WriteLine("Jumlah : ");
                    aa = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ayam " + aa);
                    ta = aa * 15000;
                    temp = ta;
                    totalma += temp;
                    total = totalma;
                    break;
                }
                else if (pilih == 2)
                {
                    Console.WriteLine("Jumlah : ");
                    bb = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Bebek " + bb);
                    tb = bb * 14000;
                    temp = tb;
                    totalma += temp;
                    total = totalma;
                    break;
                }
                else if (pilih == 3)
                {
                    Console.WriteLine("Jumlah : ");
                    ii = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ikan " + ii);
                    ti = ii * 15000;
                    temp = ti;
                    totalma += temp;
                    total = totalma;
                    break;

                }
                else if (pilih == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tidak ada pilihan angka " + pilih);
                    continue;
                }
                Console.WriteLine(aa);
                ta = aa * 15000;
                temp = ta + tb + ti;
                totalma += temp;
                total = totalma + temp;
                continue;
            }
            return total;
        }
        //public static int totalmak { get; set; } = totalma;
    }
}