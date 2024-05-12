using System.Collections.Generic;

namespace r6_0511_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Sigma Problem
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc353/tasks/abc353_c</remarks>
        static void Main() {
            const int BASEVALUE = 100000000;

            var n = Convert.ToInt32(Console.ReadLine());

            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;


            // 全部数値に変換して保持
            var a_i = new uint[n];
            for (var i = 0; i < cs.Length; i++) {
                a_i[i] = Convert.ToUInt32(cs[i]);
            }

            var overCnt = 0;
            ulong result = 0;
            for (var i = 0; i < n - 1; i++) {
                for (var j = i + 1; j < n; j++) {
                    ulong r = a_i[i] + a_i[j];
                    if (r >= BASEVALUE)  overCnt++;
                    result += r;
                }
            }
            if (overCnt > 0 ) {
                result -= (ulong)(BASEVALUE * overCnt);
            }
            Console.WriteLine(result);
        }
    }
}
