using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebJWTToken.App_Code.MiddleLayer;
using WebJWTToken.Models;

namespace WebJWTToken.Controllers
{
    [Authorize]
   [ApiController]
   [Route("/v1/")]
    public class CustomeAPIController : ControllerBase
    {
        private readonly IJWTManagerRepository _jWTManager;

        public CustomeAPIController(IJWTManagerRepository jWTManager)
        {
            _jWTManager = jWTManager;

        }

        [HttpGet]
        [Route("get")]
        public List<string> Get()
        {
            var users = new List<string>
        {
            "Satinder Singh",
            "Amit Sarna",
            "Davin Jon"
        };

            return users;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("authenticate")]
        public IActionResult Authenticate(Users usersdata)
        {
            var token = _jWTManager.Authenticate(usersdata);

            if (token == null)
            {
                return Unauthorized();
            }

            return Ok(token);
        }
    }
}
