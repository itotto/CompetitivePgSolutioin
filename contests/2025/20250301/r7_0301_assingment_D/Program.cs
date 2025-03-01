using System.Collections.Generic;
using System.Text;

namespace r7_0301_assingment_D {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var q = Convert.ToInt32(conditions1[1]);


            // 鳩の居場所(key:鳩の番号, value:巣)
            var pigeons = new Dictionary<int, int>(n);

            // 巣にいる鳩(key:巣の番号, value:(key:鳩, value:ダミー変数))
            var nests = new Dictionary<int, Dictionary<int, bool>>(n);

            for (var i = 1; i <= n; i++) {
                pigeons.Add(i, i);
                nests.Add(i, new Dictionary<int, bool> { { i, true } });
            }

            // 結果
            var r = new StringBuilder();

            // 操作
            for (var i = 0; i < q; i++) {
                var operation = Console.ReadLine()?.Split(' ');
                if (operation == null) return;

                switch (operation[0]) {
                    case "1":
                        var pnum1 = Convert.ToInt32(operation[1]);
                        var toNest1 = Convert.ToInt32(operation[2]);

                        var currentNest1 = pigeons[pnum1];

                        // 巣の情報を更新
                        nests[currentNest1].Remove(pnum1);
                        nests[toNest1].Add(pnum1, true);

                        // 鳩の居場所を変更
                        pigeons[pnum1] = toNest1;

                        break;

                    case "2":
                        var fromNest2 = Convert.ToInt32(operation[1]);
                        var toNest2 = Convert.ToInt32(operation[2]);

                        // 巣にいる鳩の情報を抽出
                        var currentNestPigeons = nests[fromNest2];
                        var targetNestPigeons = nests[toNest2];

                        nests[fromNest2] = targetNestPigeons;
                        nests[toNest2] = currentNestPigeons;

                        // 鳩の情報を更新
                        // 巣a の鳩 は 巣b に行く
                        foreach (var cp in currentNestPigeons.Keys) {
                            pigeons[cp] = toNest2;
                        }

                        // 巣b の鳩 は 巣a に行く
                        foreach (var tp in targetNestPigeons.Keys) {
                            pigeons[tp] = fromNest2;
                        }
                        break;

                    case "3":
                        var pnum3 = Convert.ToInt32(operation[1]);
                        r.AppendLine(pigeons[pnum3].ToString());
                        break;
                }
            }

            // 結果を表示
            Console.WriteLine(r.ToString());
        }
    }
}
