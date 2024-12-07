using System.Collections.Generic;

namespace r6_1207_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Humidifier 3
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc383/tasks/abc383_c</remarks>
        static void Main() {
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;
            var height = Convert.ToInt32(cs[0]);
            var width = Convert.ToInt32(cs[1]);
            var thredholdDistance = Convert.ToInt32(cs[2]);

            var squares = new char[height, width];
            var floors = new List<KeyValuePair<int, int>>(); // 床の場所
            var heaters = new List<KeyValuePair<int, int>>(); // ヒーターの場所
            for (var i = 0; i < height; i++) {
                var data = Console.ReadLine();
                if (string.IsNullOrEmpty(data)) return;
                for (var j = 0; j < data.Length; j++) {
                    var f = data[j];
                    squares[i, j] = f;
                    if (f == '.') floors.Add(new KeyValuePair<int, int>(i, j));
                    if (f == 'H') heaters.Add(new KeyValuePair<int, int>(i, j));
                }
            }

            foreach (var h in heaters) {

            }

            var totalCount = 0;



            Console.WriteLine(totalCount);
        }
    }
}
