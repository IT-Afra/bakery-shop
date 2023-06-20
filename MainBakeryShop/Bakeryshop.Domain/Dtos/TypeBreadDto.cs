using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;

namespace Bakeryshop.Domain.Dtos
{
    public class TypeBreadDto
    {
        [Display(Name= "شناسه")]
        public long? Id { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(100, ErrorMessage = ErrorReource.MaxLength)]
        public string? Name { get; set; } = null!;

        [Display(Name = "تصویر")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(50, ErrorMessage = ErrorReource.MaxLength)]
        public string? PhotoGuid { get; set; } = null!;

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool? IsActive { get; set; }
    }
}
