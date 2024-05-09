﻿using System.ComponentModel.DataAnnotations;

namespace ABS3.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string ImagePath {  get; set; }
        public string role { get; set; }

        public virtual ICollection<Blog> Blogs { get; set; }



    }
}
