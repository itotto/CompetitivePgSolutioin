using System.Collections.Generic;
using System.Text;

namespace r7_1018_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Most Frequent Substrings
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc428/tasks/abc428_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt32(conditions[1]);

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var maxCount = 0;
            var words = new Dictionary<string, int>();
            for (var i = 0; i <= n - k; i++) {
                var w = s.Substring(i, k);
                if (words.ContainsKey(w)) words[w]++;
                else words.Add(w, 1);
                if (words[w] > maxCount) maxCount = words[w];
            }

            var wordList = new List<string>();

            foreach (var w in words) {
                if (w.Value == maxCount) wordList.Add(w.Key);
            }
            wordList.Sort();

            var result = new StringBuilder();
            foreach (var w in wordList) result.Append($"{w} ");

            if (result.Length > 0) result.Remove(result.Length - 1, 1);
            Console.WriteLine(maxCount);
            Console.WriteLine(result);
        }
    }
}
