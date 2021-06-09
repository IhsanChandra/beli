using System;
using System.Collections.Generic;
using System.Text;

namespace belimakanan
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            Console.WriteLine("Resto Tugas PBO :)");
            Console.WriteLine("Masukkan nama anda : ");
            string nama = Console.ReadLine();
            Console.WriteLine("Masukkan No HP : ");
            string hp = Console.ReadLine();
            Console.WriteLine("List Makanan :");
            int a = menu.PesanMa();
            Console.WriteLine("List Minuman :");
            int b = minum.PesanMi();
            Console.WriteLine("Ambil Sendiri? (y/n)");
            string jawab = Console.ReadLine();
            if (jawab == "y")
            {
                total = a + b;
            }
            if (jawab == "n")
            {
                Console.WriteLine("Masukkan alamat Anda : ");
                string alamat = Console.ReadLine();
                total = a + b + 10000;
            }
            Console.WriteLine("Total pesanan anda adalah:");
            Console.WriteLine(total);
        }
    }
}