using System.Collections.Generic;

namespace r7_0111_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Various Kagamimochi
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc388/tasks/abc388_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            //key:値, 半分以下の数
            var x = new Dictionary<int, int>();

            var lastFound = 0;

            var cCount = 0;

            // 入力
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < n; i++) {
                var mochiSize = Convert.ToInt32(conditions[i]);
                var doubleSize = mochiSize * 2;
                //var halfSize = mochiSize / 2;

                for (var j = mochiSize; j >= lastFound; j--) {
                    if (!x.ContainsKey(j)) continue;
                    cCount += x[j];
                    lastFound = j;
                    break;
                }

                if (x.ContainsKey(doubleSize)) x[doubleSize] = i + 1;
                else x.Add(doubleSize,i + 1);
            }


            Console.WriteLine(cCount);
        }
    }
}
