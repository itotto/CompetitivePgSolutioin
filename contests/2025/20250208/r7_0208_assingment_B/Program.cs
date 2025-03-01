using System.Collections.Generic;

namespace r7_0208_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Who is Missing? 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var m = Convert.ToInt32(cs1[1]);

            var cs2 = Console.ReadLine()?.Split(' ');
            if (cs2 == null) return;

            var a_i = new Dictionary<int, bool>(m);
            for (var i = 0; i < cs2.Length; i++) {
                a_i.Add(Convert.ToInt32(cs2[i]), true);
            }

            var result = new List<int>();
            for (var i = 1; i <= n; i++) {
                if (!a_i.ContainsKey(i)) result.Add(i);
            }

            Console.WriteLine(result.Count);
            for (var i = 0; i < result.Count; i++) {
                Console.Write($"{(i == 0 ? "" : " ")}{result[i]}");
            }
            Console.WriteLine();
        }
    }
}
