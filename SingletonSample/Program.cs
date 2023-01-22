﻿using SingletonSample;
using static System.Console;
//单例模式

//创建4个LoadBalancer对象
LoadBalancer balancer1, balancer2, balancer3, balancer4;

balancer1 = LoadBalancer.GetLoadBalancer();
balancer2 = LoadBalancer.GetLoadBalancer();
balancer3 = LoadBalancer.GetLoadBalancer();
balancer4 = LoadBalancer.GetLoadBalancer();

//判断服务器负载均衡器是否相同
if (balancer1 == balancer2 && balancer2 == balancer3 && balancer3 == balancer4)
{
    WriteLine("服务器负载均衡器具有唯一性");
}

//增加服务器
balancer1.AddServer("Server 1");
balancer2.AddServer("Server 2");
balancer3.AddServer("Server 3");
balancer4.AddServer("Server 4");

//模拟客户端请求的分支,如果输出结果为同一个Server，可以将i适当放大，例如：改为"i < 100"
for (int i = 0; i < 10; i++)
{
    string server = balancer1.GetServer();
    WriteLine("分发请求至服务器" + server);
}
Read();

