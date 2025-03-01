using System.Collections.Generic;

namespace r7_0301_assingment_C {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var minLen = int.MaxValue;

            // その数値が出てきた最後の場所(key:数値, value:位置)
            var lastPositions = new Dictionary<int, int>(n);

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < n; i++) {
                var a_i = Convert.ToInt32(conditions[i]);
                if (lastPositions.ContainsKey(a_i)) {
                    var len = i - lastPositions[a_i] + 1;
                    if (minLen > len) minLen = len;
                    lastPositions[a_i] = i;
                } else {
                    lastPositions.Add(a_i, i);
                }
            }

            Console.WriteLine(minLen == int.MaxValue ? -1 : minLen);
        }
    }
}
