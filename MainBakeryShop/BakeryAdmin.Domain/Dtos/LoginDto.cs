using Bakeryshop.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryAdmin.Domain.Dtos
{
    public class LoginDto
    {
        [Display(Name = "نام کاربری")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(100, ErrorMessage = ErrorReource.MaxLength)]
        public string? UserName { get; set; }

        [Display(Name = "کلمه عبور")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(50, ErrorMessage = ErrorReource.MaxLength)]
        public string? Password { get; set; }
    }
}
