using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace r7_0503_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Grid Rotation
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc404/tasks/abc404_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var s_ij = new char[n, n];
            var t_ij = new char[n, n];

            // グリッドSを入力
            for (var i = 0; i < n; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var j = 0; j < n; j++) {
                    s_ij[i, j] = line[j];
                }
            }

            // グリッドTを入力
            for (var i = 0; i < n; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var j = 0; j < n; j++) {
                    t_ij[i, j] = line[j];
                }
            }

            // s_ij を右に90度回転させる
            var s_ij_p90 = RoatateP90(s_ij, n);

            // s_ij を右に180度回転させる
            var s_ij_p180 = RoatateP90(s_ij_p90, n);

            // s_ij を右に270度回転させる
            var s_ij_p270 = RoatateP90(s_ij_p180, n);

            var diffCounts = new List<int>();

            diffCounts.Add(DiffCells(s_ij, t_ij, n, 0));
            diffCounts.Add(DiffCells(s_ij_p90, t_ij, n, 1));
            diffCounts.Add(DiffCells(s_ij_p180, t_ij, n, 2));
            diffCounts.Add(DiffCells(s_ij_p270, t_ij, n, 3));

            diffCounts.Sort((x,y) => x - y);
            Console.WriteLine(diffCounts[0]);
        }

        static char[,] RoatateP90(char[,] original, int n) {
            // work は上下反転
            var work = new char[n, n];
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    work[i, j] = original[n - i - 1, j];
                }
            }

            var result = new char[n, n];
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    result[j, i] = work[i, j];
                }
            }
            return result;
        }

        static int DiffCells(char[,] a, char[,] b, int n, int offset) {
            var result = offset; // 回転に要した回数を初期値として考慮する

            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    if (a[i, j] != b[i, j]) result++;
                }
            }

            return result;
        }
    }
}
