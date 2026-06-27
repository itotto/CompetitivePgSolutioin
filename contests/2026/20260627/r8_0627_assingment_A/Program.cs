namespace r8_0627_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Decisive Battle
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc464/tasks/abc464_a</remarks>
        static void Main() {
            var s = Console.ReadLine();
            if (string.IsNullOrEmpty(s)) return;

            var e_count = 0;
            var w_count = 0;

            foreach (var c in s) {
                if (c == 'E') e_count++;
                else if (c == 'W') w_count++;
            }


            Console.WriteLine(e_count > w_count ? "East" : "West");
        }
    }
}
