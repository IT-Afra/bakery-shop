﻿using Bakeryshop.Framework;
using System.ComponentModel.DataAnnotations;

namespace BakeryAdmin.Domain.Dtos
{
    public class TypeBreadDto
    {
        [Display(Name = "شناسه")]
        public long? Id { get; set; }

        [Display(Name = "نام")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(100, ErrorMessage = ErrorReource.MaxLength)]
        public string? Name { get; set; }

        [Display(Name = "تصویر")]
        [Required(ErrorMessage = ErrorReource.Required)]
        [MaxLength(50, ErrorMessage = ErrorReource.MaxLength)]
        public string? PhotoGuid { get; set; }

        [Display(Name = "وضعیت")]
        [Required(ErrorMessage = ErrorReource.Required)]
        public bool? IsActive { get; set; }
    }
}
