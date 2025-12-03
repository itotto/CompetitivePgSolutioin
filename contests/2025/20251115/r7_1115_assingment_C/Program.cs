using System.Collections.Generic;

namespace r7_1115_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Candy Tribulation 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc432/tasks/abc432_c</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var smallerWeight = Convert.ToInt32(conditions[1]);
            var largerWight   = Convert.ToInt32(conditions[2]);

            var weightDiff = largerWight - smallerWeight;

            var data = new List<int>();
            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            for (var i = 0; i < conditions2.Length; i++) {
                data.Add(Convert.ToInt32(conditions2[1]));
            }
            data.Sort();

            var minCount = data[0];
            var maxCount = data[data.Count - 1];

            // 入力例3パターン
            if (minCount == maxCount) {
                Console.WriteLine((long)minCount * n);
                return;
            }

            long result = -1;

            // 入力例2パターンをはじく
            if ((long)minCount * largerWight > (long)maxCount * smallerWeight) {

            }


            Console.WriteLine(result);
        }
    }
}
