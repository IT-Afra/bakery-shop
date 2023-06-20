using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;

namespace Bakeryshop.Domain.Dtos
{
    public class DeliveryDto
    {
        [Display(Name = "نام")]
        [MaxLength(100, ErrorMessage = ErrorReource.MaxLength)]
        public string? Name { get; set; } = null!;

        [Display(Name = "نام خانوادگی")]
        [MaxLength(100, ErrorMessage = ErrorReource.MaxLength)]
        public string? Family { get; set; } = null!;

        [Display(Name = "آدرس")]
        [MaxLength(250, ErrorMessage = ErrorReource.MaxLength)]
        public string? Address { get; set; } = null!;

        [Display(Name = "شماره تلفن")]
        [MaxLength(15, ErrorMessage = ErrorReource.MaxLength)]
        [Required(ErrorMessage = ErrorReource.Required)]
        public string? PhoneNumber { get; set; } = null!;

        [Display(Name = "نوع نان")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(100, ErrorMessage = ErrorReource.MaxLength)]
        public string? TypeBreadName { get; set; } = null!;

        [Display(Name = "تعداد سفارش")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public int? DeliveryAmount { get; set; }
    }
}
