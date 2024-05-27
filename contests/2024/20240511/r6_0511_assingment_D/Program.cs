using System.Collections.Generic;

namespace r6_0511_assingment_D {
    internal class Program {
        /// <summary>
        /// D - Another Sigma Problem
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc353/tasks/abc353_d</remarks>
        static void Main() {
            const ulong BASEVALUE = 998244353;

            var n = Convert.ToInt32(Console.ReadLine());

            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;

            var m = new Dictionary<string, ulong>();

            ulong result = 0;
            for (var i = 0; i < n - 1; i++) {
                for (var j = i + 1; j < n; j++) {
                    var x = cs[i] + cs[j];
                    if (!m.ContainsKey(x)) {
                        m.Add(x, Convert.ToUInt64(cs[i] + cs[j]));
                    }
                    result += m[x];
                }
            }
            if (result > BASEVALUE) result %= BASEVALUE;
            Console.WriteLine(result);
        }
    }
}
