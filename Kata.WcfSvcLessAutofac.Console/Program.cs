namespace Kata.WcfSvcLessAutofac.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new ExampleReference.ServiceContractClient();
            var result = client.PerformOperation();
            System.Console.WriteLine(result);
            System.Console.Read();
        }
    }
}
