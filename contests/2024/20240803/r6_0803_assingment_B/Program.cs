using System.Collections.Generic;

namespace r6_0803_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Second Best 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc365/tasks/abc365_b</remarks>
        static void Main() {
            _ = Convert.ToInt32(Console.ReadLine());

            var pos = new Dictionary<int, int>();
            var data = new List<int>();
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var idx = 1;
            foreach (var i in inputs) {
                var d = Convert.ToInt32(i);
                pos.Add(d, idx++);
                data.Add(d);
            }
            data.Sort((x, y) => x.CompareTo(y));

            Console.WriteLine(pos[data[data.Count - 2]]);
        }
    }
}
