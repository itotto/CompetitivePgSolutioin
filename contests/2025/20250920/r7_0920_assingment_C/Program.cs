using System.Collections.Generic;

namespace r7_0920_assingment_C {
    internal class Program {
        /// <summary>
        /// C - New Skill Acquired
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc424/tasks/abc424_c</remarks>
        static void Main() {
            var n = Convert.ToInt32(Console.ReadLine());

            var skills = new Dictionary<int, bool>();
            var notAcquired = new Dictionary<int, int[]>();

            var aquiredCount = new Dictionary<int, int>();
            for (var i = 1; i <= n; i++) aquiredCount.Add(i, 0);

            for (var i = 1; i <= n; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var a = Convert.ToInt32(conditions[0]);
                var b = Convert.ToInt32(conditions[1]);
                if (a == 0 && b == 0) {
                    skills.Add(i, true);
                } else {
                    aquiredCount[a]++;
                    aquiredCount[b]++;
                    if (skills.ContainsKey(a) || skills.ContainsKey(b)) {
                        skills.Add(i, true);
                    } else {
                        // 未修得
                        notAcquired.Add(i, new int[2] { a, b });
                    }
                }
            }

            for (var i = 1; i <= n; i++) {
                if (aquiredCount[i] == 0 && notAcquired.ContainsKey(i))
                    notAcquired.Remove(i);
            }

            if (notAcquired.Count > 0) {
                while (true) {
                    var deleteList = new List<int>();
                    foreach (var na in notAcquired) {
                        var i = na.Key;
                        var a = na.Value[0];
                        var b = na.Value[1];
                        if (skills.ContainsKey(a) || skills.ContainsKey(b)) {
                            skills.Add(i, true);
                            deleteList.Add(i);
                        }
                    }
                    if (deleteList.Count == 0) break;
                    else {
                        deleteList.ForEach(d => notAcquired.Remove(d));
                    }
                }
            }
            Console.WriteLine(skills.Count);
        }
    }
}
