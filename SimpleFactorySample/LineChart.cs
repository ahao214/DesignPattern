using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactorySample
{
    /// <summary>
    /// 折线图类，充当具体产品类
    /// </summary>
    public class LineChart:IChart
    {
        public LineChart()
        {
            Console.WriteLine("创建折线图");
        }

        public void Display()
        {
            Console.WriteLine("显示折线图");
        }
    }
}
