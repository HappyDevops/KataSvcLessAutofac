﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kata.WcfSvcLessAutofac.Console.ExampleReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ExampleReference.IServiceContract")]
    public interface IServiceContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/PerformOperation", ReplyAction="http://tempuri.org/IServiceContract/PerformOperationResponse")]
        string PerformOperation();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceContract/PerformOperation", ReplyAction="http://tempuri.org/IServiceContract/PerformOperationResponse")]
        System.Threading.Tasks.Task<string> PerformOperationAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceContractChannel : Kata.WcfSvcLessAutofac.Console.ExampleReference.IServiceContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceContractClient : System.ServiceModel.ClientBase<Kata.WcfSvcLessAutofac.Console.ExampleReference.IServiceContract>, Kata.WcfSvcLessAutofac.Console.ExampleReference.IServiceContract {
        
        public ServiceContractClient() {
        }
        
        public ServiceContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string PerformOperation() {
            return base.Channel.PerformOperation();
        }
        
        public System.Threading.Tasks.Task<string> PerformOperationAsync() {
            return base.Channel.PerformOperationAsync();
        }
    }
}
