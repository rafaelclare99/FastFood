using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
        }

        public IActionResult Login(String returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return View(loginVM);


            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginVM.ReturnUrl))
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    return View(loginVM.ReturnUrl);
                }
            }
            ModelState.AddModelError("", "falaha ao realizar o login ");
            return View(loginVM);


        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] //evita ataque CSRF 
        public async Task<IActionResult> Register(LoginViewModel RegistroVM)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser { UserName = RegistroVM.UserName };
                var result = await _userManager.CreateAsync(user, RegistroVM.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }
                else 
                {
                    this.ModelState.AddModelError("Registro", "Falha ao cadastrar o usuario");
                }

            }
            return View(RegistroVM);
        }



    }
}
