using Autofac;
using InterceptionAutofac;


var builder = new ContainerBuilder();
builder.RegisterModule(new DefaultModule());
var container = builder.Build();
var willBeIntercepted = container.Resolve<IEmployeeService>();

willBeIntercepted.Add(new()
{
    Id = 1,
    FirstName = "Ugur",
    LastName = "Cimen",
    Gender = 'E'
});

Console.ReadKey();




