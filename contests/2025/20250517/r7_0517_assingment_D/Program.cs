using System.Collections.Generic;
using System.Text;

namespace r7_0517_assingment_D {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var height = Convert.ToInt32(conditions1[0]);
            var width = Convert.ToInt32(conditions1[1]);
            var n = Convert.ToInt32(conditions1[2]);

            // x-yを入力
            var columns = new Dictionary<int, List<int>>();
            var rows = new Dictionary<int, List<int>>();
            var trashes = new Dictionary<string, bool>();
            for (var i = 0; i < n; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var x = Convert.ToInt32(conditions2[0]);
                var y = Convert.ToInt32(conditions2[1]);

                if (!columns.ContainsKey(y)) columns.Add(y, new List<int> {x});
                else columns[y].Add(x);

                if (!rows.ContainsKey(x)) rows.Add(x, new List<int> {y});
                else  rows[x].Add(y);
                trashes.Add($"{x}__{y}", true);
            }

            var result = new StringBuilder();
            var q = Convert.ToInt32(Console.ReadLine());

            for (var i = 0; i < q; i++) {
                var conditions3 = Console.ReadLine()?.Split(' ');
                if (conditions3 == null) return;
                var q1 = Convert.ToInt32(conditions3[0]);
                var q2 = Convert.ToInt32(conditions3[1]);

                switch (q2) {
                    case 1:
                        result.AppendLine(rows[q1].ToString());
                        rows[q1] = 0;
                        break;
                    case 2:
                        result.AppendLine(columns[q1].ToString());
                        columns[q1] = 0;
                        break;
                }
            }

            //結果
            Console.WriteLine(result.ToString());
        }
    }
}
