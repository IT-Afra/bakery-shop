using System;
using System;

using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;

namespace Bakeryshop.Domain.Dtos
{
    public class SchaduleDetailDto
    {
        [Display(Name = "شناسه")]
        public long Id { get; set; }

        [Display(Name = "شناسه زمانبندی")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public long SchaduleId { get; set; }

        [Display(Name = "شناسه نوع نان")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public long TypeBreadId { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public decimal Price { get; set; }

        [Display(Name = "تعداد")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public int Amount { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool IsActive { get; set; }


    }
}
