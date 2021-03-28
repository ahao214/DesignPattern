using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    class SummerComboBox:ComboBox
    {
        public void Display()
        {
            Console.WriteLine("显示蓝色边框的组合框");
        }
    }
}
