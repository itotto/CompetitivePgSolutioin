using System.Collections.Generic;
using System.Text;

namespace r6_0810_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Vertical Writing 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc366/tasks/abc366_b</remarks>
        static void Main() {
            var countOfWords = Convert.ToInt32(Console.ReadLine());

            // データを入力
            var m = -1;
            var s_i = new List<string>();
            for (var i = 0; i < countOfWords; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                if (m < line.Length) m = line.Length;
                s_i.Add(line);
            }
            //s_i.Sort((x, y) => x.Length - y.Length);
            s_i.Reverse();

            var result = new List<string>();
            for (var i = 1; i <= m; i++) {
                var d = new StringBuilder();
                var found = false;
                for (var j = s_i.Count - 1; j >= 0; j--) {
                    if (s_i[j].Length < i) {
                        //d.Append(found ? '*' : ' ');
                        d.Insert(0, found ? '*' : ' ');
                    } else {
                        //d.Append(s_i[j][i - 1]);
                        d.Insert(0, s_i[j][i - 1]);
                        if (!found) found = true;
                    }
                }
                result.Add(d.ToString());
            }

            // 結果を出力
            foreach (var r in result) Console.WriteLine(r);
        }
    }
}
