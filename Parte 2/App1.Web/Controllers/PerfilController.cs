using System;
using System.Threading.Tasks;
using App1.Web.Models;
using App1.Web.Models.PerfilViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace App1.Web.Controllers
{
    public class PerfilController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        private readonly SignInManager<ApplicationUser> signInManager;

        public PerfilController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        [TempData]
        public string StatusMessage { get; set; }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> Index()
        {
            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                string UserId = userManager.GetUserId(User);
                throw new Exception($"Não foi possivel identifica o usuario com o ID '{UserId}'");
            }

            var model = new IndexViewModel()
            {
                Username = user.UserName,
                Email = user.Email,
                Phonenumber = user.PhoneNumber,
                IsEmailConfirmed = user.EmailConfirmed,
                StatusMessage = StatusMessage
            };
            return View(model);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(IndexViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var user = await userManager.GetUserAsync(User);
            string UserId = userManager.GetUserId(User);

            if (user == null)
                throw new Exception($"Não foi possivel identifica o usuario com o ID '{UserId}'");

            if (user.Email != model.Email)
            {
                var setEmailResult = await userManager.SetEmailAsync(user, model.Email);
                if (!setEmailResult.Succeeded)
                    throw new Exception($"Erro ao alterar o e-mail do usuário com ID '{UserId}'");
            }

            if (user.PhoneNumber != model.Phonenumber)
            {
                var setPhoneResult = await userManager.SetPhoneNumberAsync(user, model.Phonenumber);
                if (!setPhoneResult.Succeeded)
                    throw new Exception($"Erro ao alterar o telefone do usuário com ID '{UserId}'");
            }

            StatusMessage = "Seu perfil foi atualizado!";

            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> ChangePassword()
        {
            var user = await userManager.GetUserAsync(User);


            if (user == null)
            {
                string UserId = userManager.GetUserId(User);
                throw new Exception($"Não foi possivel identifica o usuario com o ID '{UserId}'");
            }

            var model = new ChangePasswordViewModel { StatusMessage = StatusMessage };

            return View(model);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.OldPassword==model.NewPassword)
            {
                ModelState.AddModelError(string.Empty, "A nova senha não pode ser igual a antiga!");
                return View(model);
            }

            var user = await userManager.GetUserAsync(User);
            string UserId = userManager.GetUserId(User);

            if (user == null)
                throw new Exception($"Não foi possivel identifica o usuario com o ID '{UserId}'");


            var changePasswordResult = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

            if(!changePasswordResult.Succeeded)
            {
                foreach (var error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }


            await signInManager.SignInAsync(user, false);

            StatusMessage = "Sua senha foi alterada com exito!";

            return View(model);
        }
    }
}
