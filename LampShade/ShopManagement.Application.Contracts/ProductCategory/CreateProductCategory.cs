﻿using System.ComponentModel.DataAnnotations;
using _0_Framework.Application;

namespace ShopManagement.Application.Contracts.ProductCategory
{
    public class CreateProductCategory
    {
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        [MaxLength(255, ErrorMessage = ValidationMessages.MaxLength)]
        public string Name { get; set; }

        [MaxLength(1000, ErrorMessage = ValidationMessages.MaxLength)]
        public string Description { get; set; }

        public string Picture { get; set; }

        [MaxLength(450, ErrorMessage = ValidationMessages.MaxLength)]
        public string PictureAlt { get; set; }

        [MaxLength(255, ErrorMessage = ValidationMessages.MaxLength)]
        public string PictureTitle { get; set; }

        [MaxLength(80, ErrorMessage = ValidationMessages.MaxLength)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Keywords { get; set; }

        [MaxLength(120, ErrorMessage = ValidationMessages.MaxLength)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string MetaDescription { get; set; }

        [MaxLength(300, ErrorMessage = ValidationMessages.MaxLength)]
        [Required(ErrorMessage = ValidationMessages.IsRequired)]
        public string Slug { get; set; }
    }
}