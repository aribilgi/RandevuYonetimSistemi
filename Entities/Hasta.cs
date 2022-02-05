using System;
using System.Collections.Generic;

namespace Entities
{
    public class Hasta : IEntity
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string TcNo { get; set; }
        public int Yasi { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Adres { get; set; }
        public string HastaYakinBilgisi { get; set; }
        public string KanGrubu { get; set; }
        public string Meslek { get; set; }
        public DateTime KayitTarihi { get; set; }
        public virtual List<Randevu> Randevular { get; set; }
    }
}
