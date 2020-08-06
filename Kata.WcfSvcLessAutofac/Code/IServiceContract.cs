using System.ServiceModel;

namespace Kata.WcfSvcLessAutofac.Code
{
   
    [ServiceContract]
    public interface IServiceContract
    {

        [OperationContract]
        string PerformOperation();
    }
}
