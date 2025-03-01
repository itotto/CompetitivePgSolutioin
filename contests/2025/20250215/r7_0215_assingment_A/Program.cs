using System.Collections.Generic;

namespace r7_0215_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Poisonous Oyster
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc393/tasks/abc393_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var s1 = conditions[0];
            var s2 = conditions[1];
            var result = 4;
            if (s1 == "sick") {
                if (s2 == "sick") result = 1;
                else result = 2;
            } else if (s2 == "sick") {
                result = 3;
            }
            Console.WriteLine(result);
        }
    }
}
