using System.Collections.Generic;

namespace r8_0418_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Mapping
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc454/tasks/abc454_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;

            var isDifferent = true;
            var f2m = new Dictionary<int, int>();
            for (var i = 0; i < conditions2.Length; i++) {
                var f = Convert.ToInt32(conditions2[i]);
                if (!f2m.ContainsKey(f)) f2m.Add(f, 1);
                else {
                    f2m[f]++;
                    isDifferent = false;
                }
            }

            Console.WriteLine(isDifferent ? "Yes" : "No");
            Console.WriteLine(f2m.Count == m ? "Yes" : "No");
        }
    }
}
