using System.Collections.Generic;

namespace r7_1213_assingment_C {
    internal class Program {
        /// <summary>
        /// C - 2x2 Placing
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc436/tasks/abc436_c</remarks>
        static void Main() {
            string getkey(int i, int j) => $"{i}_{j}";

            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            var result = new Dictionary<string, bool>();

            var count = 0;
            for (var loop = 0; loop < m; loop++) {
                var condition = Console.ReadLine()?.Split(' ');
                if (condition == null) return;
                var r = Convert.ToInt32(condition[0]);
                var c = Convert.ToInt32(condition[1]);

                var key1 = getkey(r, c);
                var key2 = getkey(r + 1, c);
                var key3 = getkey(r, c + 1);
                var key4 = getkey(r + 1, c + 1);
                if (!result.ContainsKey(key1) &&
                    !result.ContainsKey(key2) &&
                    !result.ContainsKey(key3) &&
                    !result.ContainsKey(key4)) {
                    result.Add(key1, true);
                    result.Add(key2, true);
                    result.Add(key3, true);
                    result.Add(key4, true);
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
