using System;
using static System.Console;
namespace BINSEARCH_AZ
{
    class Program
    {
        static void Main()
        {
            string L = "";
            int N = 100;
            Random R = new Random();
            int[] A = new int[N + 1];

            for (int X = 1; X <= N; X++)
                A[X] = R.Next(100, 1000);
            Array.Sort(A);
            for (int X = 1; X <= N; X++)
                Write(" {0} ", A[X]);
            ReadKey();

            do
            {
                Clear();
                int Ada = 0;
                for (int X = 1; X <= N; X++)
                    Write(" {0} ", A[X]);
                Write("\n Cari = ");
                int Cari = int.Parse(ReadLine());
                int Kr = 1, Kn = N, T = (Kr + Kn) / 2;

                do
                {
                    if (A[T] == Cari) { Ada = 1; break; }
                    if (Cari > A[T]) Kr = T + 1;
                    else Kn = T - 1;
                    T = (Kr + Kn) / 2;
                }
                while (Kr <= Kn);

                if (Ada == 1) Write("\n {0} ada di posisi ke {1}", Cari, T);
                else Write("\n {0} tidak ada ... \n", Cari);

                Write("\n Lagi [Y/y] : ");
                L = ReadLine();
            }
            while (L == "y" || L == "Y");
        }
    }
}
