using System;
using System.Collections.Generic;
using System.Text;

namespace belimakanan
{
    public class minum
    {
        public static int PesanMi()
        {
            int totalmi = 0;
            int t = 0;
            int j = 0;
            int at = 0;
            int aj = 0;
            int temp = 0;
            Console.WriteLine("1. Teh");
            Console.WriteLine("2. Jeruk");
            Console.WriteLine("Pilih minuman");

            int pilih = Convert.ToInt32(Console.ReadLine());

            while (pilih > 0)
            {
                if (pilih == 1)
                {
                    Console.WriteLine("Jumlah : ");
                    t = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Teh " + t);
                    at = t * 5000;
                    temp = at ;
                    totalmi += temp;
                    break;
                }
                else if (pilih == 2)
                {
                    Console.WriteLine("Jumlah : ");
                    j = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Jeruk " + j);
                    aj = j * 5000;
                    temp = aj;
                    totalmi += temp;
                    break;
                }
                else if (pilih == 4)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Tidak ada pilihan angka" + pilih);
                }
            }
            return totalmi;
        }
        //public static int totalmin { get; set; } = totalmi;
    }
}