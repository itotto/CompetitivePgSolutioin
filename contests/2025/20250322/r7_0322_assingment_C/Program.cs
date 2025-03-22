using System.Collections.Generic;

namespace r7_0322_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Uniqueness
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc398/tasks/abc398_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var numPos = new Dictionary<int, int>();
            var numCount = new Dictionary<int, int>();
            var numInputs = Console.ReadLine()?.Split(' ');
            if (numInputs == null) return;

            for (var i = 0; i < numInputs.Length; i++) { 
                var num = Convert.ToInt32(numInputs[i]);
                if (!numPos.ContainsKey(num)) numPos.Add(num, i + 1);

                if (numCount.ContainsKey(num)) numCount[num]++;
                else numCount.Add(num, 1);
            }

            var maxNum = -1;
            foreach (var nc in numCount) {
                if (nc.Value != 1) continue;
                if (nc.Key > maxNum) maxNum = nc.Key;
            }
            Console.WriteLine(numPos.ContainsKey(maxNum) ? numPos[maxNum] : maxNum);
        }
    }
}
