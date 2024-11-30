namespace r6_1130_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Daily Cookie
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc382/tasks/abc382_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var d = Convert.ToInt32(conditions[1]);

            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var cnt = 0;
            foreach (var c in s) {
                if (c == '@') cnt++;
            }
            Console.WriteLine(s.Length - cnt + d);
        }
    }
}
