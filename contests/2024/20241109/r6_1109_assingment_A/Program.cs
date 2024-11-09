using System.Collections.Generic;

namespace r6_1109_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Cyclic
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc379/tasks/abc379_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var a = n / 100;
            var b = (n % 100) / 10;
            var c = n % 10;

            Console.WriteLine($"{b}{c}{a} {c}{a}{b}");
            //Console.WriteLine($"a={a}\tb={b}\tc={c}");
            //Console.ReadLine();
        }
    }
}
