using System.Collections.Generic;

namespace r6_1012_assingment_D {
    internal class Program {
        /// <summary>
        /// D - ABA
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc375/tasks/abc375_d</remarks>
        static void Main() {
            var str = Console.ReadLine();
            if (string.IsNullOrEmpty(str)) return;

            var charCount = new Dictionary<char, int>();
            var charCount_NC = new Dictionary<char, int>();

            var lastChar = '?';
            for (var i = 0; i < str.Length; i++) {
                var tc = str[i];
                if (charCount.ContainsKey(tc)) charCount[tc]++;
                else charCount.Add(tc, 1);

                if (lastChar != tc) {
                    if (charCount_NC.ContainsKey(tc)) charCount_NC[tc]++;
                    else charCount_NC.Add(tc, 1);
                }
                lastChar = tc;
            }

            long cnt = 0;
            if (str.Length >= 3) {
                for (var i = 0; i < str.Length - 2; i++) {
                    var tc = str[i]; // 見つけたい文字
                    charCount[tc]--; // 自分を引く
                    if (charCount[tc] <= 0) continue; // もう残ってなければ中止
                    var maxCnt = charCount[tc];
                    for (var j = i + 2; j < str.Length; j++) {
                        if (tc == str[j]) {
                            cnt += j - i - 1;
                            if (--maxCnt <= 0) break;
                        }
                    }
                }
            }
            Console.WriteLine(cnt);
        }
    }
}
