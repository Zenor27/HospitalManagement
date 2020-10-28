using HospitalEntities.Models;
using System.Collections.Generic;

namespace HospitalClient.Models
{
    public class RequestsViewModel
    {
        public RequestsViewModel()
        {
            AddRequestViewModel = new AddRequestViewModel();
        }

        public ICollection<Appointment> AppointmentsWait { get; set; }
        public ICollection<Appointment> AppointmentsAccepted { get; set; }
        public ICollection<Appointment> AppointmentsRefused { get; set; }
        public AddRequestViewModel AddRequestViewModel { get; set; }
        public bool OpenAddRequestModal { get; set; }
        public bool CanAcceptOrRefuseAppointments { get; set; }
        public bool IsStaff { get; set; }
    }
}
