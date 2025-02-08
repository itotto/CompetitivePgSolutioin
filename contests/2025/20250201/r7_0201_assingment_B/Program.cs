using System.Collections.Generic;

namespace r7_0201_assingment_B {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var condtions1 = Console.ReadLine()?.Split(' ');
            if (condtions1 == null) return;
            var n = Convert.ToInt32(condtions1[0]);
            var m = Convert.ToInt32(condtions1[1]);

            var s_matrix = new char[n, n];
            var t_matrix = new char[m, m];

            // Sを構築
            for (var i = 0; i < n; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var j = 0; j < n; j++) {
                    s_matrix[i, j] = line[j];
                }
            }

            // Tを構築
            for (var i = 0; i < m; i++) {
                var line = Console.ReadLine();
                if (string.IsNullOrEmpty(line)) continue;
                for (var j = 0; j < m; j++) {
                    t_matrix[i, j] = line[j];
                }
            }

            // Sの色ごとの位置情報をコピー
            var start_t = t_matrix[0, 0];

            var start_y = -1;
            var start_x = -1;
            for (var i = 0; i <= n - m; i++) {
                for (var j = 0; j <= n - m; j++) {
                    var s = s_matrix[i, j];
                    // 最初のマスが違ってたら以降は処理しない
                    if (s_matrix[i, j] != start_t) continue;

                    var isMatched = true;
                    for (var k = 0; k < m; k++) {
                        for (var l = 0; l < m; l++) {
                            if (s_matrix[i + k, j + l] != t_matrix[k, l]) {
                                isMatched = false;
                                break;
                            }
                        }
                        if (!isMatched) break;
                    }
                    if (!isMatched) continue;

                    start_y = i + 1;
                    start_x = j + 1;
                }
            }

            Console.WriteLine($"{start_y} {start_x}");
        }
    }
}
