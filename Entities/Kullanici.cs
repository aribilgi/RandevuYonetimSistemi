using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Kullanicilar")]
    public class Kullanici : IEntity
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string KullaniciAdi { get; set; }
        [StringLength(50), Required]
        public string Sifre { get; set; }
        [StringLength(50), Required]
        public string Adi { get; set; }
        [StringLength(50), Required]
        public string Soyadi { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public bool Durum { get; set; }
        public DateTime? KayitTarihi { get; set; }
    }
}
