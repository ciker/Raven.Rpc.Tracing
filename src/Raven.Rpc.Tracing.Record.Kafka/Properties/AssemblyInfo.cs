﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// 有关程序集的一般信息由以下
// 控制。更改这些特性值可修改
// 与程序集关联的信息。
[assembly: AssemblyTitle("Raven.Rpc.Tracing.Record.Kafka")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Raven.Rpc.Tracing.Record.Kafka")]
[assembly: AssemblyCopyright("Copyright ©  2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

//将 ComVisible 设置为 false 将使此程序集中的类型
//对 COM 组件不可见。  如果需要从 COM 访问此程序集中的类型，
//请将此类型的 ComVisible 特性设置为 true。
[assembly: ComVisible(false)]

// 如果此项目向 COM 公开，则下列 GUID 用于类型库的 ID
[assembly: Guid("7a1d9e7f-f057-475c-bfe2-a1d9acc3b103")]

// 程序集的版本信息由下列四个值组成: 
//
//      主版本
//      次版本
//      生成号
//      修订号
//
//可以指定所有这些值，也可以使用“生成号”和“修订号”的默认值，
// 方法是按如下所示使用“*”: :
// [assembly: AssemblyVersion("1.0.*")]

//1.0.4.0 kafka tracing日志使用bson序列化， 安全关闭kafka tracing日志记录器
//1.0.5.0 kafka tracing日志使用jil序列化
[assembly: AssemblyVersion("1.0.5.0")]
[assembly: AssemblyFileVersion("1.0.5.0")]