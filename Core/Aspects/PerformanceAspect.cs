using Castle.DynamicProxy;
using Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects
{
    public class PerformanceAspect : MethodInterception
    {
        private readonly Stopwatch _stopwatch;

        public PerformanceAspect()
        {
            _stopwatch = new();
        }
        public override void OnBefore(IInvocation invocation)
        {
            _stopwatch.Start();
        }
        public override void OnAfter(IInvocation invocation)
        {
            Console.WriteLine($"Method {_stopwatch.Elapsed.TotalSeconds} saniye çalıştı");
            _stopwatch?.Reset();
        }
    }
}
