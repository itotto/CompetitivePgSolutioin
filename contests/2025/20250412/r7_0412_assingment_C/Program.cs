using System.Collections.Generic;

namespace r7_0412_assingment_C {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            const long BASENUM = 1000000000L;
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var k = Convert.ToInt32(conditions[1]);

            if (n < k) Console.WriteLine(1);
            else {

                //var bonacci = new List<long>(n + 1);
                var bonacci = new long[n + 1];

                // 0からk - 1までは1
                for (var i = 0; i < k; i++) bonacci[i] = 1;

                // k は k
                bonacci[k] = k;

                long lastNum = k;

                // k + 1 から n までは
                for (var i = k + 1; i <= n; i++) {
                    var excludedNumber = bonacci[i - k - 1];

                    long w = lastNum * 2;
                    if (w < excludedNumber) {
                        w += BASENUM;
                    }
                    w -= excludedNumber;

                    if (w > BASENUM) w = w % BASENUM;
                    lastNum = w;
                    bonacci[i] = w;
                }
                Console.WriteLine(bonacci[n] % BASENUM);
            }
        }
    }
}
