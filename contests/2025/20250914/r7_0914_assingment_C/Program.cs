using System.Collections.Generic;
using System.ComponentModel.Design;

namespace r7_0914_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Lock All Doors
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc423/tasks/abc423_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var firstPosition = Convert.ToInt32(conditions1[1]);

            // 鍵の情報を取得
            var isLocked = new bool[n + 1];
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            for (var i = 0; i < n; i++) {
                isLocked[i + 1] = conditions[i] == "1";
            }

            var firstLocked = -1;
            var firstOpened = -1;
            for (var i = 1; i <= n; i++) {
                if (isLocked[i]) {
                    firstLocked = i;
                    if (firstOpened >= 0) break;
                } else {
                    firstOpened = i;
                    if (firstLocked >= 0) break;
                }
            }

            var lastOpened = -1;
            for (var i = n; i >= 0; i--) {
                if (!isLocked[i]) {
                    lastOpened = i;
                    break;
                }
            }

            var cnt = 0;

            // 鍵がかかってない場合
            if (firstLocked == -1) {
                cnt = n;
            } else if (firstOpened == -1) {
                cnt = 0; // 書かなくてもいいけど一応書いとく
            } else {
                var openCount = 0;
                var closeCount = 0;
                // パターン1(左側はロック済み、右側が一部開放)
                if (firstPosition + 1 <= firstOpened) {
                    openCount = 1;
                    for (var i = firstPosition + 1; i < lastOpened; i++) {
                        if (isLocked[i]) closeCount++;
                        else openCount++;
                    }
                }

                // パターン2(右側はロック済み、左側が一部開放)
                else if (lastOpened <= firstPosition) {
                    openCount = 1;
                    for (var i = firstPosition; i > firstOpened; i--) {
                        if (isLocked[i]) closeCount++;
                        else openCount++;
                    }
                }

                // パターン3(左側も右側も一部開放)
                else {
                    // 右へ→
                    openCount = 1;
                    for (var i = firstPosition + 1; i < lastOpened; i++) {
                        if (isLocked[i]) closeCount++;
                        else openCount++;
                    }

                    // 左へ←
                    openCount++;
                    for (var i = firstPosition; i > firstOpened; i--) {
                        if (isLocked[i]) closeCount++;
                        else openCount++;
                    }
                }
                cnt = openCount + closeCount * 2;
            }
            Console.WriteLine(cnt);
        }
    }
}
