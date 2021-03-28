using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    class SpringTestField:TextField
    {
        public void Display()
        {
            Console.WriteLine("显示绿色边框的文本框");
        }
    }
}
