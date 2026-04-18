namespace r8_0228_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Seats 2 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc447/tasks/abc447_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            var result = true;
            if (n % 2 == 0) {
                result = m * 2 <= n;
            } else {
                result = (m * 2 - 1) <= n;
            }

            Console.WriteLine(result ? "Yes" : "No");
        }
    }
}
