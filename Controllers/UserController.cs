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
        public IActionResult Login()
        {
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
    }
}
