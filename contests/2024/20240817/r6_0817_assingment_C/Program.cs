using System.Collections.Generic;
using System.Text;

namespace r6_0817_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Enumerate Sequences
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc367/tasks/abc367_c</remarks>
        static void Main() {
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;
            var lengthOfArray = Convert.ToInt32(cs[0]);
            var baseNumber = Convert.ToInt32(cs[1]);

            var maxOfDigit = Console.ReadLine()?.Split(' ');
            if (maxOfDigit == null) return;

            // 各桁の最大値を取得
            var maxOfDigitsInt = new int[lengthOfArray];
            var maxStr = new StringBuilder();
            for (var i = 0; i < maxOfDigitsInt.Length; i++) {
                maxOfDigitsInt[i] = Convert.ToInt32(maxOfDigit[i]);
                maxStr.Append(maxOfDigit[i]);
            }

            // 最大値
            var maxNumber = Convert.ToInt32(maxStr.ToString());

            // 最小値
            var minNumber = Convert.ToInt32(new string('1', lengthOfArray));

            var result = new List<string>();
            for (var i = minNumber; i <= maxNumber; i++) {
                if (i % baseNumber != 0) continue;
                var s = i.ToString();
                var isValid = true;
                for (var j = 0; j < lengthOfArray; j++) {
                    if (Convert.ToInt32(s[j].ToString()) > maxOfDigitsInt[j]) { isValid = false; break; }
                }
                if (!isValid) continue;
                result.Add(s);
            }

            // 並び順を変える
            result.Sort((x,y) => x.CompareTo(y));

            // 出力
            if (result.Count > 0) {
                foreach (var s in result) {
                    Console.Write(s[0]);
                    for (var i = 1; i < s.Length; i++) {
                        Console.Write($" {s[i]}");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
