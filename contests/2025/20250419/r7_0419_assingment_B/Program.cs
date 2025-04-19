using System.Collections.Generic;
using System.Text;

namespace r7_0419_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Restaurant Queue
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc402/tasks/abc402_b</remarks>
        static void Main() {
            var qCount = Convert.ToInt32(Console.ReadLine());

            var result = new StringBuilder();

            var waitlist = new Queue<int>();

            for (var i = 0; i < qCount; i++) {
                var orders = Console.ReadLine()?.Split(' ');
                if (orders == null) continue;
                switch (orders.Length) {
                    case 1:
                        result.AppendLine(waitlist.Dequeue().ToString());
                        break;

                    case 2:
                        waitlist.Enqueue(int.Parse(orders[1]));
                        break;

                    default:
                        break;
                }
            }
            Console.Write(result.ToString());
        }
    }
}
