using System.Collections.Generic;

namespace r7_0405_assingment_B {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);

            long result = 1;
            long oldValue = 1;
            for (var i = 1; i <= m; i++) {
                oldValue *= n;
                result += oldValue;
                if (result > 1000000000) break;
            }
            Console.WriteLine(result <= 1000000000 ? result.ToString() : "inf");
        }
    }
}
