using System.Collections.Generic;
using System.Text;

namespace r7_0712_assingment_B {
    internal class Program {
        /// <summary>
        /// B - String Too Long
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc414/tasks/abc414_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var isTooLong = false;
            var data = new StringBuilder();

            for (var i = 0; i < n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                if (isTooLong) continue;

                if (conditions[1].Length >= 4) {
                    isTooLong = true;
                } else {
                    var c = conditions[0][0];
                    var len = Convert.ToInt32(conditions[1]);
                    if (len > 100) isTooLong = true;
                    else {
                        data.Append(new string(c, len));
                        if (data.Length > 100) isTooLong = true;
                    }
                }
            }
            if (data.Length > 100) isTooLong = true;

            Console.WriteLine(isTooLong ? "Too Long" : data.ToString());
        }
    }
}
