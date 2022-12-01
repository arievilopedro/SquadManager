using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using SquadManager.Models;
using SquadManager.Validator;

namespace SquadManager.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            UserViewModel user = new UserViewModel();

            UserValidator validator = new UserValidator();

            ValidationResult result = validator.Validate(user);

            if (!result.IsValid)
            {
                foreach(var failure in result.Errors) 
                {
                    Console.WriteLine("Falhou na validação" + " ");
                }
            }

            return View("Index", user);
        }

        [HttpPost]
        public IActionResult Test(UserViewModel user)
        {
            user.Email = "email enviado";

            return View("Index", user);
        }
    }
}
