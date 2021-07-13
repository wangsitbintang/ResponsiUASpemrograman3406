using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<string> daftarMahasiswa = new List<string>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        HapusMahasiswa();
                        break;

                    case 3:
                        TampilMahasiswa();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.Title = "Responsi Pemrograman";
            Console.Write(" Pilih Menu :");
            Console.WriteLine();
            Console.Write("1.Tambah Data Mahasiswa");
            Console.WriteLine();
            Console.Write("2.Data Mahasiswa ");
            Console.WriteLine();
            Console.Write("3.Hapus Data Mahasiswa");
            Console.WriteLine();
            Console.Write("4.Keluar");
            Console.WriteLine();
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Mahasiswa\n");
            Console.Write("NIM : ");
            string nim = Console.ReadLine();
            Mahasiswa delete = daftarMahasiswa.SingleOrDefault(x => x.NIM == nim);
            if (daftarMahasiswa.Contains(delete) == true)
            {
                daftarMahasiswa.Remove(delete);
                Console.WriteLine("Data Mahasiswa Berhasil Dihapus");
            }
            else
            {
                Console.WriteLine("NIM Tidak Ditemukan");
            }


            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            Console.WriteLine("No\tNIM\tNama \tJenis Kelamin\tIPK");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {

                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no, mahasiswa.NIM, mahasiswa.Nama, mahasiswa.JK, mahasiswa.IPK);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
