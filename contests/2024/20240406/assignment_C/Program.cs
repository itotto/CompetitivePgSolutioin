using System.Collections.Generic;

namespace assignment003 {
    internal class Program {
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var beansTastes = new Dictionary<long, long>();
            for (int i = 0; i < n; i++) {
                var beansInfo = Console.ReadLine()?.Split(' ');
                if (beansInfo == null) return;
                var taste = Convert.ToInt64(beansInfo[0]);
                var beanType = Convert.ToInt64(beansInfo[1]);
                if (beansTastes.ContainsKey(beanType)) {
                    if (beansTastes[beanType] > taste) {
                        beansTastes[beanType] = taste;
                    }
                } else {
                    beansTastes.Add(beanType, taste);
                }
            }

            long answer = -1;
            foreach (var b in beansTastes) {
                if (b.Value > answer) answer = b.Value;
            }
            Console.WriteLine(answer);
        }
    }
}
