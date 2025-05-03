using System.Collections.Generic;

namespace r7_0503_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Not Found
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc404/tasks/abc404_a</remarks>
        static void Main() {
            var lowers = new List<char>();
            for (var i = 'a'; i <= 'z'; i++) {
                lowers.Add(i);
            }

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            foreach (var c in s) {
                if (lowers.Contains(c)) lowers.Remove(c);
            }
            Console.WriteLine(lowers[0]);
        }
    }
}
