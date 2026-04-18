using System.Collections.Generic;

namespace r8_0418_assingment_C {
    internal class Program {
        // 自分の持っているアイテム(key:アイテムの番号, value:ダミー)
        static Dictionary<int, bool> _myItems = new Dictionary<int, bool>();

        // ユーザーが持っているアイテム(key:friend, value:item)
        static Dictionary<int, List<int>> _nodes = new Dictionary<int, List<int>>();

        /// <summary>
        /// C - Straw Millionaire
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc454/tasks/abc454_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            for (var i = 0; i < m; i++) {
                var conditions2 = Console.ReadLine()?.Split(' ');
                if (conditions2 == null) return;
                var a = Convert.ToInt32(conditions2[0]);
                var b = Convert.ToInt32(conditions2[1]);

                if (_nodes.ContainsKey(a)) _nodes[a].Add(b);
                else _nodes.Add(a, new List<int> { b });
            }

            FollowNode(currentNode: 1);

            // 個数を出力
            Console.WriteLine(_myItems.Count);
        }

        static void FollowNode(int currentNode) {
            // 既に処理済みなら飛ばす
            if (_myItems.ContainsKey(currentNode)) return;

            // 追加する
            _myItems.Add(currentNode, true);

            // 処理済みにする
            //_isPassed.Add(currentNode, true);

            // 次のノードがなければおしまい
            if (!_nodes.ContainsKey(currentNode)) return;

            var nextNodes = _nodes[currentNode];

            // なかったらおしまい(これはたぶんいらない)
            if (nextNodes.Count == 0) return;

            foreach (var n in nextNodes) {
                FollowNode(currentNode: n);
            }
        }

    }
}
