﻿using System;
using System.Threading;

namespace exercicio_matriz {
    class Program {

        static void Main(string[] args) {

            string[] values = Console.ReadLine().Split(' ');

            Console.WriteLine("Digite as dimensões da matriz: ");
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, m];

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Digite o número que deseja encontrar: ");
            int num = int.Parse(Console.ReadLine());
            int cont = 0;

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine("Position " + i + "," + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }


        }
    }
}
