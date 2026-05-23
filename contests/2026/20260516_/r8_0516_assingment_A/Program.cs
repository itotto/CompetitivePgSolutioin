namespace r8_0516_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Chompers
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc458/tasks/abc458_a</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            var n = Convert.ToInt32(Console.ReadLine());

            var s1 = s.Substring(0, s.Length - n);
            var s2 = s1.Substring(n);

            Console.WriteLine(s2);
        }
    }
}
