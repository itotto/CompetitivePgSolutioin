using System.Collections.Generic;

namespace r7_0315_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Variety Split Easy
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc397/tasks/abc397_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // key:分割する位置、value:その時点での左側の文字種類数
            var leftPosCharCount = new Dictionary<int, int>();

            // key:数字、value:文字数
            var totalCharCount = new Dictionary<int, int>();

            var data = new int[n];
            var condition = Console.ReadLine()?.Split(' ');
            if (condition == null) return;
            for (var i = 0; i < condition.Length; i++) {
                var d = Convert.ToInt32(condition[i]);
                data[i] = d;
                if (totalCharCount.ContainsKey(d)) {
                    totalCharCount[d]++;
                } else {
                    totalCharCount.Add(d, 1);
                }
                // この時点での左側の状態を入れておく
                leftPosCharCount.Add(i, totalCharCount.Count);
            }

            // key:分割する位置、value:その時点での右側の文字種類数
            var rightCharCount = new Dictionary<int, int>(totalCharCount);
            var rcnt = rightCharCount.Count;

            // 最大値
            var max = -1;

            for (var i = 0; i < condition.Length; i++) {
                var d = data[i];
                rightCharCount[d]--;
                if (rightCharCount[d] == 0) rcnt--;

                var sum = leftPosCharCount[i] + rcnt;
                if (sum > max) {
                    max = sum;
                    if (max == totalCharCount.Count * 2) break; // 無い方が良ければ消す
                }
            }

            Console.WriteLine(max);
        }
    }
}
