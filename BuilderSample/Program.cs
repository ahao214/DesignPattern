using System;
using System.Configuration;
using System.Reflection;
using static System.Console;

namespace BuilderSample
{
    /// <summary>
    /// 建造者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ActorBuilder ab;    //针对抽象建造者编程
            //读取配置文件
            string builderType = ConfigurationManager.AppSettings["builder"];

            //反射生成对象
            ab = (ActorBuilder)Assembly.Load("BuilderSample").CreateInstance(builderType);

            ActorController ac = new ActorController();
            Actor actor;
            actor = ac.Construct(ab);   //通过指挥者创建完整的建造者对象

            WriteLine("{0}的外观：", actor.Type);
            WriteLine("性别：{0}", actor.Sex);
            WriteLine("面容：{0}", actor.Face);
            WriteLine("服装：{0}", actor.Costume);
            WriteLine("发型：{0}", actor.Hairstyle);
            ReadLine();

        }
    }
}
