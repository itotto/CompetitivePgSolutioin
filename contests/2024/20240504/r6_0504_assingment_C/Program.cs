using System.Collections.Generic;

namespace r6_0504_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Standing On The Shoulders
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc352/tasks/abc352_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var giants = new List<GiantHeight>();
            for (var i = 0; i < n; i++) {
                var g = new GiantHeight();
                var cs = Console.ReadLine()?.Split(' ');
                if (cs == null) return;
                g.SholderHeight = Convert.ToInt32(cs[0]);
                g.Height = Convert.ToInt32(cs[1]);
                g.Diff = g.Height - g.SholderHeight;
                giants.Add(g);
            }

            // 差の順に並べる
            giants.Sort((x, y) => x.Diff - y.Diff);

            long tall = 0;

            // 最初と最後は除く
            for (var i = 0; i < giants.Count - 1; i++) {
                tall += giants[i].SholderHeight;
            }

            // 最後
            tall += giants[giants.Count - 1].Height;

            Console.WriteLine(tall);
        }
    }

    struct GiantHeight {
        public int SholderHeight { get; set; }

        public int Height { get; set; }

        public int Diff { get; set; }
    }
}
