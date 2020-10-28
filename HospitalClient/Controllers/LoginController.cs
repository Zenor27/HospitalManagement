using System.Diagnostics;
using HospitalClient.Utils;
using LoginService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using HospitalClient.Extensions;
using HospitalClient.Models;
using HospitalEntities.Models;

namespace HospitalClient.Controllers
{
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginClient;

        public LoginController(ILoginService loginClient)
        {
            _loginClient = loginClient;
        }

        public IActionResult Index()
        {
            return View(new SignUpViewModel());
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", new SignUpViewModel { Email = model.Email });
            }

            var email = model.Email;
            var password = model.Password;
            var user = _loginClient.Login(email, password);
            // Check if user exists
            if (user == null)
            {
                ModelState.AddModelError("", "Invalid Account");
                return View("Index", new SignUpViewModel { Email = model.Email });
            }

            // Create new identity for current user
            var identity = new ClaimsIdentity(
                new[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                    new Claim(ClaimTypes.Name, $"{user.FirstName} {user.LastName}"),
                    new Claim(ClaimTypes.Role, user.UserType.GetDescription())
                },
                CookieAuthenticationDefaults.AuthenticationScheme);

            // Sign in and redirect to home page
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(identity), new AuthenticationProperties { IsPersistent = true });
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        [Route("signup")]
        public ActionResult SignUp(SignUpViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }

            var isCreated = _loginClient.Signup(model.Email,
                                                Password.Hash(model.Password),
                                                model.FirstName,
                                                model.LastName,
                                                model.Address,
                                                model.PhoneNumber,
                                                null);
            if (!isCreated)
            {
                ModelState.AddModelError("", "User already exists");
            }
            else
            {
                ViewBag.success = "User created !";
            }

            return View("Index", model);
        }

        [HttpPost]
        [Route("signout")]
        public async Task<ActionResult> SignOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index", "Login");
        }
    }
}