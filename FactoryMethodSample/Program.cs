using System;
using System.Configuration;
using System.Reflection;

namespace FactoryMethodSample
{
    class Program
    {
        /// <summary>
        /// 工厂方法模式
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            LoggerFactory factory;  //针对抽象工厂类编程
            Logger logger;              //针对抽象产品类编程
            factory = new DatabaseLoggerFactory();
            logger = factory.CreateLogger();
            logger.WriteLog();

            #region 使用反射

            string factoryString = ConfigurationManager.AppSettings["factory"];
            //反射生成对象
            factory = (LoggerFactory)Assembly.Load("FactoryMethodSample").CreateInstance(factoryString);
            logger = factory.CreateLogger();
            logger.WriteLog();

            #endregion 


            Console.ReadLine();

        }
    }
}
