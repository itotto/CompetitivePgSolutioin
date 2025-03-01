using System.Collections.Generic;

namespace r7_0301_assingment_A {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var r = true;
            var lastNumber = 0;
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < n; i++) {
                var a_i = Convert.ToInt32(conditions[i]);
                if (lastNumber >= a_i) {
                    r = false;
                    break;
                }
                lastNumber = a_i;
            }

            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
