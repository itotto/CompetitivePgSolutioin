namespace r8_0718_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Keep the Change
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc467/tasks/abc467_b</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var totalMoney_normal = 10000;
            var totalMoney_real = totalMoney_normal;

            for (var i = 0; i < n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var a_i = Convert.ToInt32(conditions[0]);
                var b_i = Convert.ToInt32(conditions[1]);
                var s_i = conditions[2];

                // 買った分を差し引く
                totalMoney_normal -= a_i;

                // お釣りを受け取らないときは払った分を引く
                totalMoney_real -= (s_i == "keep") ? b_i : a_i;
            }
            Console.WriteLine(totalMoney_normal - totalMoney_real);

        }
    }
}
