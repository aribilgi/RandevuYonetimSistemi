using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Kullanicilar")]
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        [StringLength(50), Required, Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [StringLength(50), Required, Display(Name = "Şifre")]
        public string Sifre { get; set; }
        [StringLength(50), Required, Display(Name = "Adı")]
        public string Adi { get; set; }
        [StringLength(50), Required, Display(Name = "Soyadı")]
        public string Soyadi { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public bool Durum { get; set; }
        [Display(Name = "Kayıt Tarihi")]
        public DateTime? KayitTarihi { get; set; }
    }
}
