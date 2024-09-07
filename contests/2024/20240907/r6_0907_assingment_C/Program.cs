using System.Collections.Generic;

namespace r6_0907_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Word Ladder
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc370/tasks/abc370_c</remarks>
        static void Main() {
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            if (string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t)) return;
            var diff_1 = new Dictionary<int, char>(); // 先に変える
            var diff_2 = new Dictionary<int, char>(); // 後で変える
            for (var i = 0; i < s.Length; i++) {
                if (s[i] == t[i]) continue;
                if (s[i] > t[i]) diff_1.Add(i, t[i]);
                else diff_2.Add(i, t[i]);
            }

            var result = new List<string>();
            var s_copy = s.ToArray();
            // 小さくなる方は上から変える
            foreach (var d1 in diff_1) {
                s_copy[d1.Key] = d1.Value;
                result.Add(new string(s_copy));
            }

            // 大きくなる方は下から変える
            foreach (var d2_key in diff_2.Keys.Reverse()) {
                s_copy[d2_key] = diff_2[d2_key];
                result.Add(new string(s_copy));
            }

            // 結果
            Console.WriteLine(result.Count);
            foreach (var r in result) Console.WriteLine(r);
        }
    }
}
