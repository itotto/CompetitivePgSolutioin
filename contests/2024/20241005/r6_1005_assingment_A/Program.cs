namespace r6_1005_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Takahashi san 2
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc374/tasks/abc374_a</remarks>
        static void Main() {
            var username = Console.ReadLine();
            if (string.IsNullOrEmpty(username)) return;
            if (username.Length < 3) Console.WriteLine("No");
            else {
                Console.WriteLine(username.EndsWith("san") ? "Yes" : "No");
            }
        }
    }
}
