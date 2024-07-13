using System.Collections.Generic;

namespace r6_0706_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Insert 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc361/tasks/abc361_a</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var k = Convert.ToInt32(cs1[1]);
            var x = Convert.ToInt32(cs1[2]);

            var cs2 = Console.ReadLine()?.Split(' ');
            if (cs2 == null) return;
            var result = cs2.ToList();
            result.Insert(k, x.ToString());
            Console.Write(result[0]);
            for(var i = 1; i< result.Count; i++) Console.Write($" {result[i]}");
            Console.WriteLine();
        }
    }
}
