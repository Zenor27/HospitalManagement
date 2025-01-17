﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StatisticsService
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StatisticsService.IStatisticsService")]
    public interface IStatisticsService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetTotalAppointments", ReplyAction="http://tempuri.org/IStatisticsService/GetTotalAppointmentsResponse")]
        int GetTotalAppointments(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetTotalAppointments", ReplyAction="http://tempuri.org/IStatisticsService/GetTotalAppointmentsResponse")]
        System.Threading.Tasks.Task<int> GetTotalAppointmentsAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetNewAppointmentsIn24Hours", ReplyAction="http://tempuri.org/IStatisticsService/GetNewAppointmentsIn24HoursResponse")]
        int GetNewAppointmentsIn24Hours(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetNewAppointmentsIn24Hours", ReplyAction="http://tempuri.org/IStatisticsService/GetNewAppointmentsIn24HoursResponse")]
        System.Threading.Tasks.Task<int> GetNewAppointmentsIn24HoursAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetComingNextAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetComingNextAppointmentsNumberResponse")]
        int GetComingNextAppointmentsNumber(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetComingNextAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetComingNextAppointmentsNumberResponse")]
        System.Threading.Tasks.Task<int> GetComingNextAppointmentsNumberAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetComingNextAppointment", ReplyAction="http://tempuri.org/IStatisticsService/GetComingNextAppointmentResponse")]
        HospitalEntities.Models.Appointment GetComingNextAppointment(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetComingNextAppointment", ReplyAction="http://tempuri.org/IStatisticsService/GetComingNextAppointmentResponse")]
        System.Threading.Tasks.Task<HospitalEntities.Models.Appointment> GetComingNextAppointmentAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetAvailableDoctorsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetAvailableDoctorsNumberResponse")]
        int GetAvailableDoctorsNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetAvailableDoctorsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetAvailableDoctorsNumberResponse")]
        System.Threading.Tasks.Task<int> GetAvailableDoctorsNumberAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetLast24HoursAvailableDoctors", ReplyAction="http://tempuri.org/IStatisticsService/GetLast24HoursAvailableDoctorsResponse")]
        int GetLast24HoursAvailableDoctors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetLast24HoursAvailableDoctors", ReplyAction="http://tempuri.org/IStatisticsService/GetLast24HoursAvailableDoctorsResponse")]
        System.Threading.Tasks.Task<int> GetLast24HoursAvailableDoctorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetApprovalWaitingAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetApprovalWaitingAppointmentsNumberRespons" +
            "e")]
        int GetApprovalWaitingAppointmentsNumber(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetApprovalWaitingAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetApprovalWaitingAppointmentsNumberRespons" +
            "e")]
        System.Threading.Tasks.Task<int> GetApprovalWaitingAppointmentsNumberAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetLast24HoursWaitingAppointments", ReplyAction="http://tempuri.org/IStatisticsService/GetLast24HoursWaitingAppointmentsResponse")]
        int GetLast24HoursWaitingAppointments(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetLast24HoursWaitingAppointments", ReplyAction="http://tempuri.org/IStatisticsService/GetLast24HoursWaitingAppointmentsResponse")]
        System.Threading.Tasks.Task<int> GetLast24HoursWaitingAppointmentsAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetTotalHospitalPatients", ReplyAction="http://tempuri.org/IStatisticsService/GetTotalHospitalPatientsResponse")]
        int GetTotalHospitalPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetTotalHospitalPatients", ReplyAction="http://tempuri.org/IStatisticsService/GetTotalHospitalPatientsResponse")]
        System.Threading.Tasks.Task<int> GetTotalHospitalPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetLast24HoursNewPatients", ReplyAction="http://tempuri.org/IStatisticsService/GetLast24HoursNewPatientsResponse")]
        int GetLast24HoursNewPatients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetLast24HoursNewPatients", ReplyAction="http://tempuri.org/IStatisticsService/GetLast24HoursNewPatientsResponse")]
        System.Threading.Tasks.Task<int> GetLast24HoursNewPatientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetTodayAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetTodayAppointmentsNumberResponse")]
        int GetTodayAppointmentsNumber(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetTodayAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetTodayAppointmentsNumberResponse")]
        System.Threading.Tasks.Task<int> GetTodayAppointmentsNumberAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetNumberOfAppointmentsCompareToYesterday", ReplyAction="http://tempuri.org/IStatisticsService/GetNumberOfAppointmentsCompareToYesterdayRe" +
            "sponse")]
        int GetNumberOfAppointmentsCompareToYesterday(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetNumberOfAppointmentsCompareToYesterday", ReplyAction="http://tempuri.org/IStatisticsService/GetNumberOfAppointmentsCompareToYesterdayRe" +
            "sponse")]
        System.Threading.Tasks.Task<int> GetNumberOfAppointmentsCompareToYesterdayAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetMonthAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetMonthAppointmentsNumberResponse")]
        System.Collections.Generic.Dictionary<string, int> GetMonthAppointmentsNumber(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetMonthAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetMonthAppointmentsNumberResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> GetMonthAppointmentsNumberAsync(HospitalEntities.Models.UserTypeEnum userType, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetHospitalMonthAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetHospitalMonthAppointmentsNumberResponse")]
        System.Collections.Generic.Dictionary<string, int> GetHospitalMonthAppointmentsNumber();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStatisticsService/GetHospitalMonthAppointmentsNumber", ReplyAction="http://tempuri.org/IStatisticsService/GetHospitalMonthAppointmentsNumberResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> GetHospitalMonthAppointmentsNumberAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IStatisticsServiceChannel : StatisticsService.IStatisticsService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class StatisticsServiceClient : System.ServiceModel.ClientBase<StatisticsService.IStatisticsService>, StatisticsService.IStatisticsService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public StatisticsServiceClient() : 
                base(StatisticsServiceClient.GetDefaultBinding(), StatisticsServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IStatisticsService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StatisticsServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(StatisticsServiceClient.GetBindingForEndpoint(endpointConfiguration), StatisticsServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StatisticsServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(StatisticsServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StatisticsServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(StatisticsServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StatisticsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public int GetTotalAppointments(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetTotalAppointments(userType, userId);
        }
        
        public System.Threading.Tasks.Task<int> GetTotalAppointmentsAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetTotalAppointmentsAsync(userType, userId);
        }
        
        public int GetNewAppointmentsIn24Hours(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetNewAppointmentsIn24Hours(userType, userId);
        }
        
        public System.Threading.Tasks.Task<int> GetNewAppointmentsIn24HoursAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetNewAppointmentsIn24HoursAsync(userType, userId);
        }
        
        public int GetComingNextAppointmentsNumber(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetComingNextAppointmentsNumber(userType, userId);
        }
        
        public System.Threading.Tasks.Task<int> GetComingNextAppointmentsNumberAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetComingNextAppointmentsNumberAsync(userType, userId);
        }
        
        public HospitalEntities.Models.Appointment GetComingNextAppointment(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetComingNextAppointment(userType, userId);
        }
        
        public System.Threading.Tasks.Task<HospitalEntities.Models.Appointment> GetComingNextAppointmentAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetComingNextAppointmentAsync(userType, userId);
        }
        
        public int GetAvailableDoctorsNumber()
        {
            return base.Channel.GetAvailableDoctorsNumber();
        }
        
        public System.Threading.Tasks.Task<int> GetAvailableDoctorsNumberAsync()
        {
            return base.Channel.GetAvailableDoctorsNumberAsync();
        }
        
        public int GetLast24HoursAvailableDoctors()
        {
            return base.Channel.GetLast24HoursAvailableDoctors();
        }
        
        public System.Threading.Tasks.Task<int> GetLast24HoursAvailableDoctorsAsync()
        {
            return base.Channel.GetLast24HoursAvailableDoctorsAsync();
        }
        
        public int GetApprovalWaitingAppointmentsNumber(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetApprovalWaitingAppointmentsNumber(userType, userId);
        }
        
        public System.Threading.Tasks.Task<int> GetApprovalWaitingAppointmentsNumberAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetApprovalWaitingAppointmentsNumberAsync(userType, userId);
        }
        
        public int GetLast24HoursWaitingAppointments(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetLast24HoursWaitingAppointments(userType, userId);
        }
        
        public System.Threading.Tasks.Task<int> GetLast24HoursWaitingAppointmentsAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetLast24HoursWaitingAppointmentsAsync(userType, userId);
        }
        
        public int GetTotalHospitalPatients()
        {
            return base.Channel.GetTotalHospitalPatients();
        }
        
        public System.Threading.Tasks.Task<int> GetTotalHospitalPatientsAsync()
        {
            return base.Channel.GetTotalHospitalPatientsAsync();
        }
        
        public int GetLast24HoursNewPatients()
        {
            return base.Channel.GetLast24HoursNewPatients();
        }
        
        public System.Threading.Tasks.Task<int> GetLast24HoursNewPatientsAsync()
        {
            return base.Channel.GetLast24HoursNewPatientsAsync();
        }
        
        public int GetTodayAppointmentsNumber(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetTodayAppointmentsNumber(userType, userId);
        }
        
        public System.Threading.Tasks.Task<int> GetTodayAppointmentsNumberAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetTodayAppointmentsNumberAsync(userType, userId);
        }
        
        public int GetNumberOfAppointmentsCompareToYesterday(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetNumberOfAppointmentsCompareToYesterday(userType, userId);
        }
        
        public System.Threading.Tasks.Task<int> GetNumberOfAppointmentsCompareToYesterdayAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetNumberOfAppointmentsCompareToYesterdayAsync(userType, userId);
        }
        
        public System.Collections.Generic.Dictionary<string, int> GetMonthAppointmentsNumber(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetMonthAppointmentsNumber(userType, userId);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> GetMonthAppointmentsNumberAsync(HospitalEntities.Models.UserTypeEnum userType, int userId)
        {
            return base.Channel.GetMonthAppointmentsNumberAsync(userType, userId);
        }
        
        public System.Collections.Generic.Dictionary<string, int> GetHospitalMonthAppointmentsNumber()
        {
            return base.Channel.GetHospitalMonthAppointmentsNumber();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.Dictionary<string, int>> GetHospitalMonthAppointmentsNumberAsync()
        {
            return base.Channel.GetHospitalMonthAppointmentsNumberAsync();
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStatisticsService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStatisticsService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:52107/Services/StatisticsService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return StatisticsServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IStatisticsService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return StatisticsServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IStatisticsService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IStatisticsService,
        }
    }
}
