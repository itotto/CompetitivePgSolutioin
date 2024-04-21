namespace r6_0420_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Past ABCs 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc350/tasks/abc350_a</remarks>
        static void Main() {
            const int LIMIT_NUM = 349;
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;
            var num = Convert.ToInt32(s.Replace("ABC", string.Empty));
            if (num <= 0) num = 999;
            if (num == 316) num = 999;
            Console.WriteLine(num <= LIMIT_NUM ? "Yes" : "No");
        }
    }
}
