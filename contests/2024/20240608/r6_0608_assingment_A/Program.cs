namespace r6_0608_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Sanitize Hands
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc357/tasks/abc357_a</remarks>
        static void Main() {
            var cs1 = Console.ReadLine()?.Split(' ');
            if (cs1 == null) return;
            var n = Convert.ToInt32(cs1[0]);
            var m = Convert.ToInt32(cs1[1]);

            var cs2 = Console.ReadLine()?.Split(' ');
            if (cs2 == null) return;

            var cnt = -1;
            for (var i = 0; i < cs2.Length; i++) {
                m -= Convert.ToInt32(cs2[i]);
                if (m <= 0) {
                    cnt = m == 0 ? i + 1 : i;
                    break;
                }
            }
            if (cnt == -1) {
                cnt = cs2.Length;
            }

            Console.WriteLine(cnt);
        }
    }
}
