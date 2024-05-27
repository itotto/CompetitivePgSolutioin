using System.Collections.Generic;

namespace r6_0525_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Piano 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc355/tasks/abc355_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            // 並び替える配列を格納
            var c_i = new List<int>();

            var a_i_d = new Dictionary<int, bool>(n);

            // 入力1(a_i)
            var a_i_str = Console.ReadLine()?.Split(' ');
            if (a_i_str == null) return;
            foreach (var a_i in a_i_str) {
                var v = Convert.ToInt32(a_i);
                c_i.Add(v);
                a_i_d.Add(v, true);
            }

            // 入力2(b_i)
            var b_i_str = Console.ReadLine()?.Split(' ');
            if (b_i_str == null) return;
            foreach (var b_i in b_i_str) {
                c_i.Add(Convert.ToInt32(b_i));
            }

            // 並び替え
            c_i.Sort((x, y) => x - y);

            var result = false;
            var lastIsA = a_i_d.ContainsKey(c_i[0]);
            for (var i = 1; i < m + n; i++) {
                //foreach (var c in c_i) {
                //var currentIsA = a_i_d.ContainsKey(c);
                var currentIsA = a_i_d.ContainsKey(c_i[i]);
                if (lastIsA) {
                    // A - A ならおしまい
                    if (currentIsA) {
                        result = true;
                        break;
                    }
                }
                lastIsA = currentIsA;
            }

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
