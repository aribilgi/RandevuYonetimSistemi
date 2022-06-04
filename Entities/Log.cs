using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Log : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Hata")]
        public string Error { get; set; }
        [Display(Name = "Hata Oluşma Tarihi")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "Hata Bilgisi")]
        public string HataBilgi { get; set; }
    }
}
