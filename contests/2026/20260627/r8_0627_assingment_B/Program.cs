using System.Collections.Generic;

namespace r8_0627_assingment_B {
    internal class Program {
        /// <summary>
        /// B - Crop
        /// </summary>
        /// <remarks>https://atcoder.jp/contests/abc464/tasks/abc464_b</remarks>
        static void Main() {
            var conditions1 = Console.ReadLine()?.Split(' ');
            if (conditions1 == null) return;
            var height = Convert.ToInt32(conditions1[0]);
            var width = Convert.ToInt32(conditions1[1]);

            var pixels = new char[height, width];

            // 入力
            for (var i = 0; i < height; i++) {
                var s = Console.ReadLine();
                if (string.IsNullOrEmpty(s)) continue;
                for (var j = 0; j < width; j++) {
                    pixels[i, j] = s[j];
                }
            }

            var isDeleted = false;
            var upperOffset = 0;
            var lowerOffset = 0;
            var leftOffset = 0;
            var rightOffset = 0;

            do {
                isDeleted = false;

                var checkWidth = width - leftOffset - rightOffset;

                // 最上位の一番左側の色を取得
                var upperColor = pixels[upperOffset, leftOffset];

                if (upperColor == '.') {
                    var upperIsSame = true;
                    if (checkWidth >= 2) {
                        // 最上行のチェック
                        for (var i = leftOffset + 1; i < width - rightOffset; i++) {
                            if (pixels[upperOffset, i] != upperColor) {
                                upperIsSame = false;
                            }
                        }
                    }

                    // 1行全部同じ値なら削除済みの値を入れる
                    if (upperIsSame) {
                        for (var j = leftOffset; j < width - rightOffset; j++) {
                            pixels[upperOffset, j] = 'x';
                        }
                        upperOffset++;
                        isDeleted = true;
                    }
                }

                // 最下位の一番左側の色を取得
                var lowerColor = pixels[height - lowerOffset - 1, leftOffset];
                if (lowerColor == '.') {
                    var lowerIsSame = true;

                    if (checkWidth >= 2) {
                        // 最下行のチェック
                        for (var i = leftOffset + 1; i < width - rightOffset; i++) {
                            if (pixels[height - lowerOffset - 1, i] != lowerColor) {
                                lowerIsSame = false;
                            }
                        }
                    }

                    // 1行全部同じ値なら削除済みの値を入れる
                    if (lowerIsSame) {
                        for (var j = leftOffset; j < width - rightOffset; j++) {
                            pixels[height - lowerOffset - 1, j] = 'x';
                        }
                        lowerOffset++;
                        isDeleted = true;
                    }
                }


                // 高さチェック
                var checkHeight = height - upperOffset - lowerOffset;

                // 一番左の一番上の色を確認
                var leftColor = pixels[upperOffset, leftOffset];
                if (leftColor == '.') {
                    var leftIsSame = true;
                    if (checkHeight >= 2) {
                        // 最左列のチェック
                        for (var i = upperOffset + 1; i < height - lowerOffset; i++) {
                            if (pixels[i, leftOffset] != leftColor) {
                                leftIsSame = false;
                            }
                        }
                    }

                    // 1行全部同じ値なら削除済みの値を入れる
                    if (leftIsSame) {
                        for (var j = upperOffset; j < height - lowerOffset; j++) {
                            pixels[j, leftOffset] = 'x';
                        }
                        leftOffset++;
                        isDeleted = true;
                    }
                }

                // 一番右の一番上の色を確認
                var rightColor = pixels[upperOffset, width - rightOffset - 1];
                if (rightColor == '.') {
                    var rightIsSame = true;

                    if (checkHeight >= 2) {
                        // 最右列のチェック
                        for (var i = upperOffset + 1; i < height - lowerOffset; i++) {
                            if (pixels[i, width - rightOffset - 1] != rightColor) {
                                rightIsSame = false;
                            }
                        }
                    }

                    // 1行全部同じ値なら削除済みの値を入れる
                    if (rightIsSame) {
                        for (var j = upperOffset; j < height - lowerOffset; j++) {
                            pixels[j, width - rightOffset - 1] = 'x';
                        }
                        rightOffset++;
                        isDeleted = true;
                    }
                }
            } while (isDeleted);


            // 出力
            for (var i = 0; i < height; i++) {
                for (var j = 0; j < width; j++) {
                    var p = pixels[i, j];
                    if (p == '.' || p == '#') Console.Write(p);
                }
                Console.WriteLine();
            }
        }
    }
}
