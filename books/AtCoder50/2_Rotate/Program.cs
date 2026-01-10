:namespace _2_Rotate {
    internal class Program {
        /// <summary>
        /// A - Rotate
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc197/tasks/abc197_a</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            Console.WriteLine($"{s.Substring(1)}{s[0]}");
        }
    }
}
