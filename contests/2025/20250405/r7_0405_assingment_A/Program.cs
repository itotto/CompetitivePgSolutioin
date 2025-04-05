using System.Collections.Generic;

namespace r7_0405_assingment_A {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(400 % n == 0 ? 400 / n : -1);

        }
    }
}
