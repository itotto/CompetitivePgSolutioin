using System.Collections.Generic;

namespace r7_0322_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Doors in the Center
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc398/tasks/abc398_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            if (n == 1) {
                Console.WriteLine("=");
            } else if (n == 2) {
                Console.WriteLine("==");
            } else {
                var halfLen = n / 2;
                var halfStr = new string('-', n % 2 == 0 ? halfLen -1 : halfLen);
                var centerChars = n % 2 == 0 ? "==" : "=";
                Console.WriteLine($"{halfStr}{centerChars}{halfStr}");
            }
        }
    }
}
