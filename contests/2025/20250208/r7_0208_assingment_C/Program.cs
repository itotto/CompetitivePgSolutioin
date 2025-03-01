using System.Collections.Generic;

namespace r7_0208_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Bib 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc392/tasks/abc392_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // 見てる人
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;

            // key:i, value: P_i  人→見てる人
            var i_to_p = new Dictionary<int, int>(n);
            for (var i = 0; i < cs1.Length; i++) {
                var p_i = Convert.ToInt32(cs1[i]);
                i_to_p.Add(i + 1, p_i);
            }

            // ゼッケン
            var cs2 = Console.ReadLine()?.Split(' ');
            if (cs2 == null) return;

            // key:Q_i, value: i  ゼッケン→ゼッケンを着けてる人
            var q_to_i = new Dictionary<int, int>(n);

            // key:i, value: Q_i  ゼッケンを着けてる人→ゼッケン
            var i_to_q = new Dictionary<int, int>(n);

            for (var i = 0; i < cs2.Length; i++) {
                var q_i = Convert.ToInt32(cs2[i]);
                q_to_i.Add(q_i, i + 1);
                i_to_q.Add(i + 1, q_i);
            }

            for (var i = 1; i <= n; i++) {
                var i_from_q = q_to_i[i];
                var p_from = i_to_p[i_from_q];
                Console.Write($"{(i == 1 ? "" : " ")}{i_to_q[p_from]}");
            }
            Console.WriteLine();
        }
    }
}
