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
        [StringLength(50), Required]
        public string Adi { get; set; }
        [StringLength(50), Required]
        public string Soyadi { get; set; }
        [StringLength(11), Required]
        public string TcNo { get; set; }
        public int Yasi { get; set; }
        [StringLength(15), Required]
        public string Telefon { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public string Adres { get; set; }
        [StringLength(100)]
        public string HastaYakinBilgisi { get; set; }
        [StringLength(10)]
        public string KanGrubu { get; set; }
        [StringLength(50)]
        public string Meslek { get; set; }
        public DateTime? KayitTarihi { get; set; }
        public virtual List<Randevu> Randevular { get; set; }
    }
}
