using System.Collections.Generic;

namespace r6_0427_assingment_D {
    internal class Program {
        static void Main() {
            var cs = Console.ReadLine()?.Split(' ');
            if (cs == null) return;
            var h = Convert.ToInt32(cs[0]);
            var w = Convert.ToInt32(cs[1]);
        }
    }
}
