﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Mehr.Models
{
    public class Category 
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Category Name")]
        public String Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage ="Display Ooder must be between 1-100.")]
        public int DisplayOrder { get; set; }
    }
}
