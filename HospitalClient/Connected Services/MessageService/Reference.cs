﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MessageService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MessageService.IMessageService")]
    public interface IMessageService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetLastMessages", ReplyAction="http://tempuri.org/IMessageService/GetLastMessagesResponse")]
        HospitalEntities.Models.Message[] GetLastMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetLastMessages", ReplyAction="http://tempuri.org/IMessageService/GetLastMessagesResponse")]
        System.Threading.Tasks.Task<HospitalEntities.Models.Message[]> GetLastMessagesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/AddMessage", ReplyAction="http://tempuri.org/IMessageService/AddMessageResponse")]
        System.Nullable<HospitalServer.Dto.ResponseErrorEnum> AddMessage(string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/AddMessage", ReplyAction="http://tempuri.org/IMessageService/AddMessageResponse")]
        System.Threading.Tasks.Task<System.Nullable<HospitalServer.Dto.ResponseErrorEnum>> AddMessageAsync(string description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetMessages", ReplyAction="http://tempuri.org/IMessageService/GetMessagesResponse")]
        HospitalEntities.Models.Message[] GetMessages();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMessageService/GetMessages", ReplyAction="http://tempuri.org/IMessageService/GetMessagesResponse")]
        System.Threading.Tasks.Task<HospitalEntities.Models.Message[]> GetMessagesAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IMessageServiceChannel : MessageService.IMessageService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class MessageServiceClient : System.ServiceModel.ClientBase<MessageService.IMessageService>, MessageService.IMessageService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public MessageServiceClient() : 
                base(MessageServiceClient.GetDefaultBinding(), MessageServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IMessageService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MessageServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(MessageServiceClient.GetBindingForEndpoint(endpointConfiguration), MessageServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MessageServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(MessageServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MessageServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(MessageServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public MessageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public HospitalEntities.Models.Message[] GetLastMessages()
        {
            return base.Channel.GetLastMessages();
        }
        
        public System.Threading.Tasks.Task<HospitalEntities.Models.Message[]> GetLastMessagesAsync()
        {
            return base.Channel.GetLastMessagesAsync();
        }
        
        public System.Nullable<HospitalServer.Dto.ResponseErrorEnum> AddMessage(string description)
        {
            return base.Channel.AddMessage(description);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<HospitalServer.Dto.ResponseErrorEnum>> AddMessageAsync(string description)
        {
            return base.Channel.AddMessageAsync(description);
        }
        
        public HospitalEntities.Models.Message[] GetMessages()
        {
            return base.Channel.GetMessages();
        }
        
        public System.Threading.Tasks.Task<HospitalEntities.Models.Message[]> GetMessagesAsync()
        {
            return base.Channel.GetMessagesAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMessageService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IMessageService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52107/Services/MessageService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return MessageServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IMessageService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return MessageServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IMessageService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IMessageService,
        }
    }
}
