using System.Collections.Generic;

namespace r6_0921_assingment_A {
    internal class Program {
        /// <summary>
        /// A - delete .
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var str = Console.ReadLine();
            if (string.IsNullOrEmpty(str)) return;
            foreach (var c in str) {
                if (c != '.') Console.Write(c);
            }
            Console.WriteLine();
        }
    }
}
