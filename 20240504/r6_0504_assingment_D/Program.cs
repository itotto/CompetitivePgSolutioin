using System.Collections.Generic;

namespace r6_0504_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Permutation Subsequence
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc352/tasks/abc352_d</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var k = Convert.ToInt32(cs1[1]);

            // 入力
            var inputData = Console.ReadLine()?.Split(' ');
            if (inputData == null) return;
            var sequence = new int[n + 1];
            sequence[0] = 0;
            for (var i = 1; i <= n; i++) sequence[i] = Convert.ToInt32(inputData[i - 1]);
        }
    }
}
