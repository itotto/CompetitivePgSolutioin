using System.Collections.Generic;

namespace r7_0830_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Alternated
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc421/tasks/abc421_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            // Aの場所を確認
            var a_pos = new List<int>(n);
            for (var i = 0; i < s.Length; i++) {
                if (s[i] == 'A') a_pos.Add(i + 1);
            }

            // aを奇数に配置したとき
            var moveCount_Odd = 0;

            // aを偶数に配置したとき
            var moveCount_Even = 0;

            if (s.Length > 2) {
                for (var i = 1; i <= a_pos.Count; i++) {
                    var p = a_pos[i - 1];
                    var exptected_even = 2 * i;
                    var exptected_odd = exptected_even - 1;
                    moveCount_Even += p > exptected_even ? p - exptected_even : exptected_even - p;
                    moveCount_Odd += p > exptected_odd ? p - exptected_odd : exptected_odd - p;
                }
            }

            // 結果を表示
            Console.WriteLine(moveCount_Even > moveCount_Odd ? moveCount_Odd : moveCount_Even);
        }
    }
}
