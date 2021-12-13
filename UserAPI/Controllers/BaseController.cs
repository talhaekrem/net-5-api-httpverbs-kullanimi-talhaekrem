using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserAPI.Models;

namespace UserAPI.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        // örnek kullanıcı bilgileri
        public static List<UserSignup> UserList = new List<UserSignup>()
        {
            new UserSignup
            {
                Id = 1,
                tcNo = "29382910492",
                Name = "Talha",
                SurName = "Ekrem",
                City = "Sakarya",
                DateOfBirth = "24.04.1999",
                Email = "talha.ekrem.99@gmail.com",
                activeAccount = true,
                PhoneNumber = "+90 531 437 8788",
                password = "adminadmin123456"
            },
            new UserSignup
            {
                Id = 2,
                tcNo = "29382910192",
                Name = "Ahmet",
                SurName = "Mehmet",
                City = "İstanbul",
                DateOfBirth = "02.09.1991",
                Email = "ahmetmehmetm@gmail.com",
                activeAccount = true,
                PhoneNumber = "+90 543 210 1234",
                password = "ahmet3404"

            },
            new UserSignup
            {
                Id = 3,
                tcNo = "21600410498",
                Name = "Ayşe",
                SurName = "Yılmaz",
                City = "Giresun",
                DateOfBirth = "29.11.2002",
                Email = "ayseyilmaz@gmail.com",
                activeAccount = false,
                PhoneNumber = "+90 555 451 4041",
                password = "ayse12350"
            }
        };
    }
}
