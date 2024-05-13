namespace r6_0504_assingment_A {
    internal class Program {
        /// <summary>
        /// A - AtCoder Line
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc352/tasks/abc352_a</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var x = Convert.ToInt32(inputs[1]);
            var y = Convert.ToInt32(inputs[2]);
            var z = Convert.ToInt32(inputs[3]);

            // x > y の状態にする
            if (x < y) {
                var t = x;
                x = y;
                y = t;
            }
            Console.WriteLine(y < z && z < x ? "Yes" : "No");
        }
    }
}
