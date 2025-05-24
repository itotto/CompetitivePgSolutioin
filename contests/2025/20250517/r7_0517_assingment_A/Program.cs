using System.Collections.Generic;

namespace r7_0517_assingment_A {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt32(conditions[0]);
            var b = Convert.ToInt32(conditions[1]);
            var c = Convert.ToInt32(conditions[2]);
            var d = Convert.ToInt32(conditions[3]);
            var x = a * 60 + b;
            var y = c * 60 + d;

            Console.WriteLine(x > y ? "Yes" : "No");
        }
    }
}
