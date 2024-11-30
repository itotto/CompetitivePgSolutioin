namespace r6_1130_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Daily Cookie 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc382/tasks/abc382_b</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var d = Convert.ToInt32(conditions[1]);

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var maxPos = s.Length;
            for (var i = s.Length - 1; i >= 0; i--) {
                if (s[i] == '@') {
                    d--;
                    maxPos = i;
                    if (d == 0) break;
                }
            }

            for (var i = 0; i < maxPos; i++) { Console.Write(s[i]); }
            for (var i = maxPos; i < s.Length; i++) { Console.Write('.'); }

            // 最後の改行
            Console.WriteLine();
        }
    }
}
