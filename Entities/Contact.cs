using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        [StringLength(50), Required, Display(Name = "Adınız")]
        public string Name { get; set; }
        [StringLength(50), Required, Display(Name = "Soyadınız")]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20), Display(Name = "Telefon Numaranız")]
        public string Phone { get; set; }
        [StringLength(500), Required, Display(Name = "Mesaj"), DataType(DataType.MultilineText)]
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
