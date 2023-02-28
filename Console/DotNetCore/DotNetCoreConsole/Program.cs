﻿using CodeLibraryForDotNetCore;
using CodeLibraryForDotNetCore.Algorithms;
using CodeLibraryForDotNetCore.Algorithms.Enums;
using CodeLibraryForDotNetCore.AnonymousTypes;
using CodeLibraryForDotNetCore.Attributes;
using CodeLibraryForDotNetCore.ConcurrentCollection;
using CodeLibraryForDotNetCore.DelegateAndEvent.AnonymousMethods;
using CodeLibraryForDotNetCore.DelegateAndEvent.Delegate;
using CodeLibraryForDotNetCore.DelegateAndEvent.Event;
using CodeLibraryForDotNetCore.EnumTools;
using CodeLibraryForDotNetCore.Formats.UseIFormatProvider;
using CodeLibraryForDotNetCore.Formats.UseIFormattable;
using CodeLibraryForDotNetCore.GenerateRegularExpressionByCode.UseCSharpVerbalExpressions;
using CodeLibraryForDotNetCore.GetLength;
using CodeLibraryForDotNetCore.IndexerAndCollection;
using CodeLibraryForDotNetCore.InterfacesAndAbstractClasses;
using CodeLibraryForDotNetCore.IPAddresses;
using CodeLibraryForDotNetCore.LinqTools;
using CodeLibraryForDotNetCore.OverrideNewAndVirtual;
using CodeLibraryForDotNetCore.Pattern.SingletonPattern;
using CodeLibraryForDotNetCore.QueryTree;
using CodeLibraryForDotNetCore.ReadAndWriteXml;
using CodeLibraryForDotNetCore.Reflections;
using CodeLibraryForDotNetCore.SendEmail;
using CodeLibraryForDotNetCore.StringConverters;
using CodeLibraryForDotNetCore.TypeConversion;
using CodeLibraryForDotNetCore.UseArray;
using CodeLibraryForDotNetCore.UseConstAndReadonly;
using CodeLibraryForDotNetCore.UseDependencyInjection;
using CodeLibraryForDotNetCore.UseEF;
using CodeLibraryForDotNetCore.UseEqualsAndHashCodes;
using CodeLibraryForDotNetCore.UseLock;
using CodeLibraryForDotNetCore.UsePostgresql;
using CodeLibraryForDotNetCore.UseRabbitMQ;
using CodeLibraryForDotNetCore.UseString;
using CodeLibraryForDotNetCore.UseTcpSocket;
using CodeLibraryForDotNetCore.UseTimestamp;
using CodeLibraryForDotNetCore.UseTry;
using CodeLibraryForDotNetCore.UseYield;
using CoreConsole;
using System;
using System.Threading.Tasks;

