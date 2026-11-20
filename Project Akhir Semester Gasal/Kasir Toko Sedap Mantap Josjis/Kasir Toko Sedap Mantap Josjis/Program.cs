using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kasir_Toko_Sedap_Mantap_Josjis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Daftar menu dan harga
            string[] Daftarmenu = { "Es Teler Original", "Es Teler Durian", "Es Teler Alpukat", "Es Teler Spesial" };
            double[] Daftarharga = { 7000, 15000, 12000, 20000 };

            // daftar menu camilan dan harga camilan
            string[] Menucamilan = { "Dimsum Original (isi 4)", "Dimsum Mentai (isi 4)", "Dimsum Goreng (isi 4)", "Dimsum Mix(isi 6)" };
            double[] Hargacamilan = { 10000, 16000, 10000, 18000 };

            Console.WriteLine("====== APLIKASI KASIR TOKO SEDAP MANTAP JOSJIS ======");
            Console.WriteLine();
            Console.WriteLine("DAFTAR MENU SEDAP MANTAP JOSJIS :");

            //  1. daftar menu utama
            Console.WriteLine("\nEs Teler Jojis :");
            for (int i = 0; i < Daftarmenu.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {Daftarmenu[i]} - Rp {Daftarharga[i]}");
            }

            // 2. menu camilan
            Console.WriteLine("\nDimsum Josjis :");
            for (int i = 0; i < Menucamilan.Length; i++)
            {
                // menggunakan nomer urut lanjut (5 sampaai 8) atau mulai dari 1 lagi
                Console.WriteLine($"{i + 5}. {Menucamilan[i]} - Rp {Hargacamilan[i]}");
            }

            double totalBelanja = 0;
            string statusBeli = "y";

            // perulangan sederhana jika mau tambah belanjaan
            while (statusBeli == "y" || statusBeli == "Y")
            {

                // bagian kasir (input pesanan)
                Console.WriteLine("\n-----------------------------");
                Console.Write("Pilih nomor menu yang ingin dibeli (1-8): ");
                int pilihan = Convert.ToInt32(Console.ReadLine());

                Console.Write("Masukkan jumlah beli: ");
                int jumlah = Convert.ToInt32(Console.ReadLine());

                string namaMenuPilihan = "";
                double hargaSatuan = 0;

                // menentukan apakah yang dipilih menu utama (1-4) atau menu camilan (5-8)
                if (pilihan >= 1 && pilihan <= 4)
                {
                    namaMenuPilihan = Daftarmenu[pilihan - 1];
                    hargaSatuan = Daftarharga[pilihan - 1];
                }
                else if (pilihan >= 5 && pilihan <= 8)
                {
                    namaMenuPilihan = Menucamilan[pilihan - 5];
                    hargaSatuan = Hargacamilan[pilihan - 5];
                }
                else
                {
                    Console.WriteLine("Pilihan menu tidak valid!");
                    continue;
                }

                // menghitung subtotal dan menambahkan ke total belanja
                double total = hargaSatuan * jumlah;
                totalBelanja += total;

                Console.WriteLine($"\nMenu Dipilih : {namaMenuPilihan} ({jumlah}x)");
                Console.WriteLine($"subtotal       : Rp {total}");

                Console.Write("Mau Tambah Menu Lain? (y/n): ");
                statusBeli = Console.ReadLine();
            }

            // bagian pembayaran akhir
            Console.WriteLine("\n-------------------------------");
            Console.WriteLine($"TOTAL KESELURUHAN : Rp {totalBelanja}");

            Console.Write("Uang Pembayaran: Rp ");
            double bayar = Convert.ToDouble(Console.ReadLine());

            // Pemilihan (If-Else) untuk hitung kembalian
            if (bayar >= totalBelanja)
            {
                double kembalian = bayar - totalBelanja;
                Console.WriteLine($"Kembalian  : Rp {kembalian}");
                Console.WriteLine("Terimakasih sudah berbelanja di TOKO SEDAP MANTAP JOSJIS!");
            }
            else
            {
                Console.WriteLine("Maaf, uang pembayaran kurang!");
            }

        }
    }
}