using System.Collections.Generic;

namespace r8_0411_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Sneaking Glances
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc453/tasks/abc453_c</remarks>
        static void Main() {
            _ = Convert.ToInt32(Console.ReadLine());

            var count = 0;
            var current = 0.5;
            var isPlus = true;
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;

            var i = 0;
            while (i < conditions.Length) {
                var v = Convert.ToInt32(conditions[i]);

                // ここの移動で 0 を超えられるなら移動する
                if (Math.Abs(current) <= v) {
                    // 正にいるなら引く、負にいるなら足す
                    current = isPlus ? current - v : current + v;

                    count++;
                    isPlus = !isPlus;
                    i++;
                } else {
                    var targetSize = Math.Abs(current);

                    long sum = v;
                    var j = i + 1;

                    var addValues = new List<int>();

                    while (j < conditions.Length) {
                        var addV = Convert.ToInt32(conditions[j++]);
                        sum += addV;
                        addValues.Add(addV);

                        // ここまで足せば 0 を超えられる
                        if (sum > targetSize) {
                            // 降順でソート
                            addValues.Sort((x,y) => y - x);

                            foreach (var add in addValues) {
                                if (sum - 2 * add > targetSize) {
                                    sum -= 2 * add;
                                }
                            }

                            // 正にいるなら引く、負にいるなら足す
                            current = isPlus ? current - sum : current + sum;

                            count++;
                            isPlus = !isPlus;
                            i = j + 1;
                            break;
                        }
                    }

                    // 0を超えるまでいけないことが分かった
                    if (j >= conditions.Length) {
                        break;
                    }

                }
            }

            Console.WriteLine(count);
        }
    }
}
