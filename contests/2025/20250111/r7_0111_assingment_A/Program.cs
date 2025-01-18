namespace r7_0111_assingment_A {
    internal class Program {
        /// <summary>
        /// A - ?UPC
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc388/tasks/abc388_a</remarks>
        static void Main() {
            var line = Console.ReadLine();
            if (string.IsNullOrEmpty(line)) return;
            Console.WriteLine($"{line[0]}UPC");
        }
    }
}
