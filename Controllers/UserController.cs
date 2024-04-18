using CHECKPOINT2_DOTNET.Data;
using CHECKPOINT2_DOTNET.DTOs;
using CHECKPOINT2_DOTNET.Models;
using Microsoft.AspNetCore.Mvc;

namespace CHECKPOINT2_DOTNET.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly DataContext _dataContext;

        public UserController(ILogger<UserController> logger, DataContext dataContext)
        {
            _dataContext = dataContext;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Members()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult DeleteView()
        {
            return View();
        }

        public IActionResult DataUpdateView()
        {
            return View();
        }

        public IActionResult UpdateView(EmailDataDTO request)
        {
            var user = _dataContext.UserFiap.FirstOrDefault(x => x.UserEmail == request.UserEmail);
            if (request.UserEmail == null)
            {
                return BadRequest("Usuário não existe");
            }

            return View();
        }

        public IActionResult Register(RegisterDTO request)
        {
            var user = _dataContext.UserFiap.FirstOrDefault(x => x.UserEmail == request.UserEmail);
            if (user != null)
            {
                return BadRequest("Usuário ja existe");
            }
            User NewUser = new User
            {
                UserEmail = request.UserEmail,
                UserName = request.UserName,
                UserPassword = request.UserPassword,
                UserPhone = request.UserPhone,
            };
            _dataContext.Add(NewUser);
            _dataContext.SaveChanges();
            return View();
        }

        public IActionResult LoginMethod(LoginDTO request)
        {
            var user = _dataContext.UserFiap.FirstOrDefault(x => x.UserEmail == request.UserEmail);
            if (user == null)
            {
                return NotFound();
            }
            if (user.UserPassword != request.UserPassword)
            {
                return BadRequest("Senha inválida");
            }
            ViewBag.userData = user;
            return RedirectToAction("Members", "User");
        }

        public IActionResult Delete(DeleteDTO request)
        {
            var user = _dataContext.UserFiap.FirstOrDefault(x => x.UserEmail == request.UserEmail);
            if (user == null)
            {
                return BadRequest("Esse email não está cadastrado");
            }
           
            _dataContext.Remove(user);
            _dataContext.SaveChanges();
            return View();
        }

        public IActionResult Update(UpdateDTO request)
        {
            var user = _dataContext.UserFiap.FirstOrDefault(x => x.UserEmail == request.UserEmail);   
            if (user == null)
            {
               return BadRequest("Usuário não existe");
            }

            user.UserEmail = request.UserEmail;
            user.UserName = request.UserName;
            user.UserPassword = request.UserPassword;
            user.UserPhone = request.UserPhone;
            

            _dataContext.Update(user);
            _dataContext.SaveChanges();
            return View();
        }



    }
}
