namespace r6_1026_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Rearranging ABC
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc377/tasks/abc377_a</remarks>
        static void Main() {
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;

            var aExists = false;
            var bExists = false;
            var cExists = false;
            foreach (var c in line) {
                if (c == 'A') aExists = true;
                if (c == 'B') bExists = true;
                if (c == 'C') cExists = true;
            }

            Console.WriteLine(aExists && bExists && cExists ? "Yes" : "No");
        }
    }
}
