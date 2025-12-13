using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace r7_1213_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Magic Square
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc436/tasks/abc436_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var matrix = new int[n, n];

            var r = 0;
            var c = (n - 1) / 2;
            var k = 1;
            matrix[r, c] = k;

            for (var x = 1; x <= n * n - 1; x++) {
                k++;
                var next_r = r - 1 < 0 ? (r + n - 1) % n : (r - 1) % n;
                var next_c = (c + 1) % n;
                if (matrix[next_r, next_c] == 0) {
                    matrix[next_r, next_c] = k;
                } else {
                    next_r = (r + 1) % n;
                    next_c = c;
                    matrix[next_r, next_c] = k;
                }
                r = next_r;
                c = next_c;
            }

            var result = new StringBuilder();
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    result.Append($"{matrix[i, j]} ");
                }
                result.Remove(result.Length - 1, 1);
                result.AppendLine();
            }
            Console.Write(result);
        }
    }
}
