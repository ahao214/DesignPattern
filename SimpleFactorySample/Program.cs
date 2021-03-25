using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactorySample
{
    class Program
    {
        /// <summary>
        /// 简单工厂模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IChart chart;
            //读取配置文件
            string chartStr = ConfigurationManager.AppSettings["chartType"];
            //通过静态工厂方法创建产品
            chart = ChartFactory.GetChart(chartStr);
            chart.Display();

            Console.ReadLine();
        }
    }
}
