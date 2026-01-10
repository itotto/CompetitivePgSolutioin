using System.Collections.Generic;
using System.Text;

namespace _4_RemoveIt {
    internal class Program {
        /// <summary>
        /// B - Remove It
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc191/tasks/abc191_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var x = Convert.ToInt32(conditions[1]);


            var a = Console.ReadLine()?.Split(' ');
            if (a == null) return;

            var result = new StringBuilder();

            for (var i = 0; i < n; i++) {
                var a_i = Convert.ToInt32(a[i]);
                if (a_i == x) continue;
                result.Append($"{a_i} ");
            }

            if (result.Length > 0) result.Remove(result.Length - 1, 1);

            Console.WriteLine(result);
        }
    }
}
