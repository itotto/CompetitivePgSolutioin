using System.Collections.Generic;
using System.Text;

namespace r7_1115_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Permute to Minimize 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc432/tasks/abc432_b</remarks>
        static void Main() {
            //var x = Convert.ToInt32(Console.ReadLine());
            var x = Console.ReadLine();
            if (string.IsNullOrEmpty(x)) return;

            var charCount = new Dictionary<char, int> {
                {'0',0 }, {'1',0 }, {'2',0 }, {'3',0 }, {'4',0 },
                {'5',0 }, {'6',0 }, {'7',0 }, {'8',0 }, {'9',0 },
            };

            for (var i = 0; i < x.Length; i++) {
                charCount[x[i]]++;
            }

            var minV = '1';
            for (var i = 1; i <= 9; i++) {
                if (charCount[minV] > 0) break;
                else minV++;
            }
            if (minV > '9') return;

            // 先頭だけは1文字足す
            var result = new StringBuilder();
            result.Append(minV);
            charCount[minV]--;

            for (var v = '0'; v <= '9'; v++) {
                if (charCount[v] == 0) continue;
                result.Append(new string(v, charCount[v]));
            }

            Console.WriteLine(result);
        }
    }
}
