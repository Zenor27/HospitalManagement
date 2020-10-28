using System.Collections.Generic;
using HospitalEntities.Models;

namespace HospitalClient.Models
{
    public enum AdminTabEnum
    {
        STAFFS,
        MESSAGES
    }

    public class AdminViewModel
    {
        public AdminViewModel()
        {
            AddStaffViewModel = new AddStaffViewModel();
            AddMessageViewModel = new AddMessageViewModel();
            Tab = AdminTabEnum.STAFFS;
        }

        public IEnumerable<Staff> Staffs { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public AddStaffViewModel AddStaffViewModel { get; set; }
        public AddMessageViewModel AddMessageViewModel { get; set; }
        public bool OpenAddStaffModal { get; set; }
        public bool OpenAddMessageModal { get; set; }
        public AdminTabEnum Tab { get; set; }
    }
}