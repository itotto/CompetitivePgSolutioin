using System.Collections.Generic;

namespace r6_1012_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Seats
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc375/tasks/abc375_a</remarks>
        static void Main() {
            var countOfSeats = Convert.ToInt32(Console.ReadLine());
            var seats = Console.ReadLine();
            if (string.IsNullOrEmpty(seats)) return;
            var cnt = 0;

            if (countOfSeats >= 3) {
                for (var i = 0; i < countOfSeats - 2; i++) {
                    if (seats[i] == '#') {
                        if (seats[i + 1] == '.' && seats[i + 2] == '#') {
                            cnt++;
                        }
                    }
                }
            }

            Console.WriteLine(cnt);
        }
    }
}
