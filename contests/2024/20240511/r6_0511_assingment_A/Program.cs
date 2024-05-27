namespace r6_0511_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Buildings
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc353/tasks/abc353_a</remarks>
        static void Main() {
            _ = Convert.ToInt32(Console.ReadLine());

            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var pos = -1;
            var baseHeight = Convert.ToInt32(conditions[0]);
            for (var i = 1; i < conditions.Length; i++) {
                var h_i = Convert.ToInt32(conditions[i]);
                if (h_i > baseHeight) {
                    pos = i + 1;
                    break;
                }
            }

            Console.WriteLine(pos);
        }
    }
}
