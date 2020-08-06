using JetBrains.Annotations;

namespace Kata.WcfSvcLessAutofac.Code
{
    [UsedImplicitly]
    public class ExampleService : IServiceContract
    {
        public string PerformOperation()
        {
            return "Service Working!";
        }
    }
}