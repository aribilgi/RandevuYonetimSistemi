using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Page : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Sayfa Adı"), Required, StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Sayfa İçeriği"), Required, DataType(DataType.MultilineText)]
        public string PageContent { get; set; }
        [Display(Name = "Sayfa Resmi"), StringLength(100)]
        public string Image { get; set; }
        [Display(Name = "Aktif?")]
        public bool IsActive { get; set; }
        [Display(Name = "Üst Menüde Göster?")]
        public bool IsTopMenu { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
