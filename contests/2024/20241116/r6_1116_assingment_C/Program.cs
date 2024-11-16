using System.Collections.Generic;
using System.Text;

namespace r6_1116_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Move Segment
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc380/tasks/abc380_c</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var n = Convert.ToInt32(inputs[0]);
            var k = Convert.ToInt32(inputs[1]);

            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;

            // 開始文字が 0 かどうか
            var lastChar = ' ';

            // 塊
            var cluster = new StringBuilder();

            var clusters = new List<string>();
            for (var i = 0; i < n; i++) {
                var currentChar = line[i];
                // 同じだったら塊に追加
                if (currentChar == lastChar) {
                    cluster.Append(currentChar);
                } else {
                    clusters.Add(cluster.ToString());
                    cluster.Clear();
                    cluster.Append(currentChar);
                    lastChar = currentChar;
                }
            }

            // 最後の分が入ってなかったら追加
            if (cluster.Length > 0) {
                clusters.Add(cluster.ToString());
            }

            var kIndex = line[0] == '0' ? 2 * k : 2 * k - 1;

            clusters[kIndex - 2] += clusters[kIndex];
            clusters.RemoveAt(kIndex);

            for (var i = 1; i < clusters.Count; i++) {
                Console.Write(clusters[i]);
            }
            Console.WriteLine();
        }
    }
}
