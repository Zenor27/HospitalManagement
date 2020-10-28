using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HospitalClient.Extensions;
using HospitalClient.Models;
using HospitalEntities.Models;
using Microsoft.AspNetCore.Mvc;
using HospitalServer.Dto;
using HospitalServer.Requests;
using MessageService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StaffService;

namespace HospitalClient.Controllers
{
    [Authorize(UserRole.STAFF)]
    public class AdminController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IMessageService _messageService;

        public AdminController(IStaffService staffService, IMessageService messageService)
        {
            _staffService = staffService;
            _messageService = messageService;
        }

        public IActionResult Index(AdminTabEnum? tab = null)
        {
            var model = new AdminViewModel();
            FillAdminViewModel(model);

            if (tab.HasValue)
            {
                model.Tab = tab.Value;
            }

            return View(model);
        }

        private void FillAdminViewModel(AdminViewModel model)
        {
            model.Staffs = _staffService.GetStaffs().OrderBy(s => s.FullName).ToList();
            model.Messages = _messageService.GetMessages().OrderByDescending(m => m.CreatedAt).ToList();
        }

        [HttpPost]
        public IActionResult AddStaff(AddStaffViewModel model)
        {
            if (ModelState.IsValid)
            {
                Debug.Assert(model.StaffType != null, "model.StaffType != null");

                var error = _staffService.AddStaff(new AddStaffRequest
                {
                    Password = model.Password,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    StaffType = model.StaffType.Value,
                    PhoneNumber = model.PhoneNumber,
                    Address = model.Address
                });

                switch (error)
                {
                    case null:
                        return RedirectToAction("Index");

                    case ResponseErrorEnum.EmailAlreadyUsed:
                        ModelState.AddModelError(nameof(model.Email), "This email is already used.");
                        break;

                    default:
                        return this.InternalServerError();
                }
            }

            var indexModel = new AdminViewModel();
            FillAdminViewModel(indexModel);
            indexModel.AddStaffViewModel = model;
            indexModel.OpenAddStaffModal = true;
            return View("Index", indexModel);
        }

        [HttpPost]
        public IActionResult AddMessage(AddMessageViewModel model)
        {
            if (ModelState.IsValid)
            {
                var error = _messageService.AddMessage(model.Description);

                switch (error)
                {
                    case null:
                        return RedirectToAction("Index", new { tab = AdminTabEnum.MESSAGES });

                    default:
                        return this.InternalServerError();
                }
            }

            var indexModel = new AdminViewModel();
            FillAdminViewModel(indexModel);
            indexModel.AddMessageViewModel = model;
            indexModel.OpenAddMessageModal = true;
            indexModel.Tab = AdminTabEnum.MESSAGES;
            return View("Index", indexModel);
        }
    }
}