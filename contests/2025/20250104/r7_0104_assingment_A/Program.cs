using System.Collections.Generic;

namespace r7_0104_assingment_A {
    internal class Program {
        /// <summary>
        /// A - Happy New Year 2025
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var a = Convert.ToInt32(conditions[0]);
            var b = Convert.ToInt32(conditions[1]);

            Console.WriteLine((a + b) * (a + b));
        }
    }
}
