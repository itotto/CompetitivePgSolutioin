using System.Collections.Generic;
using System.Text;

namespace r7_0927_assingment_B {
    internal class Program {

        /// <summary>
        /// B - Find Permutation 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc425/tasks/abc425_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var numbers = new Dictionary<int, bool>(capacity: n);
            for (var i = 1; i <= n; i++) numbers.Add(i, false);

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var data = new List<int>(capacity: n);

            var result = true;
            for (var i = 0; i < conditions.Length; i++) {
                var num = Convert.ToInt32(conditions[i]);
                data.Add(num);
                if (num == -1) continue;
                if (numbers.ContainsKey(num)) numbers.Remove(num);
                else result = false;
            }

            Console.WriteLine(result ? "Yes" : "No");
            if (result) {
                var replaceNums = new Queue<int>(capacity: numbers.Count);
                foreach (var k in numbers.Keys) replaceNums.Enqueue(k);

                var permutation = new StringBuilder();
                foreach (var d in data) {
                    if (d == -1) permutation.Append($"{replaceNums.Dequeue()} ");
                    else permutation.Append($"{d} ");
                }
                permutation.Remove(permutation.Length - 1, 1);

                Console.WriteLine(permutation.ToString());
            }

        }
    }
}
