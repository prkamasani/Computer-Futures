﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HellowWorld_Application.EvalServiceJson {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="EvalServiceJson.IEvalSeviceJSON")]
    public interface IEvalSeviceJSON {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalSeviceJSON/HellowworldGet", ReplyAction="http://tempuri.org/IEvalSeviceJSON/HellowworldGetResponse")]
        string HellowworldGet();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalSeviceJSON/HellowworldGet", ReplyAction="http://tempuri.org/IEvalSeviceJSON/HellowworldGetResponse")]
        System.Threading.Tasks.Task<string> HellowworldGetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalSeviceJSON/HellowworldPost", ReplyAction="http://tempuri.org/IEvalSeviceJSON/HellowworldPostResponse")]
        string HellowworldPost();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEvalSeviceJSON/HellowworldPost", ReplyAction="http://tempuri.org/IEvalSeviceJSON/HellowworldPostResponse")]
        System.Threading.Tasks.Task<string> HellowworldPostAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEvalSeviceJSONChannel : HellowWorld_Application.EvalServiceJson.IEvalSeviceJSON, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EvalSeviceJSONClient : System.ServiceModel.ClientBase<HellowWorld_Application.EvalServiceJson.IEvalSeviceJSON>, HellowWorld_Application.EvalServiceJson.IEvalSeviceJSON {
        
        public EvalSeviceJSONClient() {
        }
        
        public EvalSeviceJSONClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EvalSeviceJSONClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvalSeviceJSONClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EvalSeviceJSONClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string HellowworldGet() {
            return base.Channel.HellowworldGet();
        }
        
        public System.Threading.Tasks.Task<string> HellowworldGetAsync() {
            return base.Channel.HellowworldGetAsync();
        }
        
        public string HellowworldPost() {
            return base.Channel.HellowworldPost();
        }
        
        public System.Threading.Tasks.Task<string> HellowworldPostAsync() {
            return base.Channel.HellowworldPostAsync();
        }
    }
}
