﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DynamoRevitClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IDynamoRevitService")]
    public interface IDynamoRevitService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDynamoRevitService/GetData", ReplyAction="http://tempuri.org/IDynamoRevitService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDynamoRevitService/OpenFile", ReplyAction="http://tempuri.org/IDynamoRevitService/OpenFileResponse")]
        bool OpenFile(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDynamoRevitService/OpenDynamoWorkspace", ReplyAction="http://tempuri.org/IDynamoRevitService/OpenDynamoWorkspaceResponse")]
        bool OpenDynamoWorkspace(string path);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDynamoRevitService/RunDynamoExpression", ReplyAction="http://tempuri.org/IDynamoRevitService/RunDynamoExpressionResponse")]
        bool RunDynamoExpression();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDynamoRevitServiceChannel : DynamoRevitClient.ServiceReference1.IDynamoRevitService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DynamoRevitServiceClient : System.ServiceModel.ClientBase<DynamoRevitClient.ServiceReference1.IDynamoRevitService>, DynamoRevitClient.ServiceReference1.IDynamoRevitService {
        
        public DynamoRevitServiceClient() {
        }
        
        public DynamoRevitServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DynamoRevitServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DynamoRevitServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DynamoRevitServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public bool OpenFile(string path) {
            return base.Channel.OpenFile(path);
        }
        
        public bool OpenDynamoWorkspace(string path) {
            return base.Channel.OpenDynamoWorkspace(path);
        }
        
        public bool RunDynamoExpression() {
            return base.Channel.RunDynamoExpression();
        }
    }
}