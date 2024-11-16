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
            var isZeroStart = line[0] == '0';
            var lastChar = line[0];

            // 塊
            var cluster = new StringBuilder();
            cluster.Append(lastChar);

            var oneClusters = new List<string>();
            var zeroClusters = new List<string>();
            for (var i = 1; i < n; i++) {
                var currentChar = line[i];
                // 同じだったら塊に追加
                if (currentChar == lastChar) {
                    cluster.Append(currentChar);
                } else {
                    if (lastChar == '0') zeroClusters.Add(cluster.ToString());
                    else oneClusters.Add(cluster.ToString());

                    cluster.Clear();
                    cluster.Append(currentChar);
                    lastChar = currentChar;
                }
            }

            // 最後の分が入ってなかったら追加
            if (cluster.Length > 0) {
                if (line[line.Length - 1] == '0') zeroClusters.Add(cluster.ToString());
                else oneClusters.Add(cluster.ToString());
            }

            oneClusters[k - 2] += oneClusters[k - 1];
            oneClusters.RemoveAt(k - 1);



        }
    }
}
