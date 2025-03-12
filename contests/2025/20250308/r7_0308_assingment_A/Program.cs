namespace r7_0308_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Triple Four
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc396/tasks/abc396_a</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var r = false;
            for (var i = 0; i < n - 2; i++) {
                var x1 = Convert.ToInt32(conditions[i]);
                var x2 = Convert.ToInt32(conditions[i + 1]);
                var x3 = Convert.ToInt32(conditions[i + 2]);

                if (x1 == x2  && x1 == x3) {
                    r = true;
                    break;
                }
                continue;
            }
            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
