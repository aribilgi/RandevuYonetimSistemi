using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Hastalar")]
    public class Hasta : IEntity
    {
        public int Id { get; set; }
        [StringLength(50), Required, Display(Name = "Adınız")]
        public string Adi { get; set; }
        [StringLength(50), Required, Display(Name = "Soyadınız")]
        public string Soyadi { get; set; }
        [StringLength(11), Required, Display(Name = "TC Kimlik No")]
        public string TcNo { get; set; }
        [Display(Name = "Hasta Yaşı")]
        public int Yasi { get; set; }
        [StringLength(15), Required]
        public string Telefon { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(50), Display(Name = "Şifre")]
        public string Password { get; set; }
        [DataType(DataType.MultilineText)]
        public string Adres { get; set; }
        [StringLength(100), Display(Name = "Hasta Yakın Bilgisi")]
        public string HastaYakinBilgisi { get; set; }
        [StringLength(10), Display(Name = "Hasta Kan Grubu")]
        public string KanGrubu { get; set; }
        [StringLength(50)]
        public string Meslek { get; set; }
        [Display(Name = "Kayıt Tarihi")]
        public DateTime? KayitTarihi { get; set; } = DateTime.Now; // varsayılan değer şimdiki zaman
        public virtual List<Randevu> Randevular { get; set; }
    }
}
