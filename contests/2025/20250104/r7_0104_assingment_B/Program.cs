using System.Collections.Generic;

namespace r7_0104_assingment_B {
    internal class Program {
        /// <summary>
        /// B - 9x9 Sum
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var excludedNumber = Convert.ToInt32(Console.ReadLine());
            var sum = 0;
            for (var i = 1; i <= 9; i++) {
                for (var j = 1; j <= 9; j++) {
                    var r = i * j;
                    if (excludedNumber == r) continue;
                    sum += r;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
