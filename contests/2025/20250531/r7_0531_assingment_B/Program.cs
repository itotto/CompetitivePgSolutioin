using System.Collections.Generic;
using System.Text;

namespace r7_0531_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Compression
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc408/tasks/abc408_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var data = new Dictionary<int, bool>();
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < conditions.Length; i++) {
                var v = Convert.ToInt32(conditions[i]);
                if (!data.ContainsKey(v)) data.Add(v, true);
            }

            var sorted = data.Keys.OrderBy(x => x).ToList();
            var result = new StringBuilder();
            result.AppendLine(sorted.Count.ToString());
            if (sorted.Count > 0) {
                result.Append(sorted[0]);
                for (var i = 1; i < sorted.Count; i++) {
                    result.Append($" {sorted[i]}");
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
