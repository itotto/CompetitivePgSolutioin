using System.Collections.Generic;
using System.Text;

namespace r6_0601_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Subsegment Reverse 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc356/tasks/abc356_a</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var n = Convert.ToInt32(inputs[0]);
            var l = Convert.ToInt32(inputs[1]);
            var r = Convert.ToInt32(inputs[2]);

            var result = new StringBuilder();
            var data = new List<int>(n);
            for (var i = 1; i <= n; i++) {
                //if (l <= i && i <= r) { result.Append($"{(n - i)} "); }
                if (l <= i && i <= r) { result.Append($"{r - (i - l)} "); } else result.Append($"{i} ");
            }

            Console.WriteLine(result.ToString().Substring(0, result.Length - 1));
        }
    }
}
