using System.Collections.Generic;
using System.Text;

namespace r7_0816_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Get Min
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc419/tasks/abc419_b</remarks>
        static void Main() {
            var q = Convert.ToInt32(Console.ReadLine());

            var result = new StringBuilder();
            var bags = new List<int>();
            for (var i = 0; i < q; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                if (conditions.Length == 2) {
                    bags.Add(Convert.ToInt32(conditions[1]));
                    bags.Sort();
                } else {
                    result.AppendLine(bags[0].ToString());
                    bags.RemoveAt(0);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
