namespace r8_0418_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Closed interval 
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc454/tasks/abc454_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var l = Convert.ToInt32(conditions[0]);
            var r = Convert.ToInt32(conditions[1]);
            Console.WriteLine(r - l + 1);
        }
    }
}
