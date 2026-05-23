using System.Collections.Generic;

namespace r8_0509_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Arrays
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc457/tasks/abc457_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var data = new Dictionary<int, Dictionary<int, int>>();

            for (var i = 1; i <= n; i++) {
                var conditions1 = Console.ReadLine()?.Split(' ');
                if (conditions1 == null) return;

                var subData = new Dictionary<int, int>();
                for (var j = 1; j < conditions1.Length; j++) {
                    subData.Add(j, Convert.ToInt32(conditions1[j]));
                }
                data.Add(i, subData);
            }

            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            var x = Convert.ToInt32(conditions2[0]);
            var y = Convert.ToInt32(conditions2[1]);

            Console.WriteLine(data[x][y]);
        }
    }
}
