using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class UserController : BaseController
    {
        //get işlemleri
        //tüm üyeleri getir
        [HttpGet]
        public List<UserSignup> GetAll()
        {
            return UserList;
        }
        //idye göre 1 tane üyeyi getir
        [HttpGet("{id}")]
        public UserSignup GetById(int id)
        {
            return UserList.Where(user => user.Id == id).SingleOrDefault();
        }

        //signup işlemi
        [HttpPost]
        public IActionResult signUp([FromBody] UserSignup newUser)
        {
            var user = UserList.SingleOrDefault(u => u.Id == newUser.Id);
            if (user != null)
            {
                return BadRequest();
            }
            else
            {
                newUser.createTime = DateTime.Now;
                UserList.Add(newUser);
                return Ok();
            }
        }
        //put güncelleme işlemi
        [HttpPut("{id}")]
        public IActionResult updateUser(int id, [FromBody] UserSignup updatedUser)
        {
            var user = UserList.SingleOrDefault(u => u.Id == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                //güncelleme işleminde boş bırakılan değer varsa onu önceki haliyle kullan diyoruz. eğer boş bırakılmamışsa güncel veriyi kullan.
                user.tcNo = updatedUser.tcNo != "" ? updatedUser.tcNo : user.tcNo;
                user.Name = updatedUser.Name != "" ? updatedUser.Name : user.Name;
                user.SurName = updatedUser.SurName != "" ? updatedUser.SurName : user.SurName;
                user.DateOfBirth = updatedUser.DateOfBirth != "" ? updatedUser.DateOfBirth : user.DateOfBirth;
                user.PhoneNumber = updatedUser.PhoneNumber != "" ? updatedUser.PhoneNumber : user.PhoneNumber;
                user.Email = updatedUser.Email != "" ? updatedUser.Email : user.Email;
                user.City = updatedUser.City != "" ? updatedUser.City : user.City;
                user.activeAccount = updatedUser.activeAccount;
                return Ok();
            }
        }
        //delete kullanıcıyı silme işlemi
        [HttpDelete("{id}")]
        public IActionResult deleteUser(int id)
        {
            var user = UserList.SingleOrDefault(u => u.Id == id);
            if(user == null)
            {
                return NotFound();
            }
            else
            {
                UserList.Remove(user);
                return Ok();
            }
        }
    }
}