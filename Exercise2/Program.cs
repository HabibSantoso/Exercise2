﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        // deklarasi vaiable array
        double[] habib = new double[44];
        // deklarasi counter perpindahan checker dan perbandingan
        private int cmp_count = 0;
        private int mov_count = 0;

        //
        private int n;


        //function untuk menapilkan permintaan element
        void input()
        {
            while (true)
            {
                Console.Write("Enter the number of element in the array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nArray can have maximum 44 elements \n");
                }

            }
        }

        static void Main(string[] args)
        {
        }
    }
}
