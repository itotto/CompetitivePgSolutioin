using System.Collections.Generic;

namespace r6_1228_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Operate 1
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc386/tasks/abc386_c</remarks>
        static void Main() {
            var k = Convert.ToInt32(Console.ReadLine());
            var s = Console.ReadLine();
            var t = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            if (string.IsNullOrEmpty(t)) return;

            var result = false;
            // 同じなら 0 でOK
            if (s == t) result = true;
            else {

                var isSame = true;
                var errorCnt = 0;
                var s_idx = 0;
                var t_idx = 0;

                // 長さに k より大きい差があるならもう無理
                switch (s.Length - t.Length) {
                    // 長さが同じ場合は 1文字まで変えられる
                    case 0:
                        for (var i = 0; i < s.Length; i++) {
                            if (s[i] != t[i]) {
                                if (++errorCnt > k) {
                                    isSame = false;
                                    break;
                                }
                            }
                        }
                        break;

                    // Sの方が短い場合は 1文字まで増やすことができる
                    case -1:
                        for (t_idx = 0; t_idx < t.Length; t_idx++) {
                            // 同じなら1文字ずらす
                            if (s[s_idx] == t[t_idx]) {
                                // Sの範囲外になる == errorCnt が 0なら最後を削るだけでいいからOK, 1なら削れないからNG
                                if (++s_idx >= s.Length && s_idx != t_idx) {
                                    isSame = errorCnt < k;
                                    break;
                                }

                                // 違ってたらそこに1文字追加する(同じ場所を次も比較する)
                            } else {
                                if (++errorCnt > k) {
                                    isSame = false;
                                    break;
                                }
                            }
                        }
                        break;

                    // Sの方が長い場合は 1文字だけ削ることができる
                    case 1:
                        for (t_idx = 0; t_idx < t.Length; t_idx++) {
                            // 違ってたらそこの1文字を削る
                            if (s[s_idx] != t[t_idx]) {
                                if (++errorCnt > k) {
                                    isSame = false;
                                    break;
                                }
                                // Sの次の文字と再度比較する
                                if (s[++s_idx] != t[t_idx]) {
                                    isSame = false;
                                    break;
                                }
                            }
                            // 次のインデックス
                            if (++s_idx >= s.Length) {
                                isSame = errorCnt < k;
                                break;
                            }
                        }
                        break;

                    default:
                        break;
                }
                if (isSame) result = true;
            }

            // 結果を表示
            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
