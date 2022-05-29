using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Page : IEntity
    {
        public int Id { get; set; }
        [Display(Name = "Sayfa Adı"), Required, StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Sayfa İçeriği"), Required]
        public string PageContent { get; set; }
        [Display(Name = "Sayfa Resmi"), StringLength(100)]
        public string Image { get; set; }
    }
}
