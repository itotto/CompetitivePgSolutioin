namespace r7_1101_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Candy Cookie Law
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc430/tasks/abc430_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt32(conditions[0]);
            var b = Convert.ToInt32(conditions[1]);
            var c = Convert.ToInt32(conditions[2]);
            var d = Convert.ToInt32(conditions[3]);

            var result = false;
            if (c >= a) {
                result = d < b;
            }

            Console.WriteLine($"{(result ? "Yes" : "No")}");
        }
    }
}
