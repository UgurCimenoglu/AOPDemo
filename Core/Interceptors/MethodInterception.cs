using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interceptors
{
    public class MethodInterception : MethodInterceptionBaseAttribute
    {
        public override void Intercept(IInvocation invocation)
        {
            bool isSuccess = true;
            OnBefore(invocation);
            try
            {
                invocation.Proceed();
            }
            catch (Exception ex)
            {
                isSuccess = false;
                OnException(invocation, ex);
            }
            finally
            {
                if (isSuccess)
                {
                    OnSuccess(invocation);
                }
            }
            OnAfter(invocation);
        }
        public virtual void OnBefore(IInvocation invocation) { }
        public virtual void OnAfter(IInvocation invocation) { }
        public virtual void OnException(IInvocation invocation, Exception ex) { }
        public virtual void OnSuccess(IInvocation invocation) { }
    }
}
