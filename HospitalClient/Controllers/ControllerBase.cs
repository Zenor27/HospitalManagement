using System.ComponentModel;
using System.Linq;
using System.Security.Claims;
using HospitalClient.Extensions;
using HospitalEntities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalClient.Controllers
{
    public abstract class ControllerBase : Controller
    {
        protected int CurrentUserId => Utils.User.GetCurrentUserId(HttpContext);
        protected string CurrentUserRole => User.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role)?.Value;
        protected bool IsCurrentUserStaff => User.IsInRole(UserRole.STAFF);
        protected bool IsCurrentUserPatient => User.IsInRole(UserRole.PATIENT);
        protected UserTypeEnum CurrentUserType => EnumExtensions.FindValueWithDescription<UserTypeEnum>(CurrentUserRole);
    }
}