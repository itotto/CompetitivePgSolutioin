using System.Collections.Generic;

namespace r7_1220_assingment_B {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var h = Convert.ToInt32(conditions1[0]);
            var w = Convert.ToInt32(conditions1[1]);
            var n = Convert.ToInt32(conditions1[2]);

            // a_i,jを入力
            var data = new List<Dictionary<int, bool>>();
            for (var i = 0; i < h; i++) {
                var condtions2 = Console.ReadLine()?.Split(' ');
                if (condtions2 == null) return;
                var d = new Dictionary<int, bool>();
                for (var j = 0; j < w; j++) {
                    d.Add(Convert.ToInt32(condtions2[j]), true);
                }
                data.Add(d);
            }

            var b_n = new List<int>(n);
            for (var i = 0; i < n; i++) {
                b_n.Add(Convert.ToInt32(Console.ReadLine()));
            }

            var maxCount = 0;

            foreach (var d in data) {
                var workCount = 0;
                foreach (var b in b_n) {
                    if (d.ContainsKey(b)) workCount++;
                }
                if (workCount > maxCount)  maxCount = workCount;
            }

            Console.WriteLine(maxCount);
        }
    }
}
