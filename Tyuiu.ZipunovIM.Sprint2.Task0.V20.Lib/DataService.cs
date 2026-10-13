using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ZipunovIM.Sprint2.Task0.V20.Lib
{
    public class DataService : ISprint2Task0V20
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] res = new bool[6];

            // 1. Ожидается true: 1075 == 1075
            res[0] = x - 800 == y;

            // 2. Ожидается false: 1075 != 1075
            res[1] = x - 800 != y;

            // 3. Ожидается true: 1075 < 1100
            res[2] = x < y + 825;

            // 4. Ожидается false: 1075 > 1100
            res[3] = x > y + 825;

            // 5. Ожидается true: 1075 <= 1075
            res[4] = x - 800 <= y;

            // 6. Ожидается false: 1076 >= 1075 — неверно
            res[5] = x - 799 >= y;

            return res;
        }
    }
}
