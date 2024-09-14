using System.Collections.Generic;

namespace r6_0914_assingment_D {
    internal class Program {
        /// <summary>
        /// D - 1D Country
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc371/tasks/abc371_d</remarks>
        static void Main() {
            // 村の数
            var countOfVilages = Convert.ToInt32(Console.ReadLine());

            // 村の座標と住人数
            var coordinates = new Dictionary<int, int>(countOfVilages);

            // 座標情報
            var villagePositions = Console.ReadLine()?.Split(' ');
            if (villagePositions == null) return;

            var villageResidents = Console.ReadLine()?.Split(' ');
            if (villageResidents == null) return;

            for (var i = 0; i < countOfVilages; i++) {
                coordinates.Add(
                    Convert.ToInt32(villagePositions[i]),
                    Convert.ToInt32(villageResidents[i])
                );
            }

            // クエリーの数
            var countOfQueries = Convert.ToInt32(Console.ReadLine());

            // クエリ
            var queries = new List<KeyValuePair<int, int>>(countOfQueries); //key:from, value:to

            var start = int.MaxValue;
            var end = int.MinValue;
            for (var i = 0; i < countOfQueries; i++) {
                var conditions = Console.ReadLine()?.Split(' ');
                if (conditions == null) return;
                var f = Convert.ToInt32(conditions[0]);
                var t = Convert.ToInt32(conditions[1]);
                queries.Add(new KeyValuePair<int, int>(f, t));
                if (f < start) start = f;
                if (end < t) end = t;
            }

            // 累計和を計算する
            var partSum = new Dictionary<int, long>();
            long sum = 0;
            for (var i = start - 1; i <= end; i++) {
                if (coordinates.ContainsKey(i)) sum += coordinates[i];
                partSum.Add(i, sum);
            }

            // 結果を表示
            foreach (var q in queries) {
                long residents = partSum[q.Value] - partSum[q.Key - 1];
                Console.WriteLine(residents);
            }
        }
    }
}
