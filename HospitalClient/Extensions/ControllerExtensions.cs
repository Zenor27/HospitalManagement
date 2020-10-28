using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;

namespace HospitalClient.Extensions
{
    public static class ControllerExtensions
    {
        [NonAction]
        public static InternalServerErrorResult InternalServerError(this Controller _) => new InternalServerErrorResult();
    }
}