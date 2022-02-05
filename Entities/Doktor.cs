using System;
using System.Collections.Generic;

namespace Entities
{
    public class Doktor : IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public DateTime KayitTarihi { get; set; }
        public virtual List<Randevu> Randevular { get; set; }
    }
}
