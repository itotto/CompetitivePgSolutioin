using System.Collections.Generic;

namespace r7_0125_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Geometric Sequence
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc390/tasks/abc390_b</remarks>
        static void Main() {
            _ = Convert.ToInt32(Console.ReadLine());
            var sequence = Console.ReadLine()?.Split(' ');
            if (sequence == null) return;
            var isGeometoriced = sequence.Length == 2;

            if (!isGeometoriced) {
                isGeometoriced = true;
                var a_1 = Convert.ToInt32(sequence[0]);
                var beforeV = Convert.ToInt32(sequence[1]);

                double ratio = beforeV / a_1;

                for (var i = 2; i < sequence.Length; i++) {
                    var a_i = Convert.ToInt32(sequence[i]);
                    double currentRatio = a_i / beforeV;

                    if (currentRatio - ratio < 0.01 || ratio - currentRatio < 0.01) {
                        isGeometoriced = false;
                        break;
                    }
                    beforeV = a_i;
                }
            }
            Console.WriteLine(isGeometoriced ? "Yes" : "No");
        }
    }
}
