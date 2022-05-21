using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Contact : IEntity
    {
        public int Id { get; set; }
        [StringLength(50), Required]
        public string Name { get; set; }
        [StringLength(50), Required]
        public string Surname { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [StringLength(20)]
        public string Phone { get; set; }
        [StringLength(500), Required]
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
