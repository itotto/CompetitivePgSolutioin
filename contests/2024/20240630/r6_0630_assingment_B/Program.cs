using System.Collections.Generic;
using System.Text;

namespace r6_0630_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Vertical Reading
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc360/tasks/abc360_b</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var s = inputs[0];
            var t = inputs[1];

            var result = false;
            // w は Sの長さ未満なので S.Length -1 ～ 1まで確認する
            for (var w = s.Length - 1; w >= 1; w--) {
                var wCount = s.Length / w;

                // SをW文字数単位で分割
                var wList = new List<string>();
                var leftLen = s.Length;
                for (var i = 0; i <= wCount; i++) {
                    wList.Add(s.Substring(w * i, leftLen > w ? w : leftLen));
                    leftLen -= w;
                    if (leftLen <= 0) break;
                }

                for (var c = w; c >= 1; c--) {
                    var concatStr = new StringBuilder();
                    foreach (var wc in wList) {
                        if (wc.Length < c) continue;
                        concatStr.Append(wc[c - 1]);
                    }
                    if (concatStr.ToString() == t) {
                        result = true;
                        break;
                    }
                }
                if (result) break;
            }
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
