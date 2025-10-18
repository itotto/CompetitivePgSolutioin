using System.Collections.Generic;
using System.Text;

namespace r7_1018_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Brackets Stack Query
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc428/tasks/abc428_c</remarks>
        static void Main() {
            var q = Convert.ToInt32(Console.ReadLine());

            var current = new StringBuilder();

            var result = new StringBuilder();

            // 悪い括弧1 - 右括弧が足りない
            // →　解消方法：右括弧が増える

            // 悪い括弧2 - 右括弧が多い
            // →　解消方法：右括弧が消える

            // 左括弧の位置(対応する右側がないもの)
            var leftBracketsStack = new Stack<int>();

            // 対応する左括弧のない右括弧のスタック
            var rightAnomalyBracketsStack = new Stack<int>();

            // key:右括弧の位置, value: keyに対応する左括弧の位置
            var rightBracketToLeft = new Dictionary<int, int>();

            for (var i = 0; i < q; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;

                // 2 : remove
                if (conditions.Length == 1) {
                    // 最後の括弧を取り出して削除
                    var lastBracket = current[current.Length - 1];
                    current.Remove(current.Length - 1, 1);
                    var pos = current.Length;

                    // 左括弧ならスタックから削除する
                    if (lastBracket == '(') {
                        leftBracketsStack.Pop();
                    }
                    // 右括弧なら対応する左括弧があればスタックに復活させる
                    else {
                        if (rightBracketToLeft.ContainsKey(pos)) {
                            leftBracketsStack.Push(rightBracketToLeft[pos]);
                            rightBracketToLeft.Remove(pos);
                        }
                        // 対応する左括弧がない場合は異常値なので異常値スタックから削除する
                        else {
                            rightAnomalyBracketsStack.Pop();
                        }
                    }
                }
                // 1 : add
                else if (conditions.Length == 2) {
                    var c = conditions[1];
                    var pos = current.Length;
                    current.Append(c);

                    // 左括弧ならスタックに追加する
                    if (c == "(") {
                        leftBracketsStack.Push(pos);
                    }
                    // 右括弧ならスタックに左括弧があるか確認
                    // ：あるならスタックから削除；右括弧に対応する左括弧の位置を登録
                    // ：ないなら異常値スタックに追加
                    else {
                        if (leftBracketsStack.Count > 0) {
                            var p = leftBracketsStack.Pop();
                            rightBracketToLeft.Add(pos, p);
                        } else {
                            rightAnomalyBracketsStack.Push(pos);
                        }
                    }
                }

                // 状態から良い括弧かどうか確認して結果を表示
                var r = leftBracketsStack.Count == 0 && rightAnomalyBracketsStack.Count == 0;
                result.AppendLine(r ? "Yes" : "No");
            }

            Console.WriteLine(result);
        }
    }
}
