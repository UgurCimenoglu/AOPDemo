using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects
{
    public class LoggingAspect : MethodInterception
    {
        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine($"{invocation.Method.Name} {DateTime.Now} anında çalıştı.");
        }
    }
}
