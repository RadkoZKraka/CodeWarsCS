using System;
using System.Collections.Generic;

namespace Snail
{
    internal class Program
    {
        public static int[] Snail(int[][] array)
        {
            List<int> ans = new List<int>();
  
            if (array.Length == 0)
                return ans.ToArray();

            int R = array.Length;
            int C = array[0].Length;
            bool[,] seen = new bool[R,C];
            int[] dr = { 0, 1, 0, -1 };
            int[] dc = { 1, 0, -1, 0 };
            int r = 0, c = 0, di = 0;
  
            // Iterate from 0 to R * C - 1
            for (int i = 0; i < R * C; i++) {
                ans.Add(array[r][c]);
                seen[r,c] = true;
                int cr = r + dr[di];
                int cc = c + dc[di];
  
                if (0 <= cr && cr < R && 0 <= cc && cc < C
                    && !seen[cr,cc]) {
                    r = cr;
                    c = cc;
                }
                else {
                    di = (di + 1) % 4;
                    r += dr[di];
                    c += dc[di];
                }
            }
            return ans.ToArray();
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(Snail(new []{new []{1, 2, 3},
                new []{4, 5, 6},
                new []{7, 8, 9}}));
        }
    }
}