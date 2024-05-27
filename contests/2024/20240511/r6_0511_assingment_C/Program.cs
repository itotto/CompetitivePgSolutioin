using System.Collections.Generic;

namespace r6_0511_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Sigma Problem
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc353/tasks/abc353_c</remarks>
        static void Main() {
            // 基準値
            const int BASEVALUE = 100000000;

            var n = Convert.ToInt32(Console.ReadLine());
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;


            // 全部数値に変換して保持
            var a_i = new uint[n];
            for (var i = 0; i < cs.Length; i++) {
                a_i[i] = Convert.ToUInt32(cs[i]);
            }

            // 並び替え
            Array.Sort(a_i);

            // 超過数を数える
            var overCnt = 0;

            // とりあえず全部足して n - 1 倍する
            ulong result = a_i[0];
            for (var i = n - 1; i > 0; i--) {
                result += a_i[i];
                for (var j = i - 1; j >= 0; j--) {
                    if (a_i[i] + a_i[j] >= BASEVALUE) overCnt++;
                    else break;
                }
            }
            result = (ulong)(n - 1) * result;

            if (overCnt > 0) {
                result -= (ulong)(BASEVALUE * overCnt);
            }
            Console.WriteLine(result);
        }
    }
}
