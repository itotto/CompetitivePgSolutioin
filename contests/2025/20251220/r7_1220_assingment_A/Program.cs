using System.Collections.Generic;

namespace r7_1220_assingment_A {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var inputs = Console.ReadLine()?.Split(' ');
            if (inputs == null) return;
            var a = Convert.ToInt32(inputs[0]);
            var b = Convert.ToInt32(inputs[1]);

            Console.WriteLine(a * 12 + b);
        }
    }
}
