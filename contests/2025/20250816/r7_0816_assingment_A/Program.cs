using System.Collections.Generic;

namespace r7_0816_assingment_A {
    internal class Program {
        /// <summary>
        /// A - AtCoder Language
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc419/tasks/abc419_a</remarks>
        static void Main() {
            var knownWords = new Dictionary<string, string> {
                {"red","SSS" }, {"blue","FFF" }, {"green","MMM" }
            };
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            Console.WriteLine(knownWords.ContainsKey(s) ? knownWords[s] : "Unknown");
        }
    }
}
