using System.Collections.Generic;
using System.Text;

namespace r8_0103_assingment_C {
    internal class Program {

        /// <summary>
        /// C - 2026
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var x2 = new List<int>();
            for (var i = 1; i <= n; i++) {
                var n2 = i * i;
                if (n2 >= n) break;
                x2.Add(n2);
            }

            var couples = new Dictionary<int, int>();
            for (var i = 0; i < x2.Count - 1; i++) {
                for (var j = i + 1; j < x2.Count; j++) {
                    var sum = x2[i] + x2[j];
                    if (sum > n) break;
                    if (couples.ContainsKey(sum)) couples[sum]++;
                    else couples.Add(sum, 1);
                }
            }

            var oneCountList = new List<int>();

            foreach (var c in couples) {
                if (c.Value == 1) oneCountList.Add(c.Key);
            }

            oneCountList.Sort();
            var result = new StringBuilder();

            if (oneCountList.Count > 1) {
                for (var i = 0; i < oneCountList.Count; i++) {
                    result.Append($"{oneCountList[i]} ");
                }
                result.Remove(result.Length - 1, 1);
            }

            Console.WriteLine(oneCountList.Count);
            Console.WriteLine(result);
        }
    }
}
