using System.ComponentModel.DataAnnotations;

namespace RandevuYonetimSistemi.MvcUI.Models
{
    public class AdminLoginViewModel
    {
        [StringLength(50), Required, Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [StringLength(50), Required, Display(Name = "Şifre"), DataType(DataType.Password)]
        public string Sifre { get; set; }
    }
}