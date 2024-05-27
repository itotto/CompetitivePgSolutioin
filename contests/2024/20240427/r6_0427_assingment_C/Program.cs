using System.Collections.Generic;

namespace r6_0427_assingment_C {
    internal class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var balls = new List<int>(n);
            var columns = new List<int>();

            // 条件入力
            var data = Console.ReadLine()?.Split(' ');
            if (data == null) return;
            for (var i = 0; i < data.Length; i++) {
                balls.Add(Convert.ToInt32(data[i]));
            }

            foreach (var b in balls) {
                columns.Add(b);
                if (columns.Count == 1) continue;
                while (true) {
                    var cn = columns.Count;
                    var b1 = columns[cn - 2];
                    var b2 = columns[cn - 1];
                    if (b1 != b2) break; // 違うならおしまい

                    // 後ろから消す
                    columns.RemoveAt(cn - 1);
                    columns.RemoveAt(cn - 2);

                    // 
                    columns.Add(b1 + 1);
                    if (columns.Count == 1) break;
                }
            }

            // 列にあるボールの数を数える
            Console.WriteLine(columns.Count);
        }
    }
}
