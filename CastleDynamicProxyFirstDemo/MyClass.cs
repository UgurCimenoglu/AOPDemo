public interface IMyClass
{
    void MyMethod();
}

public class MyClass : IMyClass
{
    [MethodInterceptorAspect(Priority = 1)]
    public virtual void MyMethod()
    {
        Console.WriteLine("MyMethod worked.");
    }

}