namespace DotNetCoreConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //redis
            RedisDemo.Run();

            //postgresql
            Task.Run(async () =>
            {
                await (new UsePostgresqlDemo(new TestDbContextFactory().CreateDbContext(args))).Run();
            });

            //read config
            ConfigReadDemo.ReadConfig();
            ConfigReadDemo.ReadConfigByBind();
            ConfigReadDemo.ReadConfigHotUpdate();
            ConfigReadDemo.ReadConfig2();

            //send email
            SendEmailDemo.Run();

            //yield
            UseYieldDemo.Run();

            //扩展方法同名
            var str = "Test Extensions";
            bool r1 = CodeLibraryForDotNetCore.Extensions2.StringExtension2.IsNullOrEmptyCustomExtension(str);
            bool r2 = CodeLibraryForDotNetCore.Extensions1.StringExtension1.IsNullOrEmptyCustomExtension(str);
            //如果同时引用了两个命名空间，无法写的效果
            //bool r = str.IsNullOrEmptyCustomExtension();

            //Postgresql 使用空间数据
            Task.Run(async () =>
            {
                await (new PostgresqlUseGeometryDemo(new TestDbContextFactory().CreateDbContext(args))).Run();
            });

            //linq 使用lambda表达式
            new LinqToolDemo(new TestDbContextFactory().CreateDbContext(args)).Run();

            //使用代码动态生成正则表达式
            UseCSharpVerbalExpressionsDemo.Run();

            //tcp socket demo
            UseTcpSocketDemo.Run();

            //数组
            UseArrayDemo.Run();

            //byte to string
            StringDemo.Run();

            //RabbitMQ Sender
            var host = "localhost";
            var port = 5673;
            var userName = "guest";
            var password = "guest";
            Send.Run(host, port, userName, password);
            NewTask.Run(host, port, userName, password);
            EmitLog.Run(host, port, userName, password);

            //获得IPAddress列表
            IPAddressTool.GetIPAddressList();

            //排序算法：https://www.cnblogs.com/onepixel/articles/7674659.html
            var sortList1 = BubbleSort.Sort(new int[] { 2, 33, 22, 1, 0, 9, 5 }, SortMethodEnum.FromLargeToSmall);
            var sortList2 = BubbleSort.Sort(new int[] { 2, 33, 22, 1, 0, 9, 5 }, SortMethodEnum.FromSmallToLarge);

            var sortList3 = SelectionSort.Sort(new int[] { 2, 33, 22, 1, 0, 9, 5 }, SortMethodEnum.FromLargeToSmall);
            var sortList4 = SelectionSort.Sort(new int[] { 2, 33, 22, 1, 0, 9, 5 }, SortMethodEnum.FromSmallToLarge);

            //hash code
            UseEqualsAndHashCodesDemo.TestHashCode();
            UseEqualsAndHashCodesDemo.TestEquals();

            //string
            UseStringDemo.Run();
            UseStringDemo.Run2();

            //const && readonly
            var demo = new UseConstAndReadonlyDemo();

            //委托和事件
            DelegateDemo.DelegateDemo1();
            DelegateDemo.DelegateDemo2();
            DelegateDemo.DelegateDemo3();
            DelegateDemo.DelegateDemo4();
            EventDemo.Run();
            //含匿名方法
            AnonymousMethodDemo.Run1();
            AnonymousMethodDemo.Run2();

            //依赖注入
            new UseDependencyInjectionDemo().Run("依赖注入测试...");

            //try-finally
            UseTryDemo.Run();

            //length
            GetLengthDemo.Run();

            //lock
            new UseLockDemo().Run();

            //线程安全集合
            ConcurrentCollectionDemo.ConcurrentBagDemo();
            ConcurrentCollectionDemo.ConcurrentQueueDemo();
            ConcurrentCollectionDemo.ConcurrentStackDemo();
            ConcurrentCollectionDemo.ConcurrentDictionaryDemo();

            //IFormattable和IFormatProvider
            UseIFormattableDemo.Run();
            UseIFormatProviderDemo.Run();

            //枚举扩展方法获得描述
            EnumToolDemo.Run();

            //类型转换
            //基类、子类之间的类型转换
            BaseAndSubClassTypeConversionDemo.Run();
            //自定义显隐式类型转换
            CustomTypeConversionDemo.Run();

            //Attribute
            AttributeDemo.Run();

            //ef 录入datatable
            //mysql
            MysqlUseEFDemo.Run();
            SqlServerUseEFDemo.Run();
            QueryTreeDemo queryTreeDemo = new QueryTreeDemo();
            queryTreeDemo.SqliteQuery();
            //树状结构查询
            queryTreeDemo.TreeQuery();

            //反射
            ReflectionDemo.Run();
            //获得方法相关信息
            ReflectionDemo.UseCallerMemberNameAttribute();
            //测试不同访问级别、静态/实例的访问权限
            ReflectionDemo.TestAccessLevel();

            //接口和抽象类
            InterfacesAndAbstractClassesDemo.Run();

            //重写override、重载和隐藏virtual、new
            OverrideNewAndVirtualDemo.Run();

            //索引器
            IndexerAndCollectionDemo.Run();

            //设计模式
            //单例模式
            SingletonPatternDemo.Run();

            //读写xml文件
            ReadAndWriteXmlDemo.Run();

            //时间戳
            UseTimeStampDemo.Run();

            //匿名类型
            AnonymousTypeDemo.Run();

            Console.ReadLine();
        }

        ~Program()
        {

        }
    }
}
