using System.Collections.Generic;
using System.Text;

namespace r7_0222_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Colorful Bracket Sequence
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc394/tasks/abc394_d</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var pairs = new Dictionary<char, char> {
                {'(',')' },{'[',']' },{'<','>' }
            };

            var result = s.Length == 0;
            var removeIndex = new Dictionary<int, bool>();

            do {
                // 前回消すことになっているものがあればここで消す
                if (removeIndex.Count > 0) {
                    var wrk = new StringBuilder(s.Length);
                    for (var i = 0; i < s.Length; i++) {
                        if (!removeIndex.ContainsKey(i)) wrk.Append(s[i]);
                    }
                    if (wrk.Length == 0) {
                        result = true;
                        break;
                    }
                    s = wrk.ToString();
                    removeIndex.Clear();
                }
                var pos = 0;
                while (pos < s.Length - 1) {
                    var c = s[pos];
                    // かっこの左側の場合のみ処理
                    if (pairs.TryGetValue(c, out var pairBrackets)) {
                        var c_next = s[pos + 1];
                        if (pairBrackets == c_next) {
                            removeIndex.Add(pos, true);
                            removeIndex.Add(pos + 1, true);
                            pos += 2;
                            continue;
                        } else if (!pairs.ContainsKey(c_next)) {
                            pos += 2;
                            continue;
                        }
                    }
                    pos++;
                }
            } while (removeIndex.Count > 0);
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
