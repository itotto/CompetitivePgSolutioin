using System.Collections.Generic;
using System.Text;

namespace r7_0222_assingment_A {
    internal class Program {
        /// <summary>
        /// A - 22222
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc394/tasks/abc394_a</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            var result = new StringBuilder();

            foreach (var c in s) {
                if (c == '2') result.Append(c);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
