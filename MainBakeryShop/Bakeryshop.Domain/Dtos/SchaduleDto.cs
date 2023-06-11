using System;

using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;
namespace Bakeryshop.Domain.Dtos
{
    public class SchaduleDto
    {
        [Display(Name ="شناسه")]
        public long Id { get; set; }

        [Display(Name = " تاریخ سفارش به حروف")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(10, ErrorMessage = ErrorReource.MaxLength)]
        public string OrderDate { get; set; } = null!;


        [Display(Name = " تاریخ سفارش به عدد")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public long OrderDateL { get; set; }


        [Display(Name = "ساعت سفارش به حروف")]
        [MaxLength(10, ErrorMessage = ErrorReource.MaxLength)]
        [Required(ErrorMessage = ErrorReource.Required)]
        public string OrderTime { get; set; } = null!;


        [Display(Name = "ساعت سفارش به عدد")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public int OrderTimeL { get; set; }

    }
}
