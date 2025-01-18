using System.Collections.Generic;
using System.Text;

namespace r7_0118_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Snake Queue
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc389/tasks/abc389_c</remarks>
        static void Main() {
            var queryCount = Convert.ToInt32(Console.ReadLine());

            int offsetCount = 0; // へびが抜けた回数
            long offsetLength = 0; // へびが抜けてずれた長さ

            long totalLen = 0;

            // へびの位置(key:追加された順番, value:位置)
            var snakePositions = new Dictionary<int, long>();
            var snakeLengths = new Dictionary<int, int>();

            var result = new StringBuilder();

            for (var i = 0; i < queryCount; i++) {
                var cs = Console.ReadLine()?.Split(' ');
                if (cs == null) return;
                var qOrder = Convert.ToInt32(cs[0]);

                switch (qOrder) {
                    case 1:
                        var snakeLen = Convert.ToInt32(cs[1]);
                        snakePositions.Add(snakePositions.Count + 1, totalLen);
                        snakeLengths.Add(snakeLengths.Count + 1, snakeLen);
                        totalLen += snakeLen;
                        break;

                    case 2:
                        //offsetLength += snakePositions[offsetCount + 1];
                        offsetLength += snakeLengths[offsetCount + 1];
                        offsetCount++;
                        break;

                    case 3:
                        var k = Convert.ToInt32(cs[1]);
                        result.AppendLine($"{snakePositions[k + offsetCount] - offsetLength}");
                        break;
                }
            }
            if (result.Length > 0) {
                Console.WriteLine(result.ToString());
            }
        }
    }
}
