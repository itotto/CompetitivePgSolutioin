using System.Collections.Generic;
using System.Text;

namespace r7_0802_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Search and Delete 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc417/tasks/abc417_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            var conditions_a = Console.ReadLine()?.Split(' ');
            if (conditions_a == null) return;
            var a_i = new List<int>();
            for (var i = 0; i < conditions_a.Length; i++) {
                a_i.Add(Convert.ToInt32(conditions_a[i]));
            }

            var conditions_b = Console.ReadLine()?.Split(' ');
            if (conditions_b == null) return;
            var b_i = new List<int>();
            for (var i = 0; i < conditions_b.Length; i++) {
                b_i.Add(Convert.ToInt32(conditions_b[i]));
            }
            b_i.Sort();

            var result = new StringBuilder();
            var b_index = 0;
            for (var i = 0; i < a_i.Count; i++) {
                var a = a_i[i];
                var bFound = false;
                for (var j = b_index; j < b_i.Count; j++) {
                    var b = b_i[j];
                    // 一致
                    if (a == b) {
                        bFound = true;
                        b_i.RemoveAt(j);
                        b_index = j == 0 ? 0 : j - 1;
                        break;
                    // もう超えている
                    } else if (a < b) {
                        b_index = j == 0 ? 0 : j - 1;
                        break;
                    }
                }

                // bに無かったら表示
                if (!bFound) {
                    result.Append($"{a} ");
                }
            }

            if (result.Length > 0) result.Remove(result.Length - 1, 1);
            Console.WriteLine(result.ToString());
        }
    }
}
