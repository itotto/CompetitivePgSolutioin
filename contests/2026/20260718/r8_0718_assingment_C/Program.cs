namespace r8_0718_assingment_C {
    internal class Program {
        /// <summary>
        /// C - Adjacent Sums (easy)
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc467/tasks/abc467_c</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var n = Convert.ToInt32(conditions1[0]);
            var m = Convert.ToInt32(conditions1[1]);

            var a_i = new int[n];
            var b_i = new int[n - 1];
            var sum_i = new int[n - 1];

            // A_i をセット
            var conditions2 = Console.ReadLine()?.Split(' ');
            if (conditions2 == null) return;
            a_i[0] = Convert.ToInt32(conditions2[0]);
            var lastV = a_i[0];

            for (var i = 1; i < n; i++) {
                a_i[i] = Convert.ToInt32(conditions2[i]);
                sum_i[i - 1] = lastV + a_i[i];
                lastV = a_i[i];
            }

            // B_i をセット
            var conditions3 = Console.ReadLine()?.Split(' ');
            if (conditions3 == null) return;
            for (var i = 0; i < n - 1; i++) {
                b_i[i] = Convert.ToInt32(conditions3[i]);
            }

            // 前の値が違っているかどうか
            var continued = sum_i[0] % m != b_i[0];

            var count = continued ? 1 : 0;
            for (var i = 1; i < n - 1; i++) {
                // 前の値は違っている
                if (continued) {
                    // ここも違ってたら continued はfalseに戻す
                    if (sum_i[i] % m != b_i[i]) {
                        continued = false;

                    // ここが同じなら変更は続くので1を足す
                    } else {
                        count++;
                    }

                // 前の値は同じ
                } else {
                    // 今回は違ってたら1件加算
                    if (sum_i[i] % m != b_i[i]) {
                        continued = true;
                        count++;
                    }

                }
            }
            Console.WriteLine(count);
        }
    }
}
