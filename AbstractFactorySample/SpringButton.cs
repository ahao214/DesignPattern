using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactorySample
{
    class SpringButton:Button 
    {
        public void Display()
        {
            Console.WriteLine("显示浅绿色按钮");
        }
    }
}
