using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UserAPI.Models
{
    public class BaseModel
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime createTime { get; set; }
    }
}
