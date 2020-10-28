using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace HospitalClient.Extensions
{
    [DefaultStatusCode(DefaultStatusCode)]
    public class InternalServerErrorResult : StatusCodeResult
    {
        private const int DefaultStatusCode = StatusCodes.Status500InternalServerError;

        public InternalServerErrorResult() : base(DefaultStatusCode)
        {
        }
    }
}