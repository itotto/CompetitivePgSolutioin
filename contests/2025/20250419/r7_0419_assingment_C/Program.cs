using System.Collections.Generic;
using System.Text;

namespace r7_0419_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Dislike Foods
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc402/tasks/abc402_c</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            // key:foodno value: (key=fno, value= key_ingredient, value:dummy)
            var foods = new Dictionary<int, Dictionary<int, bool>>();

            // initialize
            for (var i = 1; i <= n; i++) {
                foods.Add(i, new Dictionary<int, bool>());
            }

            for (var i = 1; i <= m; i++) {
                var food = Console.ReadLine()?.Split(' ');
                if (food == null) continue;

                for (var j = 1; j < food.Length; j++) {
                    var fno = int.Parse(food[j]);
                    foods[fno].Add(i, true);
                }
            }

            // B_n
            var bs = new List<int>();
            var bInputs = Console.ReadLine()?.Split(' ');
            if (bInputs == null) return;
            for (var i = 0; i < bInputs.Length; i++) {
                bs.Add(int.Parse(bInputs[i]));
            }

            var result = new StringBuilder();

            // key:day , value:count
            var overcomeCount = new Dictionary<int, int>();
            for (var i = bs.Count - 1; i >= 0; i--) {
                overcomeCount.Add(i + 1, foods[bs[i]].Count);
            }

            var totalCount = 0;
            for (var i = 1; i <= n; i++) {
                if (overcomeCount.ContainsKey(i)) {
                    totalCount += overcomeCount[i];
                }
                result.AppendLine(totalCount.ToString());
            }

            Console.WriteLine(result.ToString());
        }
    }
}
