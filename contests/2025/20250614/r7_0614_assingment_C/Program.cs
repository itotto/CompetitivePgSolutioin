using System.Collections.Generic;
using System.Text;

namespace r7_0614_assingment_C {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var q = Convert.ToInt32(conditions1[1]);

            var a_i = new Dictionary<long, long>();
            for (var i = 1; i <= n; i++) a_i.Add(i, i);

            var result = new StringBuilder();

            var shiftCount = 0;

            for (var i = 0; i < q; i++) {
                var query = Console.ReadLine()?.Split(' ');
                if (query == null) return;
                var queryType = Convert.ToInt32(query[0]);
                var param2 = Convert.ToInt32(query[1]);

                switch (queryType) {
                    // 1:値変更
                    case 1:
                        long pos1 = param2 - shiftCount;
                        if (pos1 <= 0) pos1 += n;
                        var newValue = Convert.ToInt32(query[2]);
                        a_i[pos1] = newValue;
                        break;

                    // 2:表示
                    case 2:
                        long pos2 = param2 - shiftCount;
                        if (pos2 <= 0) pos2 += n;
                        result.AppendLine(a_i[pos2].ToString());
                        break;

                    case 3:
                        if (param2 >= n) param2 %= n;
                        shiftCount -= param2;
                        if (shiftCount < 0) shiftCount += n;
                        break;
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
