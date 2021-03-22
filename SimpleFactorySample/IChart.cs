using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactorySample
{
    /// <summary>
    /// Chart:抽象图表接口，充当抽象产品类
    /// </summary>
    interface IChart
    {
        void Display();
    }
}
