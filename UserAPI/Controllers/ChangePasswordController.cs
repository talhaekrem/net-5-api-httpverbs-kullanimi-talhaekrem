using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ChangePasswordController : BaseController
    {
        //şifre değiştirme işlemi. route üzerinden bilgi almıyorum. bodyden tc alıp sonra yine bodyden şifre ile değiştirme işlemini yapıyorum.
        [HttpPut]
        public IActionResult changePasword([FromBody] UserSignup newpassword)
        {
            var user = UserList.SingleOrDefault(u => u.tcNo == newpassword.tcNo);
            //tcno eşleşmiyorsa not found
            if (user == null)
            {
                return NotFound();
            }
            //tc no eşleşiyorsa...
            else
            {
                //yeni şifre regexe uyuyorsa ve eski şifreyle aynı değilse ve boş değilse
                var regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
                if (newpassword.password != user.password && newpassword.password != "" && regex.IsMatch(newpassword.password))
                {
                    user.password = newpassword.password;
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }

            }
        }
    }
}
