using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserAPI.Models
{
    public class UserSignup : BaseModel
    {
        [Required]
        public string tcNo { get; set; }
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        public string SurName { get; set; }
        [DataType(DataType.Date)]
        public string DateOfBirth { get; set; }
        public string? City { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }
        public bool activeAccount { get; set; }
        [StringLength(256,MinimumLength =8)]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Şifre en az 8 karakter uzunluğunda olmalı ve en az 1 adet harf ve sayı içermelidir.")]
        public string password { get; set; }
    }
}
