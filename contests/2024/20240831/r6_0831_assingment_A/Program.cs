namespace r6_0831_assingment_A {

    internal class Program {
        /// <summary>
        /// A - 369
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc369/tasks/abc369_a</remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var num1 = Convert.ToInt32(conditions[0]);
            var num2 = Convert.ToInt32(conditions[1]);

            var cnt = 0;
            if (num1 == num2) {
                cnt = 1;
            } else {
                var largeNum = num1 > num2 ? num1 : num2;
                var smallNum = num1 > num2 ? num2 : num1;

                cnt = 2;
                var diff = largeNum - smallNum;
                if ((diff >= 2) &&
                    (diff % 2 == 0)) {
                    cnt++;
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
