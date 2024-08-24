using System.Collections.Generic;
using System.Text;

namespace r6_0817_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Cut .0
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc367/tasks/abc367_b</remarks>
        static void Main() {
            var x = Console.ReadLine();
            if (string.IsNullOrEmpty(x)) return;

            var result = new StringBuilder(x);
            while (result[result.Length -1] == '0' || result[result.Length -1] == '.' ) {
                var isLast = result[result.Length - 1] == '.';
                result.Remove(result.Length -1, 1);
                if (isLast) break;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
