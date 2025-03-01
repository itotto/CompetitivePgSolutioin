using System.Collections.Generic;

namespace r7_0301_assingment_B {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            // 初期化
            var result = new char[n, n];
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    result[i, j] = ' ';
                }
            }

            // 処理
            for (var i = 1; i <= n; i++) {
                var j = n + 1 - i;
                if (i <= j) {
                    var c = i % 2 == 0 ? '.' : '#';
                    for (var y = i - 1; y <= j - 1; y++) {
                        for (var x = i - 1; x <= j - 1; x++) {
                            result[y, x] = c;
                        }
                    }
                }
            }

            // 結果を表示
            for (var i = 0; i < n; i++) {
                for (var j = 0; j < n; j++) {
                    Console.Write(result[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
