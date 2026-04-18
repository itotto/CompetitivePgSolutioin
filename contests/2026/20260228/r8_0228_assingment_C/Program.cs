using System.Collections.Generic;

namespace r8_0228_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Insert and Erase A
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc447/tasks/abc447_c</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            var t = Console.ReadLine();
            if (string.IsNullOrEmpty(t)) return;

            var result = GetCount(s, t);
            Console.WriteLine(result);
        }

        static int GetCount(string s, string t) {
            // 同じなら 0
            if (s == t) return 0;

            var new_s = s.Replace("A", "");
            var new_t = t.Replace("A", "");

            // A以外の文字の配置が違うなら -1
            if (new_s != new_t) return -1;

            var result = 0;
            var countOfA_s = new List<int>();
            var countOfA_t = new List<int>();

            var workCount = 0;
            foreach (var c in s) {
                if (c == 'A') workCount++;
                else {
                    countOfA_s.Add(workCount);
                    workCount = 0;
                }
            }
            countOfA_s.Add(workCount);

            workCount = 0;
            foreach (var c in t) {
                if (c == 'A') workCount++;
                else {
                    countOfA_t.Add(workCount);
                    workCount = 0;
                }
            }
            countOfA_t.Add(workCount);

            if (countOfA_s.Count > countOfA_t.Count)
                countOfA_t.Add(0);
            else if (countOfA_s.Count < countOfA_t.Count)
                countOfA_s.Add(0);

            for (var i = 0; i < countOfA_s.Count; i++) {
                var countA_s = countOfA_s[i];
                var countA_t = countOfA_t[i];
                result += (countA_s > countA_t)
                            ? countA_s - countA_t
                            : countA_t - countA_s;
            }
            return result;
        }
    }
}
