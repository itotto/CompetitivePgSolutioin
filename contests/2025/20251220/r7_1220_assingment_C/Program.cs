using System.Collections.Generic;

namespace r7_1220_assingment_C {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var testCaseCount = Convert.ToInt32(Console.ReadLine());

            var result = new List<long>();
            for (var i = 0; i < testCaseCount; i++) {
                result.Add(TestCase());
            }

            // 答えを出す
            foreach (var r in result) Console.WriteLine(r);
        }

        static long TestCase() {
            var n = Convert.ToInt32(Console.ReadLine());

            long result = 0;
            var total_Weight = 0;
            var total_Power = 0;
            // 0:weight, 1:power, 2: diff (weight - power)
            var targetData = new List<int[]>();
            for (var i = 0; i < n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) continue;
                var w = Convert.ToInt32(conditions[0]);
                var p = Convert.ToInt32(conditions[1]);
            }

            return result;
        }
    }
}
