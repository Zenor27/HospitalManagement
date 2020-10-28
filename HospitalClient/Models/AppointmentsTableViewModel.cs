using System;
using System.Collections;
using System.Collections.Generic;
using HospitalEntities.Models;
using Microsoft.AspNetCore.Html;

namespace HospitalClient.Models
{
    public class AppointmentsTableViewModel
    {
        public IEnumerable<Appointment> Appointments { get; set; }
        public bool ShowStaff { get; set; }
        public bool ShowPatient { get; set; }
        public bool CanAcceptOrRefuseAppointments { get; set; }
        public Func<Appointment, IHtmlContent> AppointmentAttributes { get; set; }
        public string TableBodyId { get; set; }
    }
}