using System.Text;
using System.Collections.Generic;

namespace r8_0613_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Secret Numbers 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc462/tasks/abc462_a</remarks>
        static void Main() {
            var nums = new HashSet<char>() { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', };
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var result = new StringBuilder();
            foreach (var c in s) {
                if (nums.Contains(c)) result.Append(c);
            }

            Console.WriteLine(result);
        }
    }
}
