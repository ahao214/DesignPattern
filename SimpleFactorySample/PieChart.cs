using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactorySample
{
    /// <summary>
    /// 饼状图类，充当具体产品类
    /// </summary>
    public class PieChart : IChart
    {
        public PieChart()
        {
            Console.WriteLine("创建饼状图");
        }

        public void Display()
        {
            Console.WriteLine("显示饼状图");
        }
    }
}
