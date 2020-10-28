﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PatientService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PatientService.IPatientService")]
    public interface IPatientService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatients", ReplyAction="http://tempuri.org/IPatientService/GetPatientsResponse")]
        HospitalEntities.Models.Patient[] GetPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatients", ReplyAction="http://tempuri.org/IPatientService/GetPatientsResponse")]
        System.Threading.Tasks.Task<HospitalEntities.Models.Patient[]> GetPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatientById", ReplyAction="http://tempuri.org/IPatientService/GetPatientByIdResponse")]
        HospitalEntities.Models.Patient GetPatientById(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/GetPatientById", ReplyAction="http://tempuri.org/IPatientService/GetPatientByIdResponse")]
        System.Threading.Tasks.Task<HospitalEntities.Models.Patient> GetPatientByIdAsync(int patientId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/UpdateBackground", ReplyAction="http://tempuri.org/IPatientService/UpdateBackgroundResponse")]
        bool UpdateBackground(int id, string background);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IPatientService/UpdateBackground", ReplyAction="http://tempuri.org/IPatientService/UpdateBackgroundResponse")]
        System.Threading.Tasks.Task<bool> UpdateBackgroundAsync(int id, string background);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IPatientServiceChannel : PatientService.IPatientService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class PatientServiceClient : System.ServiceModel.ClientBase<PatientService.IPatientService>, PatientService.IPatientService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public PatientServiceClient() : 
                base(PatientServiceClient.GetDefaultBinding(), PatientServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IPatientService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PatientServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(PatientServiceClient.GetBindingForEndpoint(endpointConfiguration), PatientServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PatientServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(PatientServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PatientServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(PatientServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public PatientServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public HospitalEntities.Models.Patient[] GetPatients()
        {
            return base.Channel.GetPatients();
        }
        
        public System.Threading.Tasks.Task<HospitalEntities.Models.Patient[]> GetPatientsAsync()
        {
            return base.Channel.GetPatientsAsync();
        }
        
        public HospitalEntities.Models.Patient GetPatientById(int patientId)
        {
            return base.Channel.GetPatientById(patientId);
        }
        
        public System.Threading.Tasks.Task<HospitalEntities.Models.Patient> GetPatientByIdAsync(int patientId)
        {
            return base.Channel.GetPatientByIdAsync(patientId);
        }
        
        public bool UpdateBackground(int id, string background)
        {
            return base.Channel.UpdateBackground(id, background);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateBackgroundAsync(int id, string background)
        {
            return base.Channel.UpdateBackgroundAsync(id, background);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPatientService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IPatientService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52107/Services/PatientService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return PatientServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IPatientService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return PatientServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IPatientService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IPatientService,
        }
    }
}
