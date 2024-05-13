using System.Collections.Generic;

namespace assignment004 {
    internal class Program {
        static void Main() {
            string getKey(int x, int y) => $"x--y";
// 
            var coodinateInfo = Console.ReadLine()?.Split(' ');
            if (coodinateInfo == null) return;
            var height = Convert.ToInt32(coodinateInfo[0]);
            var width = Convert.ToInt32(coodinateInfo[1]);
            
            // 座標を取得
            var coodinates = new char[width, height];

            var countOfMedicines = Convert.ToInt32(Console.ReadLine());
            var medicines = new Dictionary<string, int>();
            for (int i = 0; i < countOfMedicines; i++) {
                var medicineInfo = Console.ReadLine()?.Split(' ');
                if (medicineInfo == null) return;
                var r_x = Convert.ToInt32(medicineInfo[0]);
                var r_y = Convert.ToInt32(medicineInfo[1]);
                var energy = Convert.ToInt32(medicineInfo[2]);
                medicines.Add(getKey(r_x, r_y), energy);
            }


            var r = true;

            Console.WriteLine(r ? "Yes" : "No");
        }
    }
}
