using System.Collections.Generic;

namespace r7_1025_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Odd One Subsequence
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc429/tasks/abc429_c</remarks>
        static void Main() {
            var totalCount = Convert.ToInt32(Console.ReadLine());

            var numbers = new Dictionary<string, int>();

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < conditions.Length; i++) {
                if (numbers.ContainsKey(conditions[i])) numbers[conditions[i]]++;
                else numbers.Add(conditions[i], 1);
            }

            long count = 0;
            foreach (var n in numbers) {
                if (n.Value <= 1) continue;

                // n.Value:個数
                // n.Value から2個を選ぶ組み合わせを計算
                long combinationCount = 1; // ここを計算する
                if (n.Value >= 3) {
                    combinationCount = Combination2(n.Value);
                }

                // 組み合わせと残った数の組み合わせを計算
                var leftCount = totalCount - n.Value;
                count += leftCount * combinationCount;
            }
            Console.WriteLine(count);
        }

        static Dictionary<int, long> _calculated = new Dictionary<int, long>();

        static long Combination2(int n) {
            if (_calculated.ContainsKey(n)) return _calculated[n];

            long result = 1;

            for (var i = 0; i < 2; i++) {
                result = result * (n - i) / (i + 1);
            }

            _calculated.Add(n, result);
            return result;
        }
    }
}
