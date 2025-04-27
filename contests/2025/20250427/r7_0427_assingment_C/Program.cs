using System.Collections.Generic;
using System.Text;

namespace r7_0427_assingment_C {
    internal class Program {
        /// <summary>
        /// 
        /// </summary>
        /// <remarks></remarks>
        static void Main() {
            var conditions = Console.ReadLine()?.Split(' ');
            if (conditions == null) return;
            var n = Convert.ToInt32(conditions[0]);
            var m = Convert.ToInt32(conditions[1]);
            var q = Convert.ToInt32(conditions[2]);

            var result = new StringBuilder();

            // key:ユーザーID + _ + ページ番号, value:dummy
            var canViews = new Dictionary<string, bool>();

            // すべてのページを閲覧できるユーザー(key:ユーザーID, value:dummy)
            var isAdmin = new Dictionary<int, bool>();

            for (var i = 0; i < q; i++) {
                var querystr = Console.ReadLine()?.Split(' ');
                if (querystr == null) return;
                var uid = Convert.ToInt32(querystr[1]);

                // id:2 - すべてのページを見られる権限を付与
                if (querystr.Length == 2) {
                    if (!isAdmin.ContainsKey(uid)) isAdmin.Add(uid, true);

                // id:1,3 - 
                } else if (querystr.Length == 3) {
                    var qid = Convert.ToInt32(querystr[0]);
                    var pageId = Convert.ToInt32(querystr[2]);
                    // 権限付与
                    if (qid == 1) {
                        var pageKey = $"{uid}__{pageId}";
                        if (!canViews.ContainsKey(pageKey)) canViews.Add(pageKey, true);

                        // 回答
                    } else if (qid == 3) {
                        var canView = isAdmin.ContainsKey(uid);
                        if (!canView) {
                            canView = canViews.ContainsKey($"{uid}__{pageId}");
                        }
                        result.AppendLine($"{(canView ? "Yes" : "No")}");
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
