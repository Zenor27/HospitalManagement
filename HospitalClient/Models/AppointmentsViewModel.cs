using System.Collections.Generic;
using AppointmentsService;
using HospitalEntities.Models;

namespace HospitalClient.Models
{
    public class AppointmentsViewModel
    {
        public ICollection<Appointment> TodaysAppointments { get; set; }
        public ICollection<Appointment> AllAppointments { get; set; }
        public AddAppointmentViewModel AddAppointmentViewModel { get; set; }
        public bool OpenAddAppointmentModal { get; set; }
        public bool ShowAddAppointmentButton { get; set; }
        public bool IsStaff { get; set; }
    }
}
