﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("Randevular")]
    public class Randevu : IEntity
    {
        public int Id { get; set; }
        public int HastaId { get; set; }
        public int KullaniciId { get; set; }
        public int DoktorId { get; set; }
        [Display(Name = "Randevu Tarihi"), DataType(DataType.Date)]
        public DateTime RandevuTarihi { get; set; }
        [Display(Name = "Şikayet")]
        public string Sikayet { get; set; }
        [Display(Name = "Kronik Hastalık?")]
        public bool KronikHastalik { get; set; }
        public bool Sgk { get; set; }
        public virtual Hasta Hasta { get; set; }
        public virtual Kullanici Kullanici { get; set; }
        public virtual Doktor Doktor { get; set; }
    }
}
