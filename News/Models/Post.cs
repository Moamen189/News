﻿using System;
using System.ComponentModel.DataAnnotations;

namespace News.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Title { get; set; }
        [Required]
      
        public string Content { get; set; }

        public string Image { get; set; }

        public DateTime Created { get; set; }

        public int CategoryId { get; set; }
        public virtual Catogery Catogery { get; set; }
    }
}
