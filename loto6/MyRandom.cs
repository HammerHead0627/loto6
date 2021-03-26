using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loto6
{
    class MyRandom
    {
        //抽選番号の元となる乱数
        private static Random random;
        //乱数を生成して呼び出し元に返す
        public static int Next(int minValue, int maxValue)
        {
            //乱数が生成されていない場合、乱数を生成する。
            if (random == null) random = new Random();
            return random.Next(minValue, maxValue);
        }
    }
}
