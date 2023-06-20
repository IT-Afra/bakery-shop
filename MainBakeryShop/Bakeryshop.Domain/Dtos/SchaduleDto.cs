using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;

namespace Bakeryshop.Domain.Dtos
{
    public class SchaduleDto
    {
        public SchaduleDto()
        {
            SchaduleDetails = new List<SchaduleDetailDto>();
        }

        [Display(Name ="شناسه")]
        public long? Id { get; set; }

        [Display(Name = " تاریخ سفارش به حروف")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(10, ErrorMessage = ErrorReource.MaxLength)]
        public string? SchaduleDate { get; set; } = null!;

        [Display(Name = "ساعت سفارش به حروف")]
        [MaxLength(10, ErrorMessage = ErrorReource.MaxLength)]
        [Required(ErrorMessage = ErrorReource.Required)]
        public string? SchaduleTime { get; set; } = null!;
      
        List<SchaduleDetailDto> SchaduleDetails { get; set; }

    }
}
