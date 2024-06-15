namespace r6_0615_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Welcome to AtCoder Land
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc358/tasks/abc358_a</remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            Console.WriteLine(inputs[0] == "AtCoder" && inputs[1] == "Land" ? "Yes" : "No");
        }
    }
}
