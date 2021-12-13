using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : BaseController
    {

        //login işlemi ve validasyonlar
        [HttpPost]
        public IActionResult login([FromBody] UserLogin userlogin)
        {
            var user = UserList.SingleOrDefault(u => u.tcNo == userlogin.tcNo);
            if(user == null)
            {
                return NotFound();
            }
            else
            {
                if(userlogin.Password == user.password)
                {
                    return Ok();
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
