using System.Collections.Generic;
using System.Text;

namespace r7_0222_assingment_B {
    internal class Program {
        /// <summary>
        /// B - cat
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc394/tasks/abc394_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var lenToV = new Dictionary<int, string>();
            var lenghs = new List<int>();
            for( var i = 0; i < n;i++) {
                var s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) return;
                lenghs.Add(s.Length);
                lenToV.Add(s.Length, s);
            }
            lenghs.Sort((x, y) => x - y);
            var result = new StringBuilder();

            foreach (var l in lenghs) {
                result.Append(lenToV[l]);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
