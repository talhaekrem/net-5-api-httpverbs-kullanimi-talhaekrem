using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserAPI.Models
{
    public class UserLogin : BaseModel
    {
        [Required]
        [StringLength(11,MinimumLength =11)]
        public string tcNo { get; set; }
        [Required]
        [StringLength(256, MinimumLength = 8)]
        public string Password { get; set; }
    }
}
