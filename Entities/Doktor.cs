using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Doktorlar")]
    public class Doktor : IEntity
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Adi { get; set; }
        [StringLength(50)]
        public string Soyadi { get; set; }
        [StringLength(11)]
        public string TcNo { get; set; }
        [StringLength(15)]
        public string Telefon { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        public string Adres { get; set; }
        public DateTime KayitTarihi { get; set; }
        public virtual List<Randevu> Randevular { get; set; }
    }
}
