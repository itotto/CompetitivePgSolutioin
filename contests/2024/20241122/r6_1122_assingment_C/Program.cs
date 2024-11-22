using System.Collections.Generic;

namespace r6_1122_assingment_C {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var slashPositions = new List<int>();
            for (var i = 0; i < s.Length; i++) {
                if (s[i] == '/') slashPositions.Add(i);
            }

            var maxLen = slashPositions.Count == 0 ? 0 : 1;
            var lastSlash = 0;
            foreach (var basePos in slashPositions) {
                var oneCount = 0;
                var twoCount = 0;

                // 左側の1を数える
                for (var i = basePos - 1; i >= lastSlash; i--) {
                    if (s[i] == '1') oneCount++;
                    else break;
                }

                // 右側のの2を数える
                for (var i = basePos + 1; i < s.Length; i++) {
                    if (s[i] == '2') twoCount++;
                    else break;
                }

                if (oneCount > 0 && twoCount > 0) {
                    var t_len = oneCount > twoCount ? twoCount * 2 + 1 : oneCount * 2 + 1;
                    if (t_len > maxLen) {
                        maxLen = t_len;
                    }
                }

                // 前回のスラッシュの位置を覚えておく
                lastSlash = basePos;
            }
            Console.WriteLine(maxLen);
        }
    }
}
