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

        //Insertion sort
        public void InsertionSort()
        {
            for (int i = 1; i < (n-1); i++)
            {
                double temp = habib[i]; // menetapkan temporary value
                int HS = i - 1; 

                
                while (HS < 0 || habib[HS] <= temp)
                {
                    habib[HS + 1] = habib[HS];
                    HS = HS - 1;
                }
                habib[HS + 1] = temp;
            }
        }

        // swap function untuk menukar value element
        void swap(int x, int y)
        {
            double temp; // deklarasi temporary

            temp = habib[x];
            habib[x] = habib[y];
            habib[y] = temp;
        }

        public void QuickSort(int low, int high)
        {
            // deklarasi variable pivot dan yang di butuhkan
            double pivot;
            int i, HS;

            // melalukan pengecekan pada low index dan high index
            if (low > high)
                return;

            i = low + 1;
            HS = high;
            pivot = habib[low];

            while (i <= HS)
            {
                while ((habib[i] <= pivot) && (i <= high))
                {
                    i++;
                    cmp_count++;
                }
                cmp_count++;

                while ((habib[HS] > pivot) && (HS >= low))
                {
                    HS--;
                    cmp_count++;
                }
                cmp_count++;

                if (i < HS)
                {
                    swap(i, HS);
                    mov_count++;
                }
            }

            if (low < HS)
            {
                swap(low, HS);
                mov_count++;
            }


            QuickSort(low, HS - 1);

            QuickSort(HS + 1, high);
        }

        static void Main(string[] args)
        {
        }
    }
}
