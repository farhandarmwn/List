﻿using System;
using System.Collections.Generic;

namespace Collection2
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek mhs1
            Mahasiswa mhs1 = new Mahasiswa();
            mhs1.Nim = "3000";
            mhs1.NamaMahasiswa = "Ganteng";

            // membuat objek mhs2
            Mahasiswa mhs2 = new Mahasiswa();
            mhs2.Nim = "2000";
            mhs2.NamaMahasiswa = "Cantik";

            // membuat objek dosen
            Dosen dosen = new Dosen();
            dosen.Nik = "500";
            dosen.NamaDosen = "Jhono";

            // membuat objek list
            List<Mahasiswa> list = new List<Mahasiswa>();

            // menambahkan elemen list
            // tidak ada proses unboxing
            list.Add(mhs1);
            list.Add(mhs2);

            Console.WriteLine("Nim      Nama\n");
            Console.WriteLine("============");

            foreach (Mahasiswa mhs in list)
            {
                Console.WriteLine("{0}, {1}", mhs.Nim, mhs.NamaMahasiswa);
            }

            Console.ReadKey();
        }
    }
}
