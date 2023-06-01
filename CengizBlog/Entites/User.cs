﻿using System.ComponentModel.DataAnnotations;

namespace CengizBlog.Entites
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Soyadı"), StringLength(100)]
        public string Surname { get; set; }
        [StringLength(100), EmailAddress]
        public string Email { get; set; }
        [Display(Name = "Şifre"), StringLength(50)]
        public string Password { get; set; }
        [Display(Name = "Kullanıcı Adı"), StringLength(100)]
        public string? UserName { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
