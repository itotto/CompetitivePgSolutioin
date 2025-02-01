using System.Collections.Generic;

namespace r7_0125_assingment_A {
    internal class Program {
        /// <summary>
        /// A - 12435
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc390/tasks/abc390_a</remarks>
        static void Main() {
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;
            var r = false;
            var isSwapped = false;

            var i = 0;
            while ( i < cs.Length) {
                var a_i = Convert.ToInt32(cs[i++]);
                // 順番どおりならOK
                if (a_i == i) continue;

                // 既に交換済みなら終了
                if (isSwapped) {
                    r = false;
                    break;
                }

                // 次の番号に一致するなら隣を確認
                if (a_i == i + 1) {
                    var a_i_1 = Convert.ToInt32(cs[i++]);

                    // 隣の番号と入れ替え可能ならOK
                    if (a_i_1 == i - 1) {
                        r = true;
                        isSwapped = true;
                        continue;
                    } else {
                        r = false;
                        break;
                    }

                } else {
                    break;
                }
            }

            Console.WriteLine(isSwapped && r ? "Yes" : "No");
        }
    }
}
