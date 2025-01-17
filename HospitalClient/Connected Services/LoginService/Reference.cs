﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LoginService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="LoginService.ILoginService")]
    public interface ILoginService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Login", ReplyAction="http://tempuri.org/ILoginService/LoginResponse")]
        HospitalServer.Dto.LoginResponse Login(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Login", ReplyAction="http://tempuri.org/ILoginService/LoginResponse")]
        System.Threading.Tasks.Task<HospitalServer.Dto.LoginResponse> LoginAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Signup", ReplyAction="http://tempuri.org/ILoginService/SignupResponse")]
        bool Signup(string email, string password, string firstName, string lastName, string address, string phoneNumber, string background);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ILoginService/Signup", ReplyAction="http://tempuri.org/ILoginService/SignupResponse")]
        System.Threading.Tasks.Task<bool> SignupAsync(string email, string password, string firstName, string lastName, string address, string phoneNumber, string background);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ILoginServiceChannel : LoginService.ILoginService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class LoginServiceClient : System.ServiceModel.ClientBase<LoginService.ILoginService>, LoginService.ILoginService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public LoginServiceClient() : 
                base(LoginServiceClient.GetDefaultBinding(), LoginServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ILoginService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LoginServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(LoginServiceClient.GetBindingForEndpoint(endpointConfiguration), LoginServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LoginServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(LoginServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LoginServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(LoginServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public LoginServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public HospitalServer.Dto.LoginResponse Login(string email, string password)
        {
            return base.Channel.Login(email, password);
        }
        
        public System.Threading.Tasks.Task<HospitalServer.Dto.LoginResponse> LoginAsync(string email, string password)
        {
            return base.Channel.LoginAsync(email, password);
        }
        
        public bool Signup(string email, string password, string firstName, string lastName, string address, string phoneNumber, string background)
        {
            return base.Channel.Signup(email, password, firstName, lastName, address, phoneNumber, background);
        }
        
        public System.Threading.Tasks.Task<bool> SignupAsync(string email, string password, string firstName, string lastName, string address, string phoneNumber, string background)
        {
            return base.Channel.SignupAsync(email, password, firstName, lastName, address, phoneNumber, background);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ILoginService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ILoginService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52107/Services/LoginService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return LoginServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ILoginService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return LoginServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ILoginService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ILoginService,
        }
    }
}
