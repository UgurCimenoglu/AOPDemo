using Autofac;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Interceptors;

var proxy = new ProxyGenerator();
var aspect = proxy.CreateClassProxy<MyClass>(new MethodInterceptorAspect());
aspect.MyMethod();

Console.ReadKey();