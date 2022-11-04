using System;
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
                n = Int32.Parse(s); // konversi input line menjadi integer

                // melakukan pengecekan tidak lebih dari batas maksimal jumlah element
                if (n <= 44)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nArray can have maximum 44 elements \n");
                }

                Console.WriteLine("");
                Console.WriteLine("----------------------------");
                Console.WriteLine("Insert elemen array");
                Console.WriteLine("----------------------------");

                //meminta value element secara bertahap dengan for
                for (int i = 0; i < n; i++)
                {
                    Console.Write("<" + (i + 1) + "> ");
                    string s1 = Console.ReadLine();
                    habib[i] = Int32.Parse(s1);
                }
            }
        }

        


        static void Main(string[] args)
        {
        }
    }
}
